using System;
using System.IO;
using System.Windows.Forms;

namespace Werk_Pdf_Free
{
    static class Program
    {
        private const string UniqeAppIdentity = "{91edb993-b7e3-4c7e-821e-754ee4d7b12c}";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Helpers.DocumentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SplitedPDFs\";

            if (Directory.Exists(Helpers.DocumentDirectory) == false)
            {
                Directory.CreateDirectory(Helpers.DocumentDirectory);
            }

            Application.Run(new Werk_Pdf_Free());
        }
    }
}
