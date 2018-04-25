using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class feedbackBLL
    {
        feedbackDAL fbDAL = new feedbackDAL();

        public int  addFeedback(string userId,string str)
        {
            return fbDAL.feedbackInsert(userId, str);
        }

        public List<feedback> getAllFeedback()
        {
            return fbDAL.getAllFeedback();
        }
    }
}
