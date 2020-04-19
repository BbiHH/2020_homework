using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "今天是：" + monthCalendar1.TodayDate.ToString();
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = "起始日期：" + monthCalendar1.SelectionStart.ToString();
            //学习monthCalendar属性SelectionStart，表示获取起始日期
            label3.Text = "结束日期：" + monthCalendar1.SelectionEnd.ToString();
            //学习monthCalendar属性SelectionEnd，表示获取结束日期
            label4.Text = "加3月日期：" +
           monthCalendar1.SelectionStart.AddMonths(3).ToString();
            //学习monthCalendar方法AddMonths，表示增加起始日期的月份
            label5.Text = "加3天日期：" +
           monthCalendar1.SelectionStart.AddDays(3).ToString();
            //学习monthCalendar方法AddDays，表示增加起始日期的天数
            label6.Text = "加3年日期：" +
           monthCalendar1.SelectionStart.AddYears(3).ToString();
            //学习monthCalendar方法AddYears，表示增加起始日期的年份
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                int i = comboBox1.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Red;
                        break;

                    case 1:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
                        break;

                    case 2:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Blue;
                        break;

                    case 3:
                        monthCalendar1.TitleForeColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                int i = comboBox2.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Red;
                        break;

                    case 1:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Yellow;
                        break;

                    case 2:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
                        break;

                    case 3:
                        monthCalendar1.TitleBackColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 0)
            {
                int i = comboBox3.SelectedIndex;
                switch (i)
                {
                    case 0:
                        monthCalendar1.TrailingForeColor = Color.Red;
                        break;

                    case 1:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Yellow;
                        break;

                    case 2:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Blue;
                        break;

                    case 3:
                        monthCalendar1.TrailingForeColor = System.Drawing.Color.Green;
                        break;
                }
            }
        }
    }
}