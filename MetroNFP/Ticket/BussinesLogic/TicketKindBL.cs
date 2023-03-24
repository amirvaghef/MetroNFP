using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class TicketKindBL
    {
        public List<global::Common.TicketKind> GetList()
        {
            try
            {
                return new TicketKindDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
