using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class admin
    {
        private string adminId;
        private string adminName;
        private string adminPassWord;

        /// <summary>
        /// 无参构造方法，如果类没有声明构造方法，默认为无参构造方法
        /// </summary>
        public admin()
        {

        }

        public admin(string adminId, string adminName, string adminPassWord)
        {
            this.adminId = adminId;
            this.adminName = adminName;
            this.adminPassWord = adminPassWord;
        }

        public string AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        public string AdminPassWord
        {
            get { return adminPassWord; }
            set { adminPassWord = value; }
        }
    }
}
