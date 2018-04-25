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
    public partial class compute : Form
    {
        public compute()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            comboBox1.SelectedIndex = 0;//设置下拉框的第一项为默认选择项。
        }

        /// <summary>
        /// 计算伤害
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computeBegin_Click(object sender, EventArgs e)
        {
            int  baseDamage  = int.Parse(textBox1.Text.Trim().ToString());
            int  valueAdd = int.Parse(textBox2.Text.Trim().ToString());
            int enemyDefence = int.Parse(textBox3.Text.Trim().ToString());
            int criticalDamage = int.Parse(textBox4.Text.Trim().ToString());
            string yuhunEffect = comboBox1.SelectedItem.ToString();
            double power = 1.5;
            if ("暴击".Equals(yuhunEffect))
            {
                power = 1.8;
            }
            double result = (baseDamage + valueAdd - enemyDefence) * criticalDamage/100 * power;
            MessageBox.Show("伤害计算为：  "+result);
        }
        //----------------------------------------------------------------------------------------------------------------------
        /// <summary>  
        /// 文本框焦点获得事件  ，如果选中当前文本框，将文本框中默认的文本清除
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "面板黑字")
            {
                this.textBox1.Text = "";
                this.textBox1.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// 文本框焦点离开 ，如果文本框内容为空，显示回原先的字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                this.textBox1.Text = "面板黑字";
                this.textBox1.ForeColor = Color.Silver;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim() == "红字(>=0)")
            {
                this.textBox2.Text = "";
                this.textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0)
            {
                this.textBox2.Text = "红字(>=0)";
                this.textBox2.ForeColor = Color.Silver;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Trim() == ">=0")
            {
                this.textBox3.Text = "";
                this.textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Length == 0)
            {
                this.textBox3.Text = ">=0";
                this.textBox3.ForeColor = Color.Silver;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Trim() == ">=100(%略)")
            {
                this.textBox4.Text = "";
                this.textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Length == 0)
            {
                this.textBox4.Text = ">=100(%略)";
                this.textBox4.ForeColor = Color.Silver;
            }
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
            this.Refresh();
        }

        private void compute_FormClosing(object sender, FormClosingEventArgs e)
        {
 
                if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
        }

        private void compute_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
