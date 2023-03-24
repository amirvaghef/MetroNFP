using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PRDMessage
    {
        public PRDMessage()
        {
            prdMessageID = 0;
            prdMessageName = "";
            prdMeesageText = "";
            prdMessageRTL = true;
        }
        public PRDMessage(short id, string name, string text, bool rtl)
        {
            prdMessageID = id;
            prdMessageName = name;
            prdMeesageText = text;
            prdMessageRTL = rtl;
        }

        private short prdMessageID;
        public short PRDMessageID
        {
            get
            {
                return prdMessageID;
            }
            set
            {
                prdMessageID = value;
            }
        }

        private string prdMessageName;
        public string PRDMessageName
        {
            get
            {
                return prdMessageName;
            }
            set
            {
                prdMessageName = value;
            }
        }

        private string prdMeesageText;
        public string PRDMeesageText
        {
            get
            {
                return prdMeesageText;
            }
            set 
            {
                prdMeesageText = value;
            }
        }

        private bool prdMessageRTL;
        public bool PRDMessageRTL
        {
            get
            {
                return prdMessageRTL;
            }
            set
            {
                prdMessageRTL = value;
            }
        }
    }
}
