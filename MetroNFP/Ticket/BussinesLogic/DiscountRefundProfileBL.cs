using System;
using System.Collections.Generic;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class DiscountRefundProfileBL
    {
        public List<global::Common.DiscountRefundProfile> GetList()
        {
            try
            {
                return new DiscountRefundProfileDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<global::Common.DiscountRefundProfile> GetDiscountList()
        {
            try
            {
                return new DiscountRefundProfileDAL().GetDiscountList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<global::Common.DiscountRefundProfile> GetRefundList()
        {
            try
            {
                return new DiscountRefundProfileDAL().GetRefundList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertDiscountRefundProfile(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().InsertDiscountRefundProfile(discountRefundProfile);
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

        public int UpdateDiscountRefundProfile(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().UpdateDiscountRefundProfile(discountRefundProfile);
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

        public int DeleteDiscountRefundProfile(int discountRefundProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().DeleteDiscountRefundProfile(discountRefundProfileID);
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

        public int InsertDiscountRefund(List<global::Common.DiscountRefundProfile> discountRefundProfiles)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().InsertDiscountRefund(discountRefundProfiles);
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

        public int UpdateDiscountRefund(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().UpdateDiscountRefund(discountRefundProfile);
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

        public int DeleteDiscountRefund(int discountRefundID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new DiscountRefundProfileDAL().DeleteDiscountRefund(discountRefundID);
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
