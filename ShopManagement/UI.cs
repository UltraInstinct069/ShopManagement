using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ShopManagement
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 f1 = new Form1();
            
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sell s = new Sell();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Information i = new Information();
            i.Show();
        }
    }
}
