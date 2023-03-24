using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class ReaderDynamicMessage
    {
        public ReaderDynamicMessage()
        {
            readerDynamicMessageID = 0;
            readerDynamicMessageData = "";
            readerDynamicMessageName = "";
        }

        public ReaderDynamicMessage(short id, string name, string data)
        {
            readerDynamicMessageID = id;
            readerDynamicMessageName = name;
            readerDynamicMessageData = data;
        }

        private short readerDynamicMessageID;
        public short ReaderDynamicMessageID
        {
            get
            {
                return readerDynamicMessageID;
            }
            set
            {
                readerDynamicMessageID = value;
            }
        }

        private string readerDynamicMessageName;
        public string ReaderDynamicMessageName
        {
            get
            {
                return readerDynamicMessageName;
            }
            set
            {
                readerDynamicMessageName = value;
            }
        }

        private string readerDynamicMessageData;
        public string ReaderDynamicMessageData
        {
            get
            {
                return readerDynamicMessageData;
            }
            set
            {
                readerDynamicMessageData = value;
            }
        }
    }
}
