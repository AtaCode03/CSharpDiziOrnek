using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
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
            int enbuyuk = dizi[0];
            for(int i = 1; i < 5; i++)
            {
                if(enbuyuk < dizi[i])
                {
                    enbuyuk = dizi[i];
                }
            }
            label2.Text = enbuyuk.ToString();
        }
    }
}
