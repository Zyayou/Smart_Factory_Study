namespace LinqConsoleApp002
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile = {
                new Profile() { Name="정우성", Height=186},
                new Profile() { Name="김태희", Height=158},
                new Profile() { Name="고현정", Height=172},
                new Profile() { Name="이문세", Height=178},
                new Profile() { Name="하하", Height=171}
            };

            var profile = from p in arrProfile
                              //where p.Height >= 178
                          orderby p.Height descending//534p
                          select p;

            foreach ( var p in profile)
            {
                Console.WriteLine($"{p.Name} {p.Height}");
            }
        }
    }
}