using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class ReaderMessage
    {
        public ReaderMessage()
        {
            readerMessageID = 0;
            readerMessageName = "";
            readerMeesageText = "";
            readerMessageRTL = true;
        }
        public ReaderMessage(short id, string name, string text, bool rtl)
        {
            readerMessageID = id;
            readerMessageName = name;
            readerMeesageText = text;
            readerMessageRTL = rtl;
        }

        private short readerMessageID;
        public short ReaderMessageID
        {
            get
            {
                return readerMessageID;
            }
            set
            {
                readerMessageID = value;
            }
        }

        private string readerMessageName;
        public string ReaderMessageName
        {
            get
            {
                return readerMessageName;
            }
            set
            {
                readerMessageName = value;
            }
        }

        private string readerMeesageText;
        public string ReaderMeesageText
        {
            get
            {
                return readerMeesageText;
            }
            set 
            {
                readerMeesageText = value;
            }
        }

        private bool readerMessageRTL;
        public bool ReaderMessageRTL
        {
            get
            {
                return readerMessageRTL;
            }
            set
            {
                readerMessageRTL = value;
            }
        }
    }
}
