namespace Calculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows",
                farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
