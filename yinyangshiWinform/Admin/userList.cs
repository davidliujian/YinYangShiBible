using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace yinyangshiWinform.Admin
{
    public partial class userList : Form
    {
        userBLL b_userBLL = new userBLL();
        private BindingList<user> Buser;
        private int rowIndex;   //用于点击修改时，保存点击的行编号

        public userList()
        {
            InitializeComponent();

            Buser = new BindingList<user>( b_userBLL.getAlluser());
            //设置数据源
            this.dataGridView1.DataSource = Buser;
            //添加编辑列
            DataGridViewLinkColumn dvc = new DataGridViewLinkColumn();
            dvc.Name = "edit";
            dvc.HeaderText = "编辑";
            dvc.Text = "编辑";
            dvc.UseColumnTextForLinkValue = true;
            this.dataGridView1.Columns.Add(dvc);
            //添加删除列
            DataGridViewLinkColumn dvc1 = new DataGridViewLinkColumn();
            dvc1.Name = "del";
            dvc1.HeaderText = "删除";
            dvc1.Text = "删除";
            dvc1.UseColumnTextForLinkValue = true;
            this.dataGridView1.Columns.Add(dvc1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;

            //如果点击在删除的那一列
            if(CIndex == 1)
            {
                //获取在同一行第一列的单元格中的字段值  
                string  userId = dataGridView1[2, e.RowIndex].Value.ToString();
                string userName = dataGridView1[3, e.RowIndex].Value.ToString();
                if (b_userBLL.userDel(userId) > 0)
                {
                    Buser.RemoveAt(e.RowIndex);
                    MessageBox.Show("删除成功       --       "+userId+"     --     "+userName);
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }else if (CIndex == 0)//如果点击在编辑的那一列
            {
                rowIndex = e.RowIndex;
                //获取在同一行第一列的单元格中的字段值  
                string userId = dataGridView1[2, e.RowIndex].Value.ToString();
                string userName = dataGridView1[3, e.RowIndex].Value.ToString();
                string userPassword = dataGridView1[4, e.RowIndex].Value.ToString();

                //设置隐藏的groupBox的三个值
                this.phoneTextBox.Text = userId;
                this.usernameTextBox.Text = userName;
                this.passwdTextBox.Text = userPassword;
                this.groupBox1.Visible = true;  //设置为可见
                this.groupBox1.BringToFront();//设置为显示在最上层

            }

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //获取groupbox里面的要修改的用户信息
            string userId = this.phoneTextBox.Text.Trim().ToString();
            string userName = this.usernameTextBox.Text.Trim().ToString();
            string userPassword = this.passwdTextBox.Text.Trim().ToString();

            user m_user = new user();
            m_user.UserId = userId;
            m_user.UserName = userName;
            m_user.Password = userPassword;

            if(b_userBLL.userEdit(m_user) > 0)
            {
                this.groupBox1.Visible = false;  //设置为不可见
                this.groupBox1.SendToBack();//设置为显示在最底层
                MessageBox.Show("修改成功       --       " + userId + "     --     " + userName);
                //设置绑定的数据List
                //删除当前行
                this.Buser.RemoveAt(rowIndex);
                //添加修改后的行
                this.Buser.Insert(rowIndex, m_user);
            }
            else {
                MessageBox.Show("修改失败");
            }
        }

        private void announcementBtn_Click(object sender, EventArgs e)
        {
            new doAnnouncement().Show();
            this.Hide();
        }

        private void userListBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void feedbackListBtn_Click(object sender, EventArgs e)
        {
            new feedbackList().Show();
            this.Hide();
        }

        private void userList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void userList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
