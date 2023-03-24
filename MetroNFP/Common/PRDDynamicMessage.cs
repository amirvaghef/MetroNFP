using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PRDDynamicMessage
    {
        public PRDDynamicMessage()
        {
            prdDynamicMessageID = 0;
            prdDynamicMessageData = "";
            prdDynamicMessageName = "";
        }

        public PRDDynamicMessage(short id, string name, string data)
        {
            prdDynamicMessageID = id;
            prdDynamicMessageName = name;
            prdDynamicMessageData = data;
        }

        private short prdDynamicMessageID;
        public short PRDDynamicMessageID
        {
            get
            {
                return prdDynamicMessageID;
            }
            set
            {
                prdDynamicMessageID = value;
            }
        }

        private string prdDynamicMessageName;
        public string PRDDynamicMessageName
        {
            get
            {
                return prdDynamicMessageName;
            }
            set
            {
                prdDynamicMessageName = value;
            }
        }

        private string prdDynamicMessageData;
        public string PRDDynamicMessageData
        {
            get
            {
                return prdDynamicMessageData;
            }
            set
            {
                prdDynamicMessageData = value;
            }
        }
    }
}
