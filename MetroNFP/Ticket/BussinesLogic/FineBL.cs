using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class FineBL
    {
        public List<global::Common.Fine> GetFineList()
        {
            try
            {
                return new FineDAL().GetFineList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertFine(global::Common.Fine fine)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new FineDAL().InsertFine(fine);
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

        public int UpdateFine(global::Common.Fine fine)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new FineDAL().UpdateFine(fine);
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

        public int DeleteFine(int fineID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new FineDAL().DeleteFine(fineID);
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
