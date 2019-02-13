using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werk_Pdf_Free
{
    public static class Helpers
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly string tmpFolder = System.IO.Path.GetTempPath();

        public static string TempDirectory = Path.Combine(tmpFolder);
    }
}
