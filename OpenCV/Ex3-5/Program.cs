using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Size size = new Size(640, 480);
            Mat img = new Mat(size, MatType.CV_8UC3);
            Mat img2 = new Mat(img.Size(), MatType.CV_8UC1);

            Console.WriteLine($"{size.Width}, {size.Height}");
            Console.WriteLine(img.Size());
            Console.WriteLine($"{img.Size().Width}, {img.Size().Height}");
            Console.WriteLine($"{img.Width},{img.Height}");

            //Range 범위 구조체
            Range range = new Range(0, 100);
            Console.WriteLine($"\n{range.Start}, {range.End}");

            //Rect (책 61p)
            Rect rect1 = new Rect(new Point(0,0), new Size(640, 480));
            Console.WriteLine(rect1);
            Rect rect2 = new Rect(100, 100, 640, 480);
            Console.WriteLine(rect2);

            //RotateRect
            RotatedRect rotatedRect = new RotatedRect(
                new Point2f(100f,100f), new Size2f(100, 100), 45f);
            Console.WriteLine(rotatedRect.BoundingRect());
            Console.WriteLine(rotatedRect.Points().Length);
            Console.WriteLine(rotatedRect.Points()[0]);
        }
    }
}
