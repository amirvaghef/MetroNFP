using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class Fine
    {
        public Fine()
        {
            fineID = 0;
            fineName = "";
            fineCost1 = 0;
            fineCost2 = 0;
        }
        public Fine(short id, string name, decimal cost1, decimal cost2)
        {
            fineID = id;
            fineName = name;
            fineCost1 = cost1;
            fineCost2 = cost2;
        }

        private short fineID;
        public short FineID
        {
            get
            {
                return fineID;
            }
            set
            {
                fineID = value;
            }
        }

        private string fineName;
        public string FineName
        {
            get
            {
                return fineName;
            }
            set
            {
                fineName = value;
            }
        }

        private decimal fineCost1;
        public decimal FineCost1
        {
            get
            {
                return fineCost1;
            }
            set
            {
                fineCost1 = value;
            }
        }

        private decimal fineCost2;
        public decimal FineCost2
        {
            get
            {
                return fineCost2;
            }
            set
            {
                fineCost2 = value;
            }
        }
    }
}
