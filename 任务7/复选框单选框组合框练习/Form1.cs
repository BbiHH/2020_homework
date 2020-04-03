using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 复选框单选框组合框练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            var f = new Font("宋体", font.Size);
            this.richTextBox1.SelectionFont = f;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            var f = new Font("楷书", font.Size);
            this.richTextBox1.SelectionFont = f;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            var f = new Font("黑体", font.Size);
            this.richTextBox1.SelectionFont = f;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            var f = new Font("隶书", font.Size);
            this.richTextBox1.SelectionFont = f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            Font f;
            if (font.Bold)
            {
                f = new Font(font, font.Style & ~FontStyle.Bold);
            }
            else
            {
                f = new Font(font, font.Style | FontStyle.Bold);
            }
            this.richTextBox1.SelectionFont = f;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            Font f;
            if (font.Italic)
            {
                f = new Font(font, font.Style & ~FontStyle.Italic);
            }
            else
            {
                f = new Font(font, font.Style | FontStyle.Italic);
            }
            this.richTextBox1.SelectionFont = f;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            Font f;
            if (font.Underline)
            {
                f = new Font(font, font.Style & ~FontStyle.Underline);
            }
            else
            {
                f = new Font(font, font.Style | FontStyle.Underline);
            }
            this.richTextBox1.SelectionFont = f;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            Font f;
            if (font.Strikeout)
            {
                f = new Font(font, font.Style & ~FontStyle.Strikeout);
            }
            else
            {
                f = new Font(font, font.Style | FontStyle.Strikeout);
            }
            this.richTextBox1.SelectionFont = f;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var font = this.richTextBox1.SelectionFont;
            this.richTextBox1.SelectAll();
            int size = int.Parse(comboBox1.Text);
            var f = new Font(font.Name, size);
            this.richTextBox1.SelectionFont = f;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}