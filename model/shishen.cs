using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class shishen
    {
        private string shishenId;
        private string shishenName;
        private string shishenType;
        private string shishenPlace;
        private string shishenIntroduction;

        public shishen()
        {

        }

        public shishen(string shishenId, string shishenName, string shishenType, string shishenPlace, string shishenIntroduction)
        {
            this.shishenId = shishenId;
            this.shishenName = shishenName;
            this.shishenType = shishenType;
            this.shishenPlace = shishenPlace;
            this.shishenIntroduction = shishenIntroduction;
        }

        public string ShishenId
        {
            get { return shishenId; }
            set { shishenId = value; }
        }

        public string ShishenName
        {
            get { return shishenName; }
            set { shishenName = value; }
        }

        public string ShishenType
        {
            get { return shishenType; }
            set { shishenType = value; }
        }

        public string ShishenPlace
        {
            get { return shishenPlace; }
            set { shishenPlace = value; }
        }

        public string ShishenIntroduction
        {
            get { return shishenIntroduction; }
            set { shishenIntroduction = value; }
        }
    }
}
