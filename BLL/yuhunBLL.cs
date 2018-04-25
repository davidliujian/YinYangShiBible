using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class yuhunBLL
    {
        yuhunDAL yhDAL = new yuhunDAL();

        public yuhun queryYuhunByName(string yuhunName)
        {
            return yhDAL.getYuhunByName(yuhunName);
        }
    }
}
