using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImgONE
{
    class ftp
    {
        public static WebClient web_client = new WebClient();
       
        public static Boolean upload(Bitmap bmp)
        {
            using (var ms = new MemoryStream())
            {
                if (Settings.upload_format == "png")
                {
                    bmp.Save(ms, ImageFormat.Png);
                }
                else if (Settings.upload_format == "bmp")
                {
                    bmp.Save(ms, ImageFormat.Bmp);
                }
                else if (Settings.upload_format == "jpg")
                {
                    bmp.Save(ms, ImageFormat.Jpeg);
                }
                else {
                    bmp.Save(ms, ImageFormat.Png);
                }
                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + Settings.upload_format;
                Uri ftpserver = new Uri("ftp://" + Settings.ftp_server + Settings.ftp_path + "/" + filename);
                frm_Main.last_ftp_file = filename;
                web_client.Credentials = new NetworkCredential(Settings.ftp_username, CryptorEngine.Decrypt(Settings.ftp_password));
                web_client.UploadDataAsync(ftpserver, ms.ToArray());
            }
            return true;
        }


        public static Boolean delete(string filename)
        {
            Uri serverUri = new Uri("ftp://" + Settings.ftp_server + Settings.ftp_path + "/" + filename);
            try
            {
                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return false;
                }
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
                request.Credentials = new NetworkCredential(Settings.ftp_username, CryptorEngine.Decrypt(Settings.ftp_password));
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //MessageBox.Show(Convert.ToString(response.StatusCode));
                response.Close();
                return true;
            }
            catch
            {
                return false;
            }  
        }
    }
}
