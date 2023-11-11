using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\img\\vtest.avi";
            VideoCapture capture = new VideoCapture(path);
            //VideoCapture capture = new VideoCapture(0); //카메라

            capture.Set(VideoCaptureProperties.FrameWidth, 320);
            capture.Set(VideoCaptureProperties.FrameHeight, 240);
            Mat frame = new Mat();

            while (true)
            {
                if (capture.PosFrames == capture.FrameCount)
                {
                    capture.Open(path);
                    
                }
                capture.Read(frame);
                Cv2.ImShow("VideoFrame", frame);

                if (Cv2.WaitKey(33) == 'q')
                {
                    break;
                }

                //if (capture.IsOpened() == true) //카메라
                //{
                //    capture.Read(frame);
                //    Cv2.ImShow("VideoFrame", frame);

                //    if (Cv2.WaitKey(33) == 'q')
                //    {
                //        break;
                //    }
                //}


            }
            capture.Release();
            Cv2.DestroyAllWindows();
        }
    }
}
