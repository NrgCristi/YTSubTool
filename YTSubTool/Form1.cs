using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTSubTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("500 Subscribers Added");
            System.Diagnostics.Process.Start("textBox1.Text");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1000 Subscribers Added");
            System.Diagnostics.Process.Start("textBox1.Text");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10000 Subscribers Added");
            System.Diagnostics.Process.Start("textBox1.Text");
        }
    }
}
