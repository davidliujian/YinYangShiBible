using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class adminBLL
    {
        adminDAL adDAL = new adminDAL();

        public int adminLogin(admin m_admin)
        {
            return adDAL.adminLogin(m_admin.AdminName, m_admin.AdminPassWord);
        }
    }
}
