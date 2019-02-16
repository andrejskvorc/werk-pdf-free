using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Text;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Werk_Pdf_Free
{
    public partial class MergePDF : UserControl
    {
        //Declare loging component
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        //Createing and loading embeded font so user does not have to install it in his system
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
         IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoBoldFont12;
        Font RobotoRegulatFont10;
        Font RobotoRegulatFont9;
        Font RobotoRegulatFont825;

        // The LVItem being dragged
        private ListViewItem _itemDnD = null;

        //Seting default backcolor for user control
        public Color _defaultBackColor { get; set; }

        //Loading regular fonts
        private void RegularFonts()
        {
            byte[] fontDataRegualar = Properties.Resources.Roboto_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontDataRegualar.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontDataRegualar, 0, fontPtr, fontDataRegualar.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Roboto_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Roboto_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);


            RobotoRegulatFont11 = new Font(fonts.Families[0], 11.0F);
            RobotoRegulatFont10 = new Font(fonts.Families[0], 10.0F);
            RobotoRegulatFont9 = new Font(fonts.Families[0], 9.0F);
            RobotoRegulatFont825 = new Font(fonts.Families[0], 8.25F);

        }

        //Loading Boldfonts
        private void BoldFonts()
        {
            byte[] fontDataBold = Properties.Resources.Roboto_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontDataBold.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontDataBold, 0, fontPtr, fontDataBold.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Roboto_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Roboto_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            RobotoBoldFont12 = new Font(fonts.Families[0], 12.0F);

        }
        public MergePDF()
        {
            InitializeComponent();
            RegularFonts();
            BoldFonts();

            //Creating materialSking manager
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void MergePDF_Load(object sender, EventArgs e)
        {
            BackColor = _defaultBackColor;
            HeaderLabel.Font = RobotoBoldFont12;
            HeaderLabel.ForeColor = Color.White;

            Point position = new Point
            {
                X = FilesListView.Width + 60, 
                Y = LoadFilesFlatButton.Location.Y
            };

            LoadFilesFlatButton.Location = position;

            position.Y = MergeFlatButton.Location.Y;

            MergeFlatButton.Location = position;

            FilesListView.Columns[0].Width = FilesListView.Width;
            

        }
        private bool AmIStillInsideTheUserControl(Control control)
        {
            //Function for DragAndDrop to check if mouse is still over user control
            Rectangle r = control.RectangleToScreen(control.ClientRectangle);
            Point p = Cursor.Position;
            return r.Contains(p);
        }
        private void LoadFilesFlatButton_Click(object sender, EventArgs e)
        {
            //ToDo: Create MaterialSkin LoadFileDialog
            //We ask user to select PDF files for merging and load them to ListView
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Open PDF File for spliting",
                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //For better readability we show in listview only names, and save complete path with name in imageKey string of listview
                foreach(string item in openFileDialog.FileNames)
                {
                    FilesListView.Items.Add(Path.GetFileName(item), item);
                }
               
            }
        }
        private void MergePdfContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (FilesListView.Items.Count <= 1)
            {
                pleaseLoadPDFFilesToolStripMenuItem.Visible = true;
                moveUpToolStripMenuItem.Visible = false;
                moveDownToolStripMenuItem.Visible = false;
            }
            else
            {
                pleaseLoadPDFFilesToolStripMenuItem.Visible = false;
                moveUpToolStripMenuItem.Visible = true;
                moveDownToolStripMenuItem.Visible = true;
            }
        }
        private void FilesListView_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = FilesListView.GetItemAt(e.X, e.Y);
            // if the LV is still empty, no item will be found anyway,
            // so we don't have to consider this case
        }
        private void FilesListView_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null)
                return;

            // Show the user that a drag operation is happening
            Cursor = Cursors.Hand;
        }
        private void FilesListView_MouseUp(object sender, MouseEventArgs e)
        {
            // use 0 instead of e.X so that you don't have
            // to keep inside the columns while dragging
            ListViewItem itemOver = FilesListView.GetItemAt(0, e.Y);

            if (itemOver == null)
                return;

            Rectangle rc = itemOver.GetBounds(ItemBoundsPortion.Entire);

            // find out if we insert before or after the item the mouse is over
            bool insertBefore;
            if (e.Y < rc.Top + (rc.Height / 2))
                insertBefore = true;
            else
                insertBefore = false;

            if (_itemDnD != itemOver)
            // if we dropped the item on itself, nothing is to be done
            {
                if (insertBefore)
                {
                    FilesListView.Items.Remove(_itemDnD);
                    FilesListView.Items.Insert(itemOver.Index, _itemDnD);
                }
                else
                {
                    FilesListView.Items.Remove(_itemDnD);
                    FilesListView.Items.Insert(itemOver.Index + 1, _itemDnD);
                }
            }
        }
        private void MoveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveListViewItems(FilesListView, MoveDirection.Up);
        }
        private void MoveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveListViewItems(FilesListView, MoveDirection.Down);
        }
        private enum MoveDirection { Up = -1, Down = 1 };
        private static void MoveListViewItems(ListView sender, MoveDirection direction)
        {
            int dir = (int)direction;
            int opp = dir * -1;

            bool valid = sender.SelectedItems.Count > 0 &&
                            ((direction == MoveDirection.Down && (sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1))
                        || (direction == MoveDirection.Up && (sender.SelectedItems[0].Index > 0)));

            if (valid)
            {
                foreach (ListViewItem item in sender.SelectedItems)
                {
                    int index = item.Index + dir;
                    sender.Items.RemoveAt(item.Index);
                    sender.Items.Insert(index, item);
                }
            }
        }
        private void MergePDF_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            //    or this tells us if it is an Outlook attachment drop
            else if (e.Data.GetDataPresent("FileGroupDescriptor"))
            { e.Effect = DragDropEffects.Copy; }
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }
        private void MergePDF_DragDrop(object sender, DragEventArgs e)
        {
            //Making shure backcolor is normal color
            this.BackColor = _defaultBackColor;

            //Tuple to store all files
            List<Tuple<string>> FileListT = new List<Tuple<string>>();

            //Temp string list for Drag And Drop from explorer
            string[] FileList = null;

            //Detect drag and drop from Explorer
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                // Extract the data from the DataObject-Container into a string list
                FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                try
                {
                    //Add extracted pdf files to Tuple
                    foreach (string item in FileList)
                    {
                        if (Path.GetExtension(item).ToLower() == ".pdf")
                            FileListT.Add(new Tuple<string>(item));
                    }

                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }


            }
            //Detect drag and drop from Outlook
            else if (e.Data.GetDataPresent("FileGroupDescriptor"))
            {

                OutlookDataObject dataObject = new OutlookDataObject(e.Data);
                string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
                MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

                for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
                {

                    //use the fileindex to get the name and data stream
                    string filename = Path.Combine(Helpers.TempDirectory + filenames[fileIndex]);
                    MemoryStream filestream = filestreams[fileIndex];

                    //save the file stream using its name to the application path
                    FileStream outputStream = System.IO.File.Create(filename);
                    filestream.WriteTo(outputStream);
                    outputStream.Close();


                    //Here u get multiple file names writen in tuple list if they are with .pdf extension
                    if ( Path.GetExtension(filename).ToLower() == ".pdf" )
                        FileListT.Add(new Tuple<string>(filename));
                }
            }
            else
            {
                return;
            }

            // here we go thru tuple list with all files and add them to the listview, but first we check if we have any pdf file in the list

            if (FileListT.Count() <= 0 )
            {
                MessageBoxForm msgbox = new MessageBoxForm()
                {
                    Caption = "Error: No PDF files",
                    Message = "Error: For merging we accept only PDF files!"
                };

                msgbox.ShowDialog();
                msgbox.Dispose();
                return;
            }
            else
            {
                foreach (Tuple<string> FileFromList in FileListT)
                {
                    FilesListView.Items.Add(Path.GetFileName(FileFromList.Item1), FileFromList.Item1);
                }
            }
          
        }
        private void MergePDF_DragLeave(object sender, EventArgs e)
        {
            //Return user control color to normal color
            if (AmIStillInsideTheUserControl(this) == false)
                this.BackColor = _defaultBackColor;
        }
        private void MergePDF_DragOver(object sender, DragEventArgs e)
        {
            //Change user control color so we know we are above target area for drag and drop
            if (AmIStillInsideTheUserControl(this) == true)
                this.BackColor = Color.LightBlue;
        }
        private void MergeFlatButton_Click(object sender, EventArgs e)
        {

            //ToDo: Create MaterialSkin SaveFileDialog
            SaveFileDialog savePdfFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "PDF File for saving",
                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                CheckPathExists = true
            };

            if (savePdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPdfFile = savePdfFileDialog.FileName;

                PdfDocument outputPDFDocument = new PdfDocument();

                foreach (ListViewItem item in FilesListView.Items)
                {

                    PdfDocument inputPDFDocument = PdfReader.Open(item.ImageKey, PdfDocumentOpenMode.Import);

                    outputPDFDocument.Version = inputPDFDocument.Version;

                    foreach (PdfPage page in inputPDFDocument.Pages)
                    {
                        outputPDFDocument.AddPage(page);
                    }
                }

                outputPDFDocument.Save(outputPdfFile);
            }


        

        }
    }
}
