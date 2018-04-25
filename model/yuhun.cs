using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class yuhun
    {
        private string yuhunId;
        private string yuhunName;
        private string yuhunType;
        private string yuhunTime;
        private string yuhunPlace;
        private string yuhunIntroduction;

        public yuhun()
        {
        }

        public yuhun(string yuhunId, string yuhunName, string yuhunType, string yuhunTime, string yuhunPlace, string yuhunIntroduction)
        {
            this.yuhunId = yuhunId;
            this.yuhunName = yuhunName;
            this.yuhunType = yuhunType;
            this.yuhunTime = yuhunTime;
            this.yuhunPlace = yuhunPlace;
            this.yuhunIntroduction = yuhunIntroduction;
        }

        public string YuhunId
        {
            get { return yuhunId; }
            set { yuhunId = value; }
        }

        public string YuhunName
        {
            get { return yuhunName; }
            set { yuhunName = value; }
        }

        public string YuhunType
        {
            get { return yuhunType; }
            set { yuhunType = value; }
        }

        public string YuhunTime
        {
            get { return yuhunTime; }
            set { yuhunTime = value; }
        }

        public string YuhunPlace
        {
            get { return yuhunPlace; }
            set { yuhunPlace = value; }
        }

        public string YuhunIntroduction
        {
            get { return yuhunIntroduction; }
            set { yuhunIntroduction = value; }
        }
    }
}
