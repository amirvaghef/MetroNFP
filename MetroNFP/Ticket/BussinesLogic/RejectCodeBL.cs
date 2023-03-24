using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class RejectCodeBL
    {
        public List<global::Common.RejectCode> GetRejectCodeList()
        {
            try
            {
                return new RejectCodeDAL().GetRejectCodeList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertRejectCode(global::Common.RejectCode rejectCode)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RejectCodeDAL().InsertRejectCode(rejectCode);
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

        public int UpdateRejectCode(global::Common.RejectCode rejectCode)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RejectCodeDAL().UpdateRejectCode(rejectCode);
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

        public int DeleteRejectCode(int rejectCodeID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RejectCodeDAL().DeleteRejectCode(rejectCodeID);
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