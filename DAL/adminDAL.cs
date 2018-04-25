using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class adminDAL
    {
        DBUtility db = new DBUtility();

        //管理员登录的方法  
        public int adminLogin(string name, string psw)
        {
            string strsql = "select * from Table_Admin where AdminName = '" + name + "' and AdminPassword = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
    }
}
