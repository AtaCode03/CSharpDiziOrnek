namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehir = new string[5];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sehir[sayac] = textBox1.Text;
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(sehir[i]);
            }
        }
    }
}
