using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseEventQuiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat src = new Mat(new Size(500, 500), MatType.CV_8UC3, new Scalar(255, 255, 255));

            Cv2.ImShow("mouse", src);
            MouseCallback cvMouseCallback = new MouseCallback(Event);
            Cv2.SetMouseCallback("mouse", cvMouseCallback, src.CvPtr);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();

        }

        static void Event(MouseEventTypes eventTypes, int x, int y, MouseEventFlags flags, IntPtr userdata)
        {
            Mat data = new Mat(userdata);

            if (flags == MouseEventFlags.LButton)
            {
                Console.WriteLine("마우스 왼쪽 누르기");
            }
            else if (flags == MouseEventFlags.RButton)
            {
                Console.WriteLine("마우스 오른쪽 누르기");
            }
            if (eventTypes == MouseEventTypes.RButtonUp)
            {
                Console.WriteLine("마우스 오른쪽 때기");
            }
            else if(eventTypes == MouseEventTypes.LButtonDoubleClick)
            {
                Console.WriteLine("마우스 왼쪽 더블클릭");
            }
        }
    }
}
