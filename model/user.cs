using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class user
    {
        private string userId;
        private string  userName;
        private string  passWord;

        /// <summary>
        /// 无参构造方法，如果类没有声明构造方法，默认为无参构造方法
        /// </summary>
        public user()
        {

        }

        /// <summary>
        /// 当主动声明有参构造函数后，要手动加上无参构造方法
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        public user(string userId, string userName, string passWord)
        {
            this.userId = userId;
            this.userName = userName;
            this.passWord = passWord;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set {  userName = value;}
        }
        public string Password
        { get { return passWord; }
           set { passWord = value; }
        }
    }
}
