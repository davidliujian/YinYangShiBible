using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace yinyangshiWinform.Admin
{
    public partial class feedbackList : Form
    {
        feedbackBLL fbBLL = new feedbackBLL();
        Model.feedback m_feedback = new Model.feedback();

        private BindingList<Model.feedback> Bfeedback;

        public feedbackList()
        {
            InitializeComponent();

            Bfeedback = new BindingList<Model.feedback>(fbBLL.getAllFeedback());
            //设置数据源
            this.dataGridView1.DataSource = Bfeedback;
            //添加编辑列
            DataGridViewLinkColumn dvc = new DataGridViewLinkColumn();
            dvc.Name = "detail";
            dvc.HeaderText = "查看详情";
            dvc.Text = "查看详情";
            dvc.UseColumnTextForLinkValue = true;
            this.dataGridView1.Columns.Add(dvc);
        }

        private void userListBtn_Click(object sender, EventArgs e)
        {
            new userList().Show();
            this.Hide();
        }

        private void announcementBtn_Click(object sender, EventArgs e)
        {
            new doAnnouncement().Show();
            this.Hide();
        }

        private void feedbackListBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;

            //如果点击在删除的那一列
            if (CIndex == 0)
            {
                //获取在同一行第一列的单元格中的字段值  
                string userId = dataGridView1[2, e.RowIndex].Value.ToString();
                string feedbackIntro = dataGridView1[3, e.RowIndex].Value.ToString();

                this.textBox1.Text = userId;
                this.richTextBox1.Text = feedbackIntro;

                this.groupBox1.Visible = true;//显示出来
                this.groupBox1.BringToFront();//放在最顶层
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;//隐藏
            this.groupBox1.SendToBack();//放在最下层
        }

        private void feedbackList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void feedbackList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
