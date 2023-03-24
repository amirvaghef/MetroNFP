using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class ReaderMessageBL
    {
        public List<global::Common.ReaderMessage> GetReaderMessageList()
        {
            try
            {
                return new ReaderMessageDAL().GetReaderMessageList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.ReaderDynamicMessage> GetReaderDynamicMessageList()
        {
            try
            {
                return new ReaderMessageDAL().GetReaderDynamicMessageList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertReaderMessage(global::Common.ReaderMessage readerMessage)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ReaderMessageDAL().InsertReaderMessage(readerMessage);
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

        public int UpdateReaderMessage(global::Common.ReaderMessage readerMessage)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ReaderMessageDAL().UpdateReaderMessage(readerMessage);
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

        public int DeleteReaderMessage(int readerMessageID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ReaderMessageDAL().DeleteReaderMessage(readerMessageID);
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
