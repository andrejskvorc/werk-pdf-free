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
using PdfiumViewer;

namespace Werk_Pdf_Free
{
    public partial class PdfDocumentUserControl : UserControl
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
         IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoBoldFont12;
        Font RobotoRegulatFont10;
        Font RobotoRegulatFont9;
        Font RobotoRegulatFont825;

        private string inputFileName = null;

        private string outputFileName = null;

       

        public Color _defaultBackColor { get; set; }
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
        public PdfDocumentUserControl()
        {
            InitializeComponent();
            this.AllowDrop = true;

            RegularFonts();
            BoldFonts();

            var materialSkinManager = MaterialSkinManager.Instance; 

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }
        private void PdfDocumentUserControl_Load(object sender, EventArgs e)
        {
            BackColor = _defaultBackColor;
        }
        
        private void PdfDocumentUserControl_DragDrop(object sender, DragEventArgs e)
        {
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
                    //Add extracted files to Tuple
                    foreach (string item in FileList)
                    {
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

                    //Here u get multiple file names writen in tuple list
                    FileListT.Add(new Tuple<string>(filename));
                }


            }
            else
            {
                return;
            }

            // Do something with the data...

            if (FileListT.Count() <= 0 || FileListT.Count() >= 2)
            {
                MessageBoxForm msgbox = new MessageBoxForm()
                {
                    Caption = "Error: One file allowed",
                    Message = "Error: Only one file is allowed for Drag and Drop operation!"
                };

                msgbox.ShowDialog();
                msgbox.Dispose();
                return;

            }
            else
            {

                foreach (Tuple<string> FileFromList in FileListT)
                {
                    string Ext = Path.GetExtension(FileFromList.Item1).ToLower();

                    string Name = Path.GetFileName(FileFromList.Item1);

                    string FileName = Path.Combine(Helpers.TempDirectory + Name);

                    string FileNameWithoutExt = Path.GetFileNameWithoutExtension(FileFromList.Item1);

                    switch (Ext)
                    {
                        case ".pdf":


                            inputFileName = FileFromList.Item1;

                            pdfViewer.Document?.Dispose();

                            pdfViewer.Document = OpenDocument(inputFileName);

                            PdfDocument document = OpenDocument(inputFileName);

                            int count = document.PageCount;

                            
                         


                            break;

                        default:

                            MessageBoxForm msgbox = new MessageBoxForm()
                            {
                                Caption = "Error: PDF file allowed",
                                Message = "Error: Only PDF file is allowed for Drag and Drop operation!"
                            };

                            msgbox.ShowDialog();
                            msgbox.Dispose();
                            break;
                    }
                }
            }
        }


        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void PdfDocumentUserControl_DragEnter(object sender, DragEventArgs e)
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
        private void PdfDocumentUserControl_DragOver(object sender, DragEventArgs e)
        {
            if (AmIStillInsideTheUserControl(this) == true)
                this.BackColor = Color.LightBlue;
        }
        private void PdfDocumentUserControl_DragLeave(object sender, EventArgs e)
        {
            if (AmIStillInsideTheUserControl(this) == false)
                this.BackColor = _defaultBackColor;

        }
        private bool AmIStillInsideTheUserControl(Control control)
        {
            Rectangle r = control.RectangleToScreen(control.ClientRectangle);
            Point p = Cursor.Position;
            return r.Contains(p);
        }

        private void CloseFlatButton_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void CloseFile()
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }
    }
}
