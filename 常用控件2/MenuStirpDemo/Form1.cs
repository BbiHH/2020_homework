using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStirpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) +
           Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void 减ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) -
           Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void 乘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) *
           Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void 除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) /
           Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDouble(textBox4.Text) +
           Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDouble(textBox4.Text) -
           Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDouble(textBox4.Text) *
           Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDouble(textBox4.Text) /
           Convert.ToDouble(textBox5.Text)).ToString();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            MessageBox.Show(dlg.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            toolStrip1.Items[1].Text = DateTime.Now.ToString();
            statusStrip1.Items[0].Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStrip1.Items[1].Text = DateTime.Now.ToString();
            statusStrip1.Items[0].Text = DateTime.Now.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStrip1.Items[2].Text = e.Location.ToString();
            statusStrip1.Items[1].Text = e.Location.ToString();
        }
    }
}