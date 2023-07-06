namespace multi_tasking_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountChar()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Temp\\Anusha.txt"))
            {
                count = reader.ReadToEnd().Length;
                Thread.Sleep(5000);

            }
            return count;
        }
        

        private  async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task1 = new Task<int>(CountChar);
            task1.Start();
            label1.Text = "started counting";
            int c = await task1;

            //label1.Text = "hi";
            //int c = CountChar();
            label1.Text = "Count " + c.ToString();  
        }
    }
}