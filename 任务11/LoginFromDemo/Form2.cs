using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginFromDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取连接字符串
            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            //创建连接对象
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;//设置命令对象的 connection 属性
            cmd.CommandText = "INSERT INTO UserInfo(Id,UserName,PassWord,Email,Tel) VALUES(@id,@username, @ps, @em,@tel)";   //在数据库中插入数据，设置四个参数
            cmd.Parameters.AddWithValue("id", new Random().Next(100, 200));
            cmd.Parameters.AddWithValue("username", textBox1.Text);   //为参数赋值
            cmd.Parameters.AddWithValue("ps", textBox2.Text);
            cmd.Parameters.AddWithValue("em", textBox3.Text);
            cmd.Parameters.AddWithValue("tel", textBox4.Text);
            cmd.ExecuteNonQuery();   //执行 SQL 命令，返回受影响的行数
            con.Close();
            MessageBox.Show("注册成功");
            this.Close();
        }
    }
}