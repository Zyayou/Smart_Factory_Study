using System.Globalization;

namespace LinqConsoleApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //533p
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result =from n in numbers
                        where n % 2 == 0
                        orderby n
                        select n;

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}