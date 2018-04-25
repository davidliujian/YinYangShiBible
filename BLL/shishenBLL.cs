using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class shishenBLL
    {
        shishenDAL ssDAL = new shishenDAL();

        public shishen queryShishenByName(string shishenName)
        {
            return ssDAL.getShishenByName(shishenName);
        }
    }
}
