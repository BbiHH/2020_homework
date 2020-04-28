using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFromDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open(); SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr = "SELECT * FROM UserInfo WHERE UserName=@username";//先查询输入用户的信息
            cmd.CommandText = sqlstr;
            cmd.Parameters.AddWithValue("username", textBox1.Text);
            SqlDataReader DataRd = cmd.ExecuteReader();
            DataRd.Read();
            if (textBox2.Text == DataRd[2].ToString())//判读输入的旧密码是否正确
            {
                DataRd.Close();
                if (textBox3.Text == textBox4.Text)//判读 2 次输入的新密码是否一致
                {
                    //修改用户密码
                    sqlstr = "UPDATE UserInfo SET PassWord =@pswd WHERE UserName=@username";
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("pswd", textBox3.Text);
                    cmd.Parameters.AddWithValue("username", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改密码成功");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致");
                }
            }
            con.Close();
            Form form = new Form1();
            form.Show();
        }
    }
}