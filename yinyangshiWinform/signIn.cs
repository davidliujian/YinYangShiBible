using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;


namespace yinyangshiWinform
{
    public partial class signIn : Form
    {
        //实例化model层中 userInfo类用于传递数据  
        Model.user  m_user = new Model.user();

        //实例化BLL层中 loginBLL类衔接用户输入与数据库匹配  
        BLL.userBLL b_userBLL = new BLL.userBLL();

        public signIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void goToSignUpButton_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给userInfo类 username、password属性  
            m_user.UserName = usernameTextBox.Text.Trim().ToString();
            m_user.Password = passwdTextBox.Text.Trim().ToString();

            //如果BLL层中 useLogin调用返回记录条数 大于1 则账号密码正确  
            if (b_userBLL.userLogin(m_user) > 0)
            {
                // MessageBox.Show("登录成功");
                new query().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin.adminSignIn().Show();
            this.Hide();
        }
    }
}
