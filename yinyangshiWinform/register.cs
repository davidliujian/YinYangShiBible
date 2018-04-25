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
    public partial class register : Form
    {
        //实例化model层中 userInfo类用于传递数据  
        Model.user m_user = new Model.user();

        //实例化BLL层中 loginBLL类衔接用户输入与数据库匹配  
        BLL.userBLL b_userBLL = new BLL.userBLL();

        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //将用户输入的手机号，账号名称，密码 赋值给userInfo类userId, userName、password属性  。
            m_user.UserId = phoneTextBox.Text.Trim().ToString();
            m_user.UserName = usernameTextBox.Text.Trim().ToString();
            m_user.Password = passwdTextBox.Text.Trim().ToString();

            int x = b_userBLL.userRegister(m_user);
            System.Console.WriteLine(x);
            //如果BLL层中 useLogin调用返回记录条数 大于1 则插入成功  
            if ( x > 0)
            {
                //             MessageBox.Show("注册成功");
                new compute().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
