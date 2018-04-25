using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AnnouncementBLL
    {
        AnnouncementDAL atDAL = new AnnouncementDAL();

        public string getAnnouncement()
        {
            return atDAL.getAnnouncement();
        }

        public int insertAnnouncement(string adminId,string ann)
        {
            return atDAL.insertAnnouncement(adminId,ann);
        }
    }
}
