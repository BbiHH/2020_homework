using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            Font font = new Font(toolStripComboBox1.SelectedItem.ToString(), 20);
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = font;
            switch (toolStripComboBox2.Text)
            {
                case "黑色":
                    richTextBox1.ForeColor = Color.Black;
                    break;

                case "灰色":
                    richTextBox1.ForeColor = Color.Gray;
                    break;

                case "红色":
                    richTextBox1.ForeColor = Color.Red;
                    break;

                default:
                    break;
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            Font font = new Font(toolStripComboBox1.SelectedItem.ToString(), 20);
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = font;
            switch (toolStripComboBox2.Text)
            {
                case "黑色":
                    richTextBox1.ForeColor = Color.Black;
                    break;

                case "灰色":
                    richTextBox1.ForeColor = Color.Gray;
                    break;

                case "红色":
                    richTextBox1.ForeColor = Color.Red;
                    break;

                default:
                    break;
            }
        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "字数：  " + richTextBox1.Text.Length;
        }
    }
}