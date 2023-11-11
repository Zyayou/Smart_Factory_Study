namespace LinqConsoleApp003
{
    class Class
    {
        public string Name { get; set; }
        public int[] score { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                    new Class() { Name = "연두반", score = new int[] { 99, 80, 70, 24 } },
                    new Class() { Name = "분홍반", score = new int[] { 60, 45, 87, 72 } },
                    new Class() { Name = "파랑반", score = new int[] { 92, 30, 85, 94 } },
                    new Class() { Name = "노랑반", score = new int[] { 90, 88, 0, 17 } }

                };

            var classes = from c in arrClass
                          from s in c.score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach (var c in classes)
            {
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            }
        }
    }
}