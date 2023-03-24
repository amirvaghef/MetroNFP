using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class TransferProfileBL
    {
        public List<global::Common.TransferProfile> GetTransferProfileList()
        {
            try
            {
                return new TransferProfileDAL().GetTransferProfileList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertTransferProfile(global::Common.TransferProfile transferProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TransferProfileDAL().InsertTransferProfile(transferProfile);
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

        public int UpdateTransferProfile(global::Common.TransferProfile transferProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TransferProfileDAL().UpdateTransferProfile(transferProfile);
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

        public int DeleteTransferProfile(int transferProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TransferProfileDAL().DeleteTransferProfile(transferProfileID);
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
