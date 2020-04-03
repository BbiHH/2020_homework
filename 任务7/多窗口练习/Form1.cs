using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗口练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var User = tbUserName.Text;
            var Password = tbPassword.Text;
            if (Password == "1234")
            {
                MessageBox.Show(User + "欢迎你!", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCencle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}