using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamSpecflowTests.Helpers
{
    public class CheckDownloadingHelper
    {
        private static readonly string SteamAppFullFilePath = @"C:\Users\e.sarkisyan\Downloads\SteamSetup.exe";

        public static bool CheckIfSteamAppFileDownloaded()
        {
            const int fileDownLoadingTimeMs = 20000;

            Thread.Sleep(fileDownLoadingTimeMs);

            var fileExists = File.Exists(SteamAppFullFilePath);

            if(fileExists)
            {
                File.Delete(SteamAppFullFilePath);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
