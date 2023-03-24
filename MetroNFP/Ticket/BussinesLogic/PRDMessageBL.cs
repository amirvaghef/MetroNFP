using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class PRDMessageBL
    {
        public List<global::Common.PRDMessage> GetPRDMessageList()
        {
            try
            {
                return new PRDMessageDAL().GetPRDMessageList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.PRDDynamicMessage> GetPRDDynamicMessageList()
        {
            try
            {
                return new PRDMessageDAL().GetPRDDynamicMessageList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertPRDMessage(global::Common.PRDMessage prdMessage)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PRDMessageDAL().InsertPRDMessage(prdMessage);
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

        public int UpdatePRDMessage(global::Common.PRDMessage prdMessage)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PRDMessageDAL().UpdatePRDMessage(prdMessage);
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

        public int DeletePRDMessage(int prdMessageID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PRDMessageDAL().DeletePRDMessage(prdMessageID);
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
