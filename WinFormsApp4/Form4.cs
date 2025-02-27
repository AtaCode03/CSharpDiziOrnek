using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int[] dizi = new int[5];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dizi[sayac] = Convert.ToInt32(textBox1.Text);
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach(int x in dizi)
            {
                if(x % 2 == 0)
                {
                    toplam += x;
                }
            }
            label2.Text = toplam.ToString();
        }
    }
}
