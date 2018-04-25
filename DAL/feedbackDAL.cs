using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class feedbackDAL
    {
        //实例化DBbase 对象  
        DBUtility db = new DBUtility();

        public int feedbackInsert(string userId,string feedbackIntroduction)
        {
            string sql = "insert into Table_Feedback (UserId,FeedbackIntroduction) values ('"+userId+"' , '"+ feedbackIntroduction + "')";
            return db.update(sql);
        }

        //获得所有的feedback
        public List<feedback> getAllFeedback()
        {
            List<feedback> list = new List<feedback>();
            string sql = "select * from Table_Feedback";
            DataSet dataset = db.query(sql);

            DataTable datatable = dataset.Tables[0];
            foreach (DataRow dr in datatable.Rows)
            {
                feedback m_feedback = new feedback();
                m_feedback.FeedbackId = dr[0].ToString();
                m_feedback.UserId = dr[1].ToString();
                m_feedback.FeedbackIntroduction = dr[2].ToString();
                list.Add(m_feedback);
            }

            return list;
        }
    }
}
