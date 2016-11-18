using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace ImgONE
{
    class Updates
    {
        public static WebClient web_client = new WebClient();

        public static Boolean downloadUpdates()
        {
            try
            {
                /*string link = "https://github.com/Gigawiz/ImgONE/releases/download/" + Settings.build + "/ImgONE-r" + Settings.build + ".7z";
                if (File.Exists("updater.exe"))
                {
                    File.Delete("updater.exe");
                }
                web_client.DownloadFileAsync(new Uri(link), "updater.exe");*/
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
