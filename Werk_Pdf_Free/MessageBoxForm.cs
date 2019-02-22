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

namespace Werk_Pdf_Free
{
    public partial class MessageBoxForm : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoRegulatFont825;


        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string Message { get; set; }
        public string Caption { get; set; }

        public MessageBoxForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.WerkPDF;

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

        private void ExitFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {

            this.Text = Caption;

            Message1Label.Text = Message;

            OkFlatButton.Font = RobotoRegulatFont825;

            Message1Label.Font = RobotoRegulatFont11;
        }
    }
}
