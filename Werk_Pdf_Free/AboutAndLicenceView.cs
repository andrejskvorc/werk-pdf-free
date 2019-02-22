using MaterialSkin;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Werk_Pdf_Free
{
    public partial class AboutAndLicenceView : UserControl
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
        public AboutAndLicenceView()
        {
            InitializeComponent();
            this.AllowDrop = false;

            RegularFonts();
            BoldFonts();

            var materialSkinManager = MaterialSkinManager.Instance; 

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }
        private void AboutAndLicenceView_Load(object sender, EventArgs e)
        {
            LicenceTextBox.Text = Properties.Resources.Licence;
            LicenceMaterialLabel.Font = RobotoRegulatFont11;
            linkLabel.Font = RobotoRegulatFont11;
            WhoMaterialLabel.Font = RobotoRegulatFont11;
            AppNameMaterialLabel.Font = RobotoBoldFont12;
            VersionMaterialLabel.Font = RobotoRegulatFont11;
        }

        private void SaveMaterialFlatButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveLicenceDialog = new SaveFileDialog
            {
                Filter = "rtf files (*.rtf)|*.rtf",
                RestoreDirectory = true,
                FileName = "werk-pdf-free-licence.rtf"
            };

            if (saveLicenceDialog.ShowDialog() == DialogResult.OK)
            {

                LicenceTextBox.SaveFile(saveLicenceDialog.FileName);
               
            }
        }
    }
}
