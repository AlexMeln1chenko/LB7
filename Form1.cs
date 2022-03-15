using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Z = new int[35];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for(int i = 0; i < 35; i++)
            {
                Z[i] = rnd.Next(-40, 40);
                listBox1.Items.Add("Z[" + Convert.ToString(i+1) + "] = " + Z[i].ToString());
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int S = 0, P = 1;
            foreach (int x in Z)
            {
                if (x % 2 == 0 && x < 3)
                    S += x;
                if (x % 2 != 0 && x > 1)
                    P *= x;
            }
            listBox2.Items.Add("R= " + Convert.ToString(P + S));
            button2.Enabled = false;
        }
    }
}
