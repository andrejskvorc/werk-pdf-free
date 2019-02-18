using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Werk_Pdf_Free
{
    public partial class Werk_Pdf_Free : MaterialForm
    {
        private Point startLocation = new Point();

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoRegulatFont10;
        Font RobotoRegulatFont9;
        Font RobotoRegulatFont825;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Werk_Pdf_Free()
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
            RobotoRegulatFont10 = new Font(fonts.Families[0], 10.0F);
            RobotoRegulatFont9 = new Font(fonts.Families[0], 9.0F);
            RobotoRegulatFont825 = new Font(fonts.Families[0], 8.25F);


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Werk_Pdf_Free_Load(object sender, EventArgs e)
        {

            startLocation = this.Location;
            
            var _SplitPdf = new SplitPdf
            {
                _defaultBackColor = this.BackColor,
                Dock = DockStyle.Fill
            };

            this.PdfSplitContainer.Panel2.Controls.Add(_SplitPdf);

         }

        private void ExitFlatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
        private void SplitPdfControlFlatButton_Click(object sender, EventArgs e)
        {

            this.SetDesktopLocation(startLocation.X, startLocation.Y);

            System.Drawing.Size frmSize = new System.Drawing.Size
            {
                Width = 820,
                Height = 420
            };

            this.Size = frmSize;

            this.SizeGripStyle = SizeGripStyle.Hide;
           
                      
            if (PdfSplitContainer.Panel2.Controls.Count <= 0)
            {
                AddControl(new SplitPdf() { _defaultBackColor = this.BackColor });
            }
            else
            {
                foreach (Control control in PdfSplitContainer.Panel2.Controls)
                {
                    if (control.Name != "SplitPdf")
                    {
                        control.Dispose();
                        PdfSplitContainer.Panel2.Controls.Remove(control);
                    }
                    else
                    {
                        return;
                    }
                }

                AddControl(new SplitPdf() { _defaultBackColor = this.BackColor});
            }      
        }

        private void AddControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            PdfSplitContainer.Panel2.Controls.Add(control);
        }

        private void MergePdfFilesFlatButton_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(startLocation.X, startLocation.Y);

            System.Drawing.Size frmSize = new System.Drawing.Size
            {
                Width = 820,
                Height = 420
            };

            this.Size = frmSize;

            this.SizeGripStyle = SizeGripStyle.Hide;

            if (PdfSplitContainer.Panel2.Controls.Count <= 0)
            {
                AddControl(new SplitPdf() { _defaultBackColor = this.BackColor });
            }
            else
            {
                foreach (Control control in PdfSplitContainer.Panel2.Controls)
                {
                    if (control.Name != "MergePDF")
                    {
                        control.Dispose();
                        PdfSplitContainer.Panel2.Controls.Remove(control);
                    }
                    else
                    {
                        return;
                    }
                }

                AddControl(new MergePDF() { _defaultBackColor = this.BackColor });
            }
        }

        private void SettingsFlatButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Size frmSize = new System.Drawing.Size
            {
                Width = 820,
                Height = 420
            };

            this.Size = frmSize;

            this.SetDesktopLocation(startLocation.X, startLocation.Y);

            this.SizeGripStyle = SizeGripStyle.Hide;

            if (PdfSplitContainer.Panel2.Controls.Count <= 0)
            {
                //AddControl(new SplitPdf() { _defaultBackColor = this.BackColor });
            }
            else
            {
                foreach (Control control in PdfSplitContainer.Panel2.Controls)
                {
                    PdfSplitContainer.Panel2.Controls.Remove(control);
                    //if (control.Name != "Settings")
                    //{
                    //    control.Dispose();
                    //    PdfSplitContainer.Panel2.Controls.Remove(control);
                    //}
                    //else
                    //{
                    //    return;
                    //}
                }

              //  AddControl(new MergePDF() { _defaultBackColor = this.BackColor });
            }

        }

        private void ManualSplitFlatButton_Click(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            System.Drawing.Size frmSize = new System.Drawing.Size
            {
                Width = area.Width-200,
                Height = area.Height-100
            };

            this.Size = frmSize;
            
            this.SizeGripStyle = SizeGripStyle.Show;

            if (PdfSplitContainer.Panel2.Controls.Count <= 0)
            {
                //AddControl(new SplitPdf() { _defaultBackColor = this.BackColor });
            }
            else
            {
                foreach (Control control in PdfSplitContainer.Panel2.Controls)
                {
                    PdfSplitContainer.Panel2.Controls.Remove(control);

                    //if (control.Name != "ManualSplit")
                    //{
                    //    control.Dispose();
                    //    PdfSplitContainer.Panel2.Controls.Remove(control);
                    //}
                    //else
                    //{
                    //    return;
                    //}
                }

                //  AddControl(new MergePDF() { _defaultBackColor = this.BackColor });
            }

        }

        private void ViewPdfFlatButton_Click(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            System.Drawing.Size frmSize = new System.Drawing.Size
            {
                Width = area.Width - 200,
                Height = area.Height - 100
            };

            this.SetDesktopLocation(100, 20);

            this.Size = frmSize;

            this.SizeGripStyle = SizeGripStyle.Show;

            if (PdfSplitContainer.Panel2.Controls.Count <= 0)
            {
              // AddControl(new SplitPdf() { _defaultBackColor = this.BackColor });
            }
            else
            {
                foreach (Control control in PdfSplitContainer.Panel2.Controls)
                {

                    PdfSplitContainer.Panel2.Controls.Remove(control);
                    //if (control.Name != "ViewPdf")
                    //{
                    //    control.Dispose();
                    //    PdfSplitContainer.Panel2.Controls.Remove(control);
                    //}
                    //else
                    //{
                    //    return;
                    //}
                }

                //  AddControl(new MergePDF() { _defaultBackColor = this.BackColor });
            }
        }
    }
}
