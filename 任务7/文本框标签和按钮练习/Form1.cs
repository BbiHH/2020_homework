using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文本框标签和按钮练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnRed.Enabled = false;
            btnBlack.Enabled = true;
            textBox1.ForeColor = Color.Red;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnRed.Enabled = true;
            btnBlack.Enabled = false;
            textBox1.ForeColor = Color.Black;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            label.Text = textBox1.Text;
        }
    }
}