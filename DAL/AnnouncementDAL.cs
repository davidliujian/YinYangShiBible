using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnnouncementDAL
    {
        //实例化DBbase 对象  
        DBUtility db = new DBUtility();

        public string getAnnouncement()
        {
            string sql = "select Announcement from Table_Announcement where isValid = 1";
            DataSet dataset =  db.query(sql);
            return dataset.Tables[0].Rows[0]["Announcement"].ToString();
        }

        //插入公告
        public int insertAnnouncement(string adminId,string ann)
        {
            //先更新所有公告为旧的
            this.updateAnnouncement();
            string sql = "insert into Table_Announcement values('"+adminId+"','"+ann+"','1')";
            return db.update(sql);
        }

        //更新公告，把当前有效的公告全部变为无效
        public int updateAnnouncement()
        {
            string sql = "update Table_Announcement set isValid=0 where isValid = 1";
            return db.update(sql);
        }
    }
}
