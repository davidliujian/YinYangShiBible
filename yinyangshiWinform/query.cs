using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yinyangshiWinform
{
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }

        private void shishenQuery_Click(object sender, EventArgs e)
        {
            new queryShiShen().Show();
            this.Hide();
        }

        private void yuhunQuery_Click(object sender, EventArgs e)
        {
            new queryYuHun().Show();
            this.Hide();
        }

        private void query_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
        }

        private void query_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            new compute().Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            new feedback().Show();
            this.Hide();
        }

        private void AnnounceBtn_Click(object sender, EventArgs e)
        {
            new announcement().Show();
            this.Hide();
        }

        private void remindBtn_Click(object sender, EventArgs e)
        {
            new remind().Show();
            this.Hide();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
