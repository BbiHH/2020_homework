using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片查看器
{
    public partial class Form1 : Form
    {
        private int indexNow = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = true;
            indexNow--;
            pictureBox1.Image = imageList1.Images[indexNow];
            label1.Text = (indexNow + 1) + "/" + "4";
            if (indexNow == 0)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = true;
            indexNow++;
            pictureBox1.Image = imageList1.Images[indexNow];
            label1.Text = (indexNow + 1) + "/" + imageList1.Images.Count;
            if (indexNow == 3)
            {
                button2.Enabled = false;
            }
        }
    }
}