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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建连接对象，并打开
            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstr); con.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr = "SELECT * FROM UserInfo WHERE UserName=@username";

            cmd.CommandText = sqlstr;
            cmd.Parameters.AddWithValue("username", textBox1.Text);
            SqlDataReader DataRd = cmd.ExecuteReader();
            //读取一行数据
            DataRd.Read();
            if (textBox2.Text == DataRd[2].ToString())//取这一行数据第三个字段
            {
                Form fm = new Form1();
                fm.Show();
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }
    }
}