using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GetDpiDemo
{
    class Program
    {
        public static void Main()
        {
            var screenWidth = SystemParameters.PrimaryScreenWidth;
            var screenHeight = SystemParameters.PrimaryScreenHeight;
            Console.WriteLine($"screenWidth:{screenWidth}, screenHeight:{screenHeight}");

            var line = "";
            do
            {
                var dpiX = PrimaryScreen.DpiX;
                var dpiY = PrimaryScreen.DpiY;
                var scaleX = PrimaryScreen.ScaleX;
                var scaleY = PrimaryScreen.ScaleY;

                Console.WriteLine($"dpiX:{dpiX},dpiY:{dpiY},scaleX:{scaleX},scaleY:{scaleY}");
                line = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(line));

        }

        public Tuple<float, float> GetDpi()
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                var dpiX = graphics.DpiX;
                var dpiY = graphics.DpiY;
                return new Tuple<float, float>(dpiX, dpiY);
            }
        }

    }
}
