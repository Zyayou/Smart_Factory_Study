namespace RandomColorApp01
{
    public partial class Form1 : Form
    {
        private Random rand;
        
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            this.MouseClick += RandomColorFunction;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

        }
        //����� ���� �޼ҵ�
        private void RandomColorFunction(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
            
        }
    }
}