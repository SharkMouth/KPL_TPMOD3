namespace KPL_TPMOD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = (string)textBox1.Text;
            label1.Text = "Halo " + input + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
