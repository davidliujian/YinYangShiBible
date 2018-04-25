using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class userDAL
    {
        //实例化DBUtility 对象  
        DBUtility db = new DBUtility();

        //用户登录的方法  
        public int  userLogin(string name, string psw)
        {
            string strsql = "select * from Table_User where UserName = '" + name + "' and UserPassword = '" + psw + "'";
            return db.returnRowCount(strsql);
        }

        //用户注册的方法
        public int userRegister(string userId,string userName,string passwd)
        {
            string strsql = "insert into Table_User   values ( '"+ userId+ "'  , '"+userName + "'  , '"+ passwd+"' )";
            return db.update(strsql);
        }

        //获取所有用户
        public List<user> getAlluser()
        {
            List<user> list = new List<user>();
            string sql = "select * from Table_User";
            DataSet dataset = db.query(sql);

            DataTable datatable = dataset.Tables[0];
            foreach(DataRow dr in datatable.Rows)
            {
                user m_user = new user();
                m_user.UserId = dr[0].ToString();
                m_user.UserName = dr[1].ToString();
                m_user.Password = dr[2].ToString();
                list.Add(m_user);
            }

            return list;
        }

        //删除用户通过userId
        public int userDel(string userId)
        {
            string sql = "delete from Table_User where UserId = '"+userId+"'";
            return db.update(sql);
        }

        //修改用户信息
        public int userEdit(string userId, string userName, string passwd)
        {
            string strsql = "update Table_User set UserName='"+userName+ "' , UserPassword='"+passwd+ "' where UserId='"+userId+"'";
            return db.update(strsql);
        }
    }
}
