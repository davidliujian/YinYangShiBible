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
    public partial class remind : Form
    {
        Timer timer0, timer1, timer2, timer4, timer5, timer6, timer7;

        public remind()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------timer的tick事件--------------------------------------------------
        void timer0_tick(object sender, EventArgs e)
        {
            if ("12:00".Equals(DateTime.Now.ToString("t")))
            {
                timer0.Stop();//停止计时器
                MessageBox.Show("领取体力  午12:00");
            }
        }

        void timer1_tick(object sender, EventArgs e)
        {
            if ("20:00".Equals(DateTime.Now.ToString("t")))
            {
                timer1.Stop();//停止计时器
                MessageBox.Show("领取体力，斗技  晚20:00");
            }
        }

        void timer2_tick(object sender, EventArgs e)
        {
            if ("11:00".Equals(DateTime.Now.ToString("t")))
            {
                timer2.Stop();//停止计时器
                MessageBox.Show("斗技  午11:00");
            }
        }

        void timer4_tick(object sender, EventArgs e)
        {
            if ("17:00".Equals(DateTime.Now.ToString("t")))
            {
                timer4.Stop();//停止计时器
                MessageBox.Show("逢魔之时  17:00");
            }
        }

        void timer5_tick(object sender, EventArgs e)
        {
            if ("19:00".Equals(DateTime.Now.ToString("t")))
            {
                timer5.Stop();//停止计时器
                MessageBox.Show("狩猎战 19:00");
            }
        }

        void timer6_tick(object sender, EventArgs e)
        {
            if ("09:00".Equals(DateTime.Now.ToString("t")))
            {
                timer6.Stop();//停止计时器
                MessageBox.Show("悬赏封印 早 09:00");
            }
        }

        void timer7_tick(object sender, EventArgs e)
        {
            if ("18:00".Equals(DateTime.Now.ToString("t")))
            {
                timer7.Stop();//停止计时器
                MessageBox.Show("悬赏封印  晚 18:00");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 全选按钮选中 触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //遍历checkedListBox1所有项 ，全部设置为选中
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                //遍历checkedListBox1所有项 ，全部设置为未选中
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void remindBegin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))  //先判断是否被选中
                {
                    createTimer(i);
                }
            }
            MessageBox.Show("设置成功，请不要关闭本软件。");
        }

        /// <summary>
        /// 根据选择的提醒，创建Timer
        /// </summary>
        /// <param name="i"></param>
        private void createTimer(int i)
        {
            switch (i)
            {
                case 0:
                    timer0 = new Timer();  //定义定时器
                    timer0.Interval = 1000;//设置间隔检测时间
                    timer0.Tick += new EventHandler(timer0_tick);
                    timer0.Start();
                    break;
                case 1:
                case 3:
                    MessageBox.Show("进来了case 1| 3");
                    if(timer1 == null)
                    {
                        timer1 = new Timer();  //定义定时器
                        timer1.Interval = 1000;//设置间隔检测时间
                        timer1.Tick += new EventHandler(timer1_tick);
                        timer1.Start();
                    }
                    break;
                case 2:
                    timer2 = new Timer();  //定义定时器
                    timer2.Interval = 1000;//设置间隔检测时间
                    timer2.Tick += new EventHandler(timer2_tick);
                    timer2.Start();
                    break;
                case 4:
                    timer4 = new Timer();  //定义定时器
                    timer4.Interval = 1000;//设置间隔检测时间
                    timer4.Tick += new EventHandler(timer4_tick);
                    timer4.Start();
                    break;
                case 5:
                    timer5 = new Timer();  //定义定时器
                    timer5.Interval = 1000;//设置间隔检测时间
                    timer5.Tick += new EventHandler(timer5_tick);
                    timer5.Start();
                    break;
                case 6:
                    timer6 = new Timer();  //定义定时器
                    timer6.Interval = 1000;//设置间隔检测时间
                    timer6.Tick += new EventHandler(timer6_tick);
                    timer6.Start();
                    break;
                case 7:
                    timer7 = new Timer();  //定义定时器
                    timer7.Interval = 1000;//设置间隔检测时间
                    timer7.Tick += new EventHandler(timer7_tick);
                    timer7.Start();
                    break;
            }
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
            this.Refresh();
        }

        private void remind_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
        }

        private void remind_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

    }
}
