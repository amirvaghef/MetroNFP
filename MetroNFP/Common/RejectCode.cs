using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class RejectCode
    {
        public RejectCode()
        {
            rejectCodeID = 0;
            rejectCodeName = "";
            activityRecord = false;
            ticketRecord = false;
            fk_fineID = 0;
            fk_prdMessageID = 0;
        }
        public RejectCode(short id, string name, bool activity, bool ticket, short fineID, short prdMEssageID)
        {
            rejectCodeID = id;
            rejectCodeName = name;
            activityRecord = activity;
            ticketRecord = ticket;
            fk_fineID = fineID;
            fk_prdMessageID = prdMEssageID;
        }

        private short rejectCodeID;
        public short RejectCodeID
        {
            get
            {
                return rejectCodeID;
            }
            set
            {
                rejectCodeID = value;
            }
        }

        private string rejectCodeName;
        public string RejectCodeName
        {
            get
            {
                return rejectCodeName;
            }
            set
            {
                rejectCodeName = value;
            }
        }

        private bool activityRecord;
        public bool ActivityRecord
        {
            get
            {
                return activityRecord;
            }
            set
            {
                activityRecord = value;
            }
        }

        private bool ticketRecord;
        public bool TicketRecord
        {
            get
            {
                return ticketRecord;
            }
            set
            {
                ticketRecord = value;
            }
        }

        private short fk_fineID;
        public short fk_FineID
        {
            get
            {
                return fk_fineID;
            }
            set
            {
                fk_fineID = value;
            }
        }

        private short fk_prdMessageID;
        public short fk_PRDMessageID
        {
            get
            {
                return fk_prdMessageID;
            }
            set
            {
                fk_prdMessageID = value;
            }
        }
    }
}
