using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Syroot.Windows.IO;
using FileDownloader;
using System.Diagnostics;
using MaterialSkin.Controls;
using System.Threading;

namespace Werk_Pdf_Free
{
    public static class UpdateCheck
    {


        private static string NewVersionUrl { get; set; }
        private static string NewVersionFileName { get; set; }
        private enum Status
        {
            None,
            Old,
            New
        }

        private static IFileDownloader fileDownloader = new FileDownloader.FileDownloader();

        public static void Start(MaterialFlatButton button)
        {
            bool newVersion = UpdateCheck.IsNewVersionAvailable();

            if (newVersion == true)
            {
                button.Visible = true;
                UpdateCheck.StartUpdate();
            }
        }

        public static void StartUpdate()
        {
            Thread t = new Thread(new ThreadStart(DownloadNewVersion));
            t.Start();

        }

        private static void DownloadNewVersion()
        {
           
            fileDownloader.DownloadFileCompleted += DownloadFileCompleted;
            fileDownloader.DownloadFileAsync(new Uri(NewVersionUrl), NewVersionFileName);

        }

        private static void DownloadFileCompleted(object sender, DownloadFileCompletedArgs eventArgs)
        {
            if (eventArgs.State == CompletedState.Succeeded)
            {

                Process process = new Process();

                process.StartInfo.FileName = NewVersionFileName;
                process.Start();

                Application.Exit();
                }
            else if (eventArgs.State == CompletedState.Failed)
            {
               
          
            }
        }

        public static bool IsNewVersionAvailable()
        {
            var jsonRelease = JsonConvert.DeserializeObject(GetLatestRelease("andrejskvorc", "werk-pdf-free"));
  
            JObject jObjectRelease = JObject.FromObject(jsonRelease);


            string vForCheck = (string)jObjectRelease["tag_name"];

            vForCheck = vForCheck.Replace("v", "");

            NewVersionUrl = (string)(jObjectRelease["assets"][0]["browser_download_url"]);
            NewVersionFileName = Path.Combine(new KnownFolder(KnownFolderType.Downloads).Path + @"\" + (string)jObjectRelease["assets"][0]["name"]);

            bool value = false;

            switch (CompareVersion(vForCheck))
            {
                case Status.None:
                    value = false;
                    break;
                case Status.Old:
                    value = false;
                    break;
                case Status.New:
                    NewVersionUrl = (string)jObjectRelease["assets"]["browser_download_url"];
                    NewVersionFileName = Path.Combine(new KnownFolder(KnownFolderType.Desktop).Path + @"\" + (string)jObjectRelease["assets"]["name"]);
                    value = true;
                    break;

            }

            return value;
        }

        private static Status CompareVersion(string version)
        {
            string GetCurrent = Application.ProductVersion;

            int vCurrent = Convert.ToInt32(GetCurrent.Replace(".", ""));

            int vNew = Convert.ToInt32( version.Replace(".", ""));

            if (vCurrent == vNew)
            {
                return Status.Old;
            }
            else if(vCurrent < vNew)
            {
                return Status.New;
            }
            else
            {
                return Status.Old;
            }

        }

        private static string GetLatestRelease(string username, string repoName)
        {
            const string GITHUB_API = "https://api.github.com/repos/{0}/{1}/releases/latest";
            WebClient webClient = new WebClient();
            // Added user agent
            webClient.Headers.Add("User-Agent", "WerkPdf Free");
            Uri uri = new Uri(string.Format(GITHUB_API, username, repoName));
            string releases = webClient.DownloadString(uri);
            return releases;
        }

    }
}
