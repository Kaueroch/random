using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x, c;
            labox.Items.Clear();
            for (c = 1; c <= 10; c++)
            {
                x = rnd.Next(500) +  1;
                labox.Items.Add(x);
                if (x % 3 == 0)
                    listBox1.Items.Add(x);
                else
                    listBox2.Items.Add(x);

            }
        }
    }
}
