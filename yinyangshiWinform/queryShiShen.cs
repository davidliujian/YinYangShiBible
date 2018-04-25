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

namespace yinyangshiWinform
{
    public partial class queryShiShen : Form
    {
        shishenBLL ssBLL = new shishenBLL();

        public queryShiShen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shishenName = ssTextBox.Text.Trim().ToString();
            //获得式神
            shishen ss = ssBLL.queryShishenByName(shishenName);
            //设置页面 显示式神名称
            ssname.Text = ss.ShishenName;
            //设置页面 显示式神类型，并显示为红色
            ssleixing.Text = ss.ShishenType;
            ssleixing.ForeColor = Color.Red;
            //设置页面显示式神简介
            richTextBox1.Text = ss.ShishenIntroduction;
            //设置页面显示式神出现地点
            richTextBox2.Text = ss.ShishenPlace;
        }

        /// <summary>
        /// 在退出程序 前 弹出确认退出程序的对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryShiShen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 窗体的FormClosed事件代码 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryShiShen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            new feedback().Show();
            this.Hide();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            new query().Show();
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
