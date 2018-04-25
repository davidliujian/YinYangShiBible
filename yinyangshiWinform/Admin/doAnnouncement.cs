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

namespace yinyangshiWinform.Admin
{
    public partial class doAnnouncement : Form
    {
        AnnouncementBLL annBLL = new AnnouncementBLL();
        public doAnnouncement()
        {
            InitializeComponent();
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            string phone = this.phoneTextBox.Text.Trim().ToString();
            string announcement = richTextBox1.Text.Replace('\'', '-').Replace('\"', '-').Replace('\r', ' ').Replace('\n', ' ').ToString();

            if (annBLL.insertAnnouncement(phone, announcement) > 0)
            {
                MessageBox.Show("发布成功！");
            }
            else
            {
                MessageBox.Show("发布失败！");
            }
        }

        private void userListBtn_Click(object sender, EventArgs e)
        {
            new userList().Show();
            this.Hide();
        }

        private void announcementBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void feedbackListBtn_Click(object sender, EventArgs e)
        {
            new feedbackList().Show();
            this.Hide();
        }

        private void doAnnouncement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void doAnnouncement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
