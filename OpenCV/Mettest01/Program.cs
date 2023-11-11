using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mettest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mat");
            Mat mat = new Mat();
            mat.Create(MatType.CV_8UC3, new int[] {6,6});
            mat.SetTo(new Scalar(255, 0, 0));
            Console.WriteLine(mat.Dump());

            Console.WriteLine();

            Console.WriteLine("mat2");
            Mat mat2 = new Mat();
            mat2.Create(MatType.CV_8UC3, new int[] { 3, 3 });
            mat2.SetTo(new Scalar(100));
            Console.WriteLine(mat2.Dump());
        
            Console.WriteLine();

            //MatExpr 정적메서드 74p
            Console.WriteLine("mat3");
            Mat mat3 = Mat.Ones(9,9,MatType.CV_8UC1);
            Console.WriteLine(mat3.Dump());

            Console.WriteLine();

            Console.WriteLine("mat4");
            Mat mat4 = Mat.Eye( 9,9,MatType.CV_8UC1);
            Console.WriteLine(mat4.Dump());
            
            Console.WriteLine();

            Console.WriteLine("mat5");
            Mat mat5 = Mat.Zeros(9, 9, MatType.CV_8UC1);
            Console.WriteLine(mat5.Dump());

            Console.WriteLine();

            // 요소 하나 출력
            Console.WriteLine("mat5의 (0,0) : " + mat5.At<int>(0,0));
        }
    }
}
