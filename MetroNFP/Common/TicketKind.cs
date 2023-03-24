using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class TicketKind
    {
        private short ticketKindID;
        public short TicketKindID
        {
            get
            {
                return ticketKindID;
            }
            set
            {
                ticketKindID = value;
            }
        }

        private string ticketKindName;
        public string TicketKindName
        {
            get
            {
                return ticketKindName;
            }
            set
            {
                ticketKindName = value;
            }
        }
    }
}
