using System;
using System.Collections.Generic;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
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
    public partial class PDF_AutoSplitForm : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font RobotoRegulatFont11;
        Font RobotoRegulatFont10;
        Font RobotoRegulatFont9;
        Font RobotoRegulatFont825;


        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly MaterialSkinManager materialSkinManager;

        private string inputFileName;
        private string outputFileName;

        public PDF_AutoSplitForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icons8_split_files_961;

            this.AllowDrop = true;

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

        private void ExitFlatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PDF_AutoSplit_Load(object sender, EventArgs e)
        {
            InputFileNameLabel.Font = RobotoRegulatFont11;
            OutputFilePrefixLabel.Font = RobotoRegulatFont11;
            OutputNameLabel.Font = RobotoRegulatFont11;
            OutputFileNameSufixLabel.Font = RobotoRegulatFont11;
            OutputFileNameLabel.Font = RobotoRegulatFont11;
            PageNumbersCheckBox.Font = RobotoRegulatFont10;

            InputFileNameSingleLineTextField.Font = RobotoRegulatFont825;
            OutputFileNamePrefixSingleLineTextField.Font = RobotoRegulatFont825;
            OutputNameSingleLineTextField.Font = RobotoRegulatFont825;
            OutputFileNameSufixSingleLineTextField.Font = RobotoRegulatFont825;
            OutputFileNameSingleLineTextField.Font = RobotoRegulatFont825;

            LoadFileFlatButton.Font = RobotoRegulatFont825;
            SplitFlatButton.Font = RobotoRegulatFont825;
            ExitFlatButton.Font = RobotoRegulatFont825;

            Message1Label.Font = RobotoRegulatFont9;
            Message2Label.Font = RobotoRegulatFont9;
        }

        private void ProcessInputFile()
        {
            InputFileNameSingleLineTextField.Text = Path.GetFileName(inputFileName);
            OutputNameSingleLineTextField.Text = Path.GetFileNameWithoutExtension(inputFileName);
            GenerateName();
        }

        private void GenerateName()
        {
           // OutputNameSingleLineTextField.Text = OutputFileNamePrefixSingleLineTextField.Text + OutputNameSingleLineTextField.Text + OutputFileNameSufixSingleLineTextField.Text + ".pdf";
        }

        private void PDF_AutoSplitForm_DragEnter(object sender, DragEventArgs e)
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

        private void PDF_AutoSplitForm_DragDrop(object sender, DragEventArgs e)
        {

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

                            //System.IO.File.Move(FileFromList.Item1, FileName);

                            inputFileName = FileFromList.Item1;

                            ProcessInputFile();

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

        private void OutputFileNamePrefixSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void OutputNameSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void OutputFileNameSufixSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            GenerateName();
        }

        private void SplitFlatButton_Click(object sender, EventArgs e)
        {




            PdfDocument inputDocument = PdfReader.Open(inputFileName, PdfDocumentOpenMode.Import);
            string name = Path.GetFileNameWithoutExtension(OutputFileNameSingleLineTextField.Text);

            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {
                // Create new document
                PdfDocument outputDocument = new PdfDocument
                {
                    Version = inputDocument.Version
                };

               if(PageNumbersCheckBox.CheckState == CheckState.Checked)
                {
                    outputDocument.Info.Title =
                            String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                    outputDocument.Info.Creator = inputDocument.Info.Creator;

                    // Add the page and save it
                    outputDocument.AddPage(inputDocument.Pages[idx]);
                    outputDocument.Save(String.Format("{0} - Page {1} of {2}.pdf", name, idx + 1, inputDocument.PageCount));
                }
                else
                {
                    outputDocument.Info.Title =
                            String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                    outputDocument.Info.Creator = inputDocument.Info.Creator;

                    // Add the page and save it
                    outputDocument.AddPage(inputDocument.Pages[idx]);
                    outputDocument.Save(String.Format("{0} - Page {1}.pdf", name, idx + 1));
                }

            }

        }

        public void Example()
        {
            // Get a fresh copy of the sample PDF file
            const string filename = "Portable Document Format.pdf";
            File.Copy(Path.Combine("../../../../../PDFs/", filename),
              Path.Combine(Directory.GetCurrentDirectory(), filename), true);

            // Open the file
            PdfDocument inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);

            string name = Path.GetFileNameWithoutExtension(filename);
            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {
                // Create new document
                PdfDocument outputDocument = new PdfDocument
                {
                    Version = inputDocument.Version
                };

                outputDocument.Info.Title =
                  String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                outputDocument.Info.Creator = inputDocument.Info.Creator;

                // Add the page and save it
                outputDocument.AddPage(inputDocument.Pages[idx]);
                outputDocument.Save(String.Format("{0} - Page {1}_tempfile.pdf", name, idx + 1));
            }
        }


        private void LoadFileFlatButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Open PDF File for spliting",
                DefaultExt = "pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFileName = openFileDialog.FileName;
                ProcessInputFile();
            }


        }
    }
}
