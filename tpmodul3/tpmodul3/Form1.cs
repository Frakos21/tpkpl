namespace tpmodul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            label1.Text = "hallo"+a;
        }
    }
}