using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            GetMenu(treeView1, menuStrip1);//将menuStrip1控件中的信息添加到treeView1控件中
            treeView1.ExpandAll();
        }

        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                newNode1.Tag = int.Parse(MenuS.Items[i].Tag.ToString());

                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                GetCavernMenu(newNode1, newmenu);//添加多层命令项
            }
        }

        public void GetCavernMenu(TreeNode newNodeA, ToolStripDropDownItem newmenuA)
        {
            if (newmenuA.HasDropDownItems && newmenuA.DropDownItems.Count > 0)
            {
                for (int j = 0; j < newmenuA.DropDownItems.Count; j++) //遍历二级菜单项
                {
                    //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
                    TreeNode newNodeB = newNodeA.Nodes.Add(newmenuA.DropDownItems[j].Text);
                    newNodeB.Tag = int.Parse(newmenuA.DropDownItems[j].Tag.ToString());
                    //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                    ToolStripDropDownItem newmenuB = (ToolStripDropDownItem)newmenuA.DropDownItems[j];
                    if (newmenuB.HasDropDownItems && newmenuA.DropDownItems.Count > 0)//如果当前命令项有子项
                    {
                        GetCavernMenu(newNodeB, newmenuB);//调用递归方法
                    }
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frm_show(Convert.ToInt16(e.Node.Tag.ToString()), e.Node.Text);
        }

        private void ToolStrip_MenuItem_Click(object sender, EventArgs e)
        {
            frm_show(Convert.ToInt16(((ToolStripMenuItem)sender).Tag.ToString()), ((ToolStripMenuItem)sender).Text);
        }

        #region 打开MenuStrip控件或TreeView控件相应的窗体

        /// <summary>
        /// 打开MenuStrip控件或TreeView控件相应的窗体
        /// </summary>
        /// <param n="int">标识</param>
        /// <param FName="string">名称</param>
        public void frm_show(int n, string FName)
        {
            switch (n)//通过标识调用各子窗体
            {
                case 0: break;
                case 1:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 2:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 3:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 4:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 5:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 6:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 7:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 8:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 9:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
                case 10:
                    {
                        Form2 fp = new Form2();//实例化一个窗体
                        fp.Text = FName;//设置窗体的名称
                        fp.ShowDialog();//用模试对话框打开窗体
                        fp.Dispose();//释放窗体的所有资原
                        break;
                    }
            }
        }

        #endregion 打开MenuStrip控件或TreeView控件相应的窗体
    }
}