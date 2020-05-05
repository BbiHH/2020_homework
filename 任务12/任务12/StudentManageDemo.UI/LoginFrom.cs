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

namespace StudentManageDemo.UI
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr = "SELECT * FROM UserInfo WHERE UserName=@username";
            cmd.CommandText = sqlstr;
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                //读取一行数据
                if (password == dataReader["Password"].ToString())
                {
                    Form fm = new UseFrom(username);
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试。", "登录失败");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误！请重试。", "登录失败");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();
        }
    }
}