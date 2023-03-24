using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class TicketBL
    {
        public List<global::Common.Ticket> GetList()
        {
            try
            {
                return new TicketDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public global::Common.Ticket GetByID(short ticketID)
        {
            try
            {
                return new TicketDAL().GetByID(ticketID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertTicket(global::Common.Ticket ticket)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TicketDAL().InsertTicket(ticket);
            }
            catch (Exception ex)
            {
                Common.Utility.ConnectionManager.Instance.RollbackTransaction();
                throw ex;
            }
            finally
            {
                Common.Utility.ConnectionManager.Instance.CommitTransaction();
            }
        }

        public int UpdateTicket(global::Common.Ticket ticket)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TicketDAL().UpdateTicket(ticket);
            }
            catch (Exception ex)
            {
                Common.Utility.ConnectionManager.Instance.RollbackTransaction();
                throw ex;
            }
            finally
            {
                Common.Utility.ConnectionManager.Instance.CommitTransaction();
            }
        }

        public int DeleteTicket(short ticketID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TicketDAL().DeleteTicket(ticketID);
            }
            catch (Exception ex)
            {
                Common.Utility.ConnectionManager.Instance.RollbackTransaction();
                throw ex;
            }
            finally
            {
                Common.Utility.ConnectionManager.Instance.CommitTransaction();
            }
        }
    }
}
