using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class PrintingProfileBL
    {
        public List<global::Common.PrintingProfile> GetList()
        {
            try
            {
                return new PrintingProfileDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.PrintingDynamicVariable> GetVariableList()
        {
            try
            {
                return new PrintingProfileDAL().GetVariableList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.PrintingProfile> GetValidationList()
        {
            try
            {
                return new PrintingProfileDAL().GetValidationList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.PrintingProfile> GetIssueList()
        {
            try
            {
                return new PrintingProfileDAL().GetIssueList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(global::Common.PrintingProfile printingProfile, bool profileOnly)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PrintingProfileDAL().Insert(printingProfile, profileOnly);
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

        public int Update(global::Common.PrintingProfile printingProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PrintingProfileDAL().Update(printingProfile);
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

        public int Delete(short printingProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new PrintingProfileDAL().Delete(printingProfileID);
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