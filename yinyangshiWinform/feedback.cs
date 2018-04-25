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

namespace yinyangshiWinform
{
    public partial class feedback : Form
    {
        feedbackBLL fbBLL = new feedbackBLL();

        public feedback()
        {
            InitializeComponent();
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            string phone = phoneTextBox.Text.Trim().ToString();
            string feedback = richTextBox1.Text.Replace('\'','-').Replace('\"','-').Replace('\r',' ').Replace('\n',' ').ToString();
            MessageBox.Show(feedback+"");
            fbBLL.addFeedback(phone, feedback);
            MessageBox.Show("提交成功！！！");
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            new query().Show();
            this.Hide();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            new compute().Show();
            this.Hide();
        }

        private void AnnounceBtn_Click(object sender, EventArgs e)
        {
            new announcement().Show();
            this.Hide();
        }

        private void feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void remindBtn_Click(object sender, EventArgs e)
        {
            new remind().Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
