using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class SearchForm : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoRegulatFont825;


        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly PdfSearchManager _searchManager;

        private bool _findDirty;

        public SearchForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icons8_split_files_961;

            byte[] fontData = Properties.Resources.Roboto_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Roboto_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Roboto_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            RobotoRegulatFont11 = new Font(fonts.Families[0], 11.0F);
            RobotoRegulatFont825 = new Font(fonts.Families[0], 8.25F);


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {

          
        }

        public SearchForm(PdfRenderer renderer)
        {
            if (renderer == null)
                throw new ArgumentNullException(nameof(renderer));

            InitializeComponent();

            _searchManager = new PdfSearchManager(renderer);

            _matchCase.Checked = _searchManager.MatchCase;
            _matchWholeWord.Checked = _searchManager.MatchWholeWord;
            _highlightAll.Checked = _searchManager.HighlightAllMatches;
        }

        private void _matchCase_CheckedChanged(object sender, EventArgs e)
        {
            _findDirty = true;
            _searchManager.MatchCase = _matchCase.Checked;
        }

        private void _matchWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            _findDirty = true;
            _searchManager.MatchWholeWord = _matchWholeWord.Checked;
        }

        private void _highlightAll_CheckedChanged(object sender, EventArgs e)
        {

            _searchManager.HighlightAllMatches = _highlightAll.Checked;
        }

        private void _find_TextChanged(object sender, EventArgs e)
        {
            _findDirty = true;
        }

        private void Find(bool forward)
        {
            if (_findDirty)
            {
                _findDirty = false;

                if (!_searchManager.Search(_find.Text))
                {
                    MessageBox.Show(this, "No matches found.");
                    return;
                }
            }

            if (!_searchManager.FindNext(forward))
                MessageBox.Show(this, "Find reached the starting point of the search.");
        }

        private void _findPrevious_Click(object sender, EventArgs e)
        {
            Find(false);
        }

        private void _findNext_Click(object sender, EventArgs e)
        {
            Find(true);
        }
    }
}
