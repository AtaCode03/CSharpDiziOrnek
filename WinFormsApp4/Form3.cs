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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int x in dizi)
            {
                if (x % 2 == 0)
                {
                    listBox1.Items.Add(x);
                }
            }
        }
    }
}
