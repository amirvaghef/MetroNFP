using System;
using System.Collections.Generic;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class SectionFareProfileBL
    {
        public List<global::Common.SectionFareProfile> GetList()
        {
            try
            {
                return new SectionFareProfileDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSectionFareProfile(global::Common.SectionFareProfile sectionFareProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().InsertSectionFareProfile(sectionFareProfile);
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

        public int UpdateSectionFareProfile(global::Common.SectionFareProfile sectionFareProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().UpdateSectionFareProfile(sectionFareProfile);
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

        public int DeleteSectionFareProfile(int sectionFareProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().DeleteSectionFareProfile(sectionFareProfileID);
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

        public int InsertSectionFare(List<global::Common.SectionFareProfile> sectionFareProfiles)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().InsertSectionFare(sectionFareProfiles);
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

        public int UpdateSectionFare(global::Common.SectionFareProfile sectionFareProfile, int OldSectionNumber)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().UpdateSectionFare(sectionFareProfile, OldSectionNumber);
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

        public int DeleteSectionFare(int sectionFareProfileID, int sectionNumber)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionFareProfileDAL().DeleteSectionFare(sectionFareProfileID, sectionNumber);
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
