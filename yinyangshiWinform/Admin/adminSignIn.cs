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
    public partial class adminSignIn : Form
    {
        adminBLL adBLL = new adminBLL();
        admin m_admin = new admin();

        public adminSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new signIn().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给userInfo类 username、password属性  
            m_admin.AdminName = adminnameTextBox.Text.Trim().ToString();
            m_admin.AdminPassWord = adminPasswdTextBox.Text.Trim().ToString();

            //如果BLL层中 adminLogin调用返回记录条数 大于1 则账号密码正确  
            if (adBLL.adminLogin(m_admin) > 0)
            {
                //           MessageBox.Show("登录成功");
                new userList().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
