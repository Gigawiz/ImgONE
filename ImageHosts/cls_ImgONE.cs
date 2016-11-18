using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Text;

namespace ImgONE
{
    class ImgONE
    {
        public static WebClient web_client = new WebClient();

        public static Boolean upload(Bitmap bmp)
        {
            try
            {
                var data = new NameValueCollection();

                var image = Global_Func.bmp_to_base64(bmp, Global_Func.ext_to_imageformat(Settings.upload_format));
                data.Add("source", image);

                web_client.UploadValuesAsync(
                    new Uri("http://www.imgone.co/api/1/upload/?key=" + Settings.ImgONE_client_id + "&format=txt"),
                    "POST",
                    data
                );

                web_client.Headers.Remove("Authorization");
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static Boolean delete(String delete_hash)
        {
            try
            {
                var web_client = new WebClient();
                web_client.UploadString("http://www.imgone.co/delete.php?imghash=" + delete_hash, "");
                web_client.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
