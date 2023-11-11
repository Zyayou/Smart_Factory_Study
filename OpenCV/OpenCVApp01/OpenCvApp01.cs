using OpenCvSharp;

namespace OpenCVApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var src = new Mat("lenna.jpg", ImreadModes.Color);
            var dst = new Mat();

            Cv2.Canny(src, dst, 50, 200);
            new Window("src image", src); // opencv 윈도우 라이브러리 창 만들기
            new Window("dst image", dst); // 원본을 가지고 가공한 목저파일

            Cv2.WaitKey();
        }
    }
}