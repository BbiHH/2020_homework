using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear(); //清空表头
            listView1.Items.Clear(); //清空数据行
            listView1.View = View.Details; //显示风格
            listView1.GridLines = true; //显示网格线
            listView1.Dock = DockStyle.Fill;
            //创建表头
            listView1.Columns.Add("文件名", 400, HorizontalAlignment.Left);
            listView1.Columns.Add("文件属性", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("创建时间", 150, HorizontalAlignment.Left);
            //遍历某路径中的文件
            foreach (var filename in Directory.GetFiles("F:\\2020\\算法课\\"))
            {
                //去文件绝对路径
                FileInfo file = new FileInfo(filename);
                //创建数据行，一行数据就是一个ListViewItem对象
                ListViewItem item = new ListViewItem();
                item.Text = file.Name; //第一个字段：文件名
                item.SubItems.Add(file.Attributes.ToString()); //第二个字段：文件属性
                item.SubItems.Add(file.CreationTime.ToString()); //第三个字段：文件创建时期

                //将此行数据添加到listview对象上
                listView1.Items.Add(item);
            }
        }
    }
}