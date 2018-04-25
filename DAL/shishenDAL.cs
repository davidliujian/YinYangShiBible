using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class shishenDAL
    {
        //实例化DBbase 对象  
        DBUtility db = new DBUtility();
        
        public shishen getShishenByName(string shishenName)
        {
            string sql = "select * from Table_Shishen where  ShishenName = '"+ shishenName+"'";
            DataSet dataset = db.query(sql);
            DataRow datarow = dataset.Tables[0].Rows[0];
            shishen ss = new shishen();
            ss.ShishenId = datarow["ShishenId"].ToString();
            ss.ShishenName = datarow["ShishenName"].ToString(); 
            ss.ShishenType = datarow["ShishenType"].ToString();
            ss.ShishenPlace = datarow["ShishenPlace"].ToString();
            ss.ShishenIntroduction = datarow["ShishenIntroduction"].ToString();
            return ss;
        }
    }
}
