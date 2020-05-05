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

namespace StudentManageDemo.UI
{
    public partial class UseFrom : Form
    {
        private string username;
        private string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;

        public UseFrom(string username)
        {
            InitializeComponent();
            this.username = username ;
            this.Text = "当前用户为：" + username;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From21 fm = new From21(username);
            fm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            if (tb11.Text=="")
            {
                //执行语句
                sqlstr = "select * from score";
                cmd.CommandText = sqlstr;
            }
            else
            {
                if(cb11.Text=="学号")  //通过学号来查询
                {
                    sqlstr = "select * from score where 学号=@id";
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("id", tb11.Text);
                }
                else
                {
                    sqlstr = "select * from score where 姓名 like @name";
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("name", tb11.Text+'%');
                }
            }

            //数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); // ds为数据库信息在内存的缓存
            sda.Fill(ds, "score");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "score";

            con.Close();
            con.Dispose();
        }

        private void UseFrom_Load(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            /*   加载第一个数据框   */
            //执行语句
            sqlstr = "select * from score";
            cmd.CommandText = sqlstr;

            //数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); // ds为数据库信息在内存的缓存
            sda.Fill(ds, "score");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "score";

            /*   加载第二个数据框   */

            sqlstr = "select * from course";
            cmd.CommandText = sqlstr;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "course");
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "course";
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "course";
            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "course";

            con.Close();
            con.Dispose();
        }

        void DataLoad()
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            sqlstr = "select * from course";
            cmd.CommandText = sqlstr;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "course";
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "course";
            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "course";

            con.Close();
            con.Dispose();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            if (tb21.Text == "")
            {
                //执行语句
                sqlstr = "select * from course";
                cmd.CommandText = sqlstr;
            }
            else
            {
                sqlstr = "select * from course where 课程名称 like @name OR 课程编号=@id";
                cmd.CommandText = sqlstr;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("name", '%' + tb21.Text + '%');
                cmd.Parameters.AddWithValue("id", tb21.Text);
            }

            //数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); // ds为数据库信息在内存的缓存

            sda.Fill(ds, "course");
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "course";

            con.Close();
            con.Dispose();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb21.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tb22.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            tb23.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "编辑")
            {
                button3.Text = "保存";
                tb22.ReadOnly = false;
                tb23.ReadOnly = false;
            }
            else
            {
                string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                //连接数据库
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();

                //创建命令对象
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string sqlstr;

                sqlstr = " update course set 课程名称=@kc,课程类型=@lx,学分=@xf where 课程编号=@id";
                cmd.CommandText = sqlstr;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("kc", tb21.Text);
                cmd.Parameters.AddWithValue("lx", tb22.Text);
                cmd.Parameters.AddWithValue("xf", tb23.Text);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功!");
                con.Close();

                DataLoad();
                button3.Text = "编辑";
                button3.Enabled = false;
                tb22.ReadOnly = true;
                tb23.ReadOnly = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb31.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            tb32.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            tb33.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            if (tb31.Text == "")
            {
                //执行语句
                sqlstr = "select * from course";
                cmd.CommandText = sqlstr;
            }
            else
            {
                sqlstr = "select * from course where 课程名称 like @name OR 课程编号=@id";
                cmd.CommandText = sqlstr;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("name", '%' + tb31.Text + '%');
                cmd.Parameters.AddWithValue("id", tb31.Text);
            }

            //数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); // ds为数据库信息在内存的缓存

            sda.Fill(ds, "course");
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "course";

            con.Close();
            con.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            sqlstr = "delete from course where 课程编号=@id";
            cmd.CommandText = sqlstr;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("删除成功!");
            con.Close();

            button5.Enabled = false;
            tb31.Text = "";
            tb32.Text = "";
            tb33.Text = "";
            DataLoad();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            if (tb41.Text == "")
            {
                //执行语句
                sqlstr = "select * from course";
                cmd.CommandText = sqlstr;
            }
            else
            {
                sqlstr = "select * from course where 课程名称 like @name OR 课程编号=@id";
                cmd.CommandText = sqlstr;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("name", '%' + tb41.Text + '%');
                cmd.Parameters.AddWithValue("id", tb41.Text);
            }

            //数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); // ds为数据库信息在内存的缓存

            sda.Fill(ds, "course");
            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "course";

            con.Close();
            con.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr;

            sqlstr = "insert into course (课程编号,课程名称,学分) values(@id,@name,@xf)";
            cmd.CommandText = sqlstr;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id",tb43.Text);
            cmd.Parameters.AddWithValue("name", tb41.Text);
            cmd.Parameters.AddWithValue("xf", tb42.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("添加成功!");
            con.Close();

            tb31.Text = "";
            tb32.Text = "";
            tb33.Text = "";
            DataLoad();
        }
    }
}