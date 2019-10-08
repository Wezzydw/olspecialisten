using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Ølspecialisten.Infrastructure.Data
{
    public static class ImgBin
    {

        public static byte[] ImageToBytes(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }


        public static string ImageToBase64(string filepath)
        {
            return Convert.ToBase64String(File.ReadAllBytes(filepath));
        }

    }


}
