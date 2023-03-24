using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class TimeSlotProfileBL
    {
        public List<global::Common.TimeSlotProfile> GetList()
        {
            try
            {
                return new TimeSlotProfileDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertTimeSlotProfile(global::Common.TimeSlotProfile timeSlotProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TimeSlotProfileDAL().InsertTimeSlotProfile(timeSlotProfile);
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

        public int InsertTimeSlot(global::Common.TimeSlot timeSlot)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TimeSlotProfileDAL().InsertTimeSlot(timeSlot);
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

        public int UpdateTimeSlot(global::Common.TimeSlot timeSlot, short oldfk_WeekDayID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TimeSlotProfileDAL().UpdateTimeSlot(timeSlot, oldfk_WeekDayID);
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

        public int DeleteTimeSlotProfile(int timeSlotProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new TimeSlotProfileDAL().DeleteTimeSlotProfile(timeSlotProfileID);
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
