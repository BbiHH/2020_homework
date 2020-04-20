using BreakfastDecoratorDemo.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastDecoratorDemo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Breakfast breakfast = new Jiaozi();
            if (rbMF.Checked == true)
                breakfast = new Mifen();
            else if (rbHD.Checked == true)
                breakfast = new Hundun();

            if (cbEgg.Checked == true)
            {
                int n = int.Parse(tbEgg.Text);
                for (int i = 0; i < n; i++)
                {
                    breakfast = new Egg(breakfast);
                }
            }

            if (cbBeef.Checked == true)
            {
                int n = int.Parse(tbBeef.Text);
                for (int i = 0; i < n; i++)
                {
                    breakfast = new Beef(breakfast);
                }
            }

            if (cbXG.Checked == true)
            {
                int n = int.Parse(tbXG.Text);
                for (int i = 0; i < n; i++)
                {
                    breakfast = new Xianggan(breakfast);
                }
            }

            if (cbXCR.Checked == true)
            {
                int n = int.Parse(tbXCR.Text);
                for (int i = 0; i < n; i++)
                {
                    breakfast = new Xiaochaorou(breakfast);
                }
            }

            tbTotal.Text = breakfast.GetPrice().ToString();
        }
    }
}