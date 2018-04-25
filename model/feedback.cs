using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class feedback
    {
        private string feedbackId;
        private string userId;
        private string feedbackIntroduction;

        /// <summary>
        /// 无参构造方法，如果类没有声明构造方法，默认为无参构造方法
        /// </summary>
        public feedback()
        {

        }

        public feedback(string feedbackId, string userId, string feedbackIntroduction)
        {
            this.feedbackId = feedbackId;
            this.userId = userId;
            this.feedbackIntroduction = feedbackIntroduction;
        }

        public string FeedbackId
        {
            get { return feedbackId; }
            set { feedbackId = value; }
        }
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string FeedbackIntroduction
        {
            get { return feedbackIntroduction; }
            set { feedbackIntroduction = value; }
        }
    }
}
