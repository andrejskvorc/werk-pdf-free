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

        // The LVItem being dragged
        private ListViewItem _itemDnD = null;

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
        public MergePDF()
        {
            InitializeComponent();
            RegularFonts();
            BoldFonts();

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

            FilesListView.Columns[0].Width = FilesListView.Width;
            

        }
        private bool AmIStillInsideTheUserControl(Control control)
        {
            Rectangle r = control.RectangleToScreen(control.ClientRectangle);
            Point p = Cursor.Position;
            return r.Contains(p);
        }
        private void LoadFilesFlatButton_Click(object sender, EventArgs e)
        {
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

    }
}
