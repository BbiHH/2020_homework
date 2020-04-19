using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 2, "http://www.baidu.com");
            linkLabel1.Links.Add(3, 2, "http://www.google.cn");
            linkLabel1.Links.Add(6, 5, "http://www.yahoo.com.cn");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            if (string.IsNullOrEmpty(e.Link.LinkData.ToString()))
                MessageBox.Show("无效链接地址！");
            else
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.Links[0].LinkData = "http://www.sina.com.cn";
            linkLabel2.Text = "新浪";
            linkLabel2.Links[linkLabel2.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}