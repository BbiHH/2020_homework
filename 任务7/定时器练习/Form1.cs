using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 定时器练习
{
    public partial class Form1 : Form
    {
        private int deltX = 10;
        private int deltY = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += deltX;
            this.label1.Top += deltY;
            if (this.label1.Top < 0 || this.label1.Top + this.label1.Height > this.Height)
            {
                deltY = -deltY;
            }
            if (this.label1.Left < 0 || this.label1.Left + this.label1.Width > this.Width)
            {
                deltX = -deltX;
            }
        }
    }
}