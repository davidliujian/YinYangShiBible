using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class userBLL
    {

        userDAL  d_userDAL = new userDAL();

        public int userLogin(user m_user)
        {
            return d_userDAL.userLogin(m_user.UserName, m_user.Password);
        }

        public int userRegister(user m_user)
        {
            return d_userDAL.userRegister(m_user.UserId, m_user.UserName, m_user.Password);
        }

        public List<user> getAlluser()
        {
            return d_userDAL.getAlluser();
        }

        public int userDel(string userId)
        {
            return d_userDAL.userDel(userId);
        }

        public int userEdit(user m_user)
        {
            return d_userDAL.userEdit(m_user.UserId, m_user.UserName, m_user.Password);
        }
    }
}
