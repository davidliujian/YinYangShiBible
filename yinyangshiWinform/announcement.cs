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
    public partial class announcement : Form
    {
        AnnouncementBLL atBLL = new AnnouncementBLL();
        public announcement()
        {
            InitializeComponent();
        }

        private void announcement_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = atBLL.getAnnouncement();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            new feedback().Show();
            this.Hide();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            new compute().Show();
            this.Hide();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            new query().Show();
            this.Hide();
        }

        private void remindBtn_Click(object sender, EventArgs e)
        {
            new remind().Show();
            this.Hide();
        }

        private void AnnounceBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void announcement_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
        }

        private void announcement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
