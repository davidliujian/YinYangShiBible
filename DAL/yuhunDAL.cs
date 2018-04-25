using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class yuhunDAL
    {
        //实例化DBbase 对象  
        DBUtility db = new DBUtility();

        public yuhun getYuhunByName(string yuhunName)
        {
            string sql = "select * from Table_Yuhun where  YuhunName = '" + yuhunName + "'";
            DataSet dataset = db.query(sql);
            DataRow datarow = dataset.Tables[0].Rows[0];
            yuhun yh = new yuhun();
            yh.YuhunId = datarow["YuhunId"].ToString();
            yh.YuhunName = datarow["YuhunName"].ToString();
            yh.YuhunType = datarow["YuhunType"].ToString();
            yh.YuhunTime = datarow["YuhunTime"].ToString();
            yh.YuhunPlace = datarow["YuhunPlace"].ToString();
            yh.YuhunIntroduction = datarow["YuhunIntroduction"].ToString();
            return yh;
        }
    }
}
