using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mettest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat m1 = new Mat(3,3,MatType.CV_16UC1);
            Console.WriteLine(m1.Dump());
            Console.WriteLine();

            for(int i = 0;i< m1.Rows; i++)
            {
                for(int j = 0; j<m1.Cols; j++)
                {
                    m1.At<int> (i, j) = 100;
                }
            }
            Console.WriteLine(m1.Dump() );
            Console.WriteLine();

            //for (int i = 0; i < m1.Rows; i++)
            //{
            //    for (int j = 0; j < m1.Cols; j++)
            //    {
            //        Console.Write( m1.At<int>(i, j) +" ");
            //    }
            //    Console.WriteLine();
            //}


            //72p
            IList<int> sizes = new List<int>() { 480,640 };
            Mat m = new Mat(sizes, MatType.CV_8SC3);
        }
    }
}
