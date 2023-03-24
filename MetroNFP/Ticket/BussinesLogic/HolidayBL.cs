using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class HolidayBL
    {
        public List<global::Common.BankHoliday> GetBankHolidayList()
        {
            try
            {
                return new HolidayDAL().GetBankHolidayList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<global::Common.SchoolHoliday> GetSchoolHolidayList()
        {
            try
            {
                return new HolidayDAL().GetSchoolHolidayList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertBankHoliday(global::Common.BankHoliday bankHoliday)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().InsertBankHoliday(bankHoliday);
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
        public int InsertSchoolHoliday(global::Common.SchoolHoliday schoolHoliday)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().InsertSchoolHoliday(schoolHoliday);
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

        public int UpdateBankHoliday(global::Common.BankHoliday bankHoliday)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().UpdateBankHoliday(bankHoliday);
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
        public int UpdateSchoolHoliday(global::Common.SchoolHoliday schoolHoliday)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().UpdateSchoolHoliday(schoolHoliday);
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

        public int DeleteBankHoliday(short bankHolidayID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().DeleteBankHoliday(bankHolidayID);
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
        public int DeleteSchoolHoliday(short schoolHolidayID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new HolidayDAL().DeleteSchoolHoliday(schoolHolidayID);
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
