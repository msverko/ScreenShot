using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;

namespace ScreenShot
{
    class Program
    {
        static DirectoryInfo di;
        static void Main(string[] args)
        {
            Magician.DisappearConsole();

            args = new string[] { "y" };

            if (args[0] == "y")
            {

                di = new DirectoryInfo("D:\\test");
                if (!di.Exists) { di.Create(); }

                PrintScreen ps = new PrintScreen();
                ps.CaptureScreenToFile(di + "\\screen.png", System.Drawing.Imaging.ImageFormat.Png);

            }


        }
    }
}
