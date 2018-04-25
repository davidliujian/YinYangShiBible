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

namespace yinyangshiWinform
{
    public partial class queryYuHun : Form
    {
        yuhunBLL yhBLL = new yuhunBLL();

        public queryYuHun()
        {
            InitializeComponent();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            new query().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yuhunName = yhTextBox.Text.Trim().ToString();
            //获得式神
            yuhun yh = yhBLL.queryYuhunByName(yuhunName);
            //设置页面 显示御魂名称
            yhname.Text = yh.YuhunName;
            //设置页面 显示御魂类型，并显示为红色
            yhleixing.Text = yh.YuhunType;
            yhleixing.ForeColor = Color.Red;
            //设置页面显示御魂简介
            richTextBox1.Text = yh.YuhunIntroduction;
            //设置页面显示御魂出现地点
            richTextBox2.Text = yh.YuhunPlace;
        }

        private void queryYuHun_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void queryYuHun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
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

        private void computeBtn_Click(object sender, EventArgs e)
        {
            new compute().Show();
            this.Hide();
        }
    }
}
