using System;
using System.Collections.Generic;
using Network.DataAccess;
using System.ComponentModel;
using Common;

namespace Network.BusinnesLogic {
	public class StationBL {
        
		public List<global::Common.Station> GetList() {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new StationDAL().GetList();
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

        public Station GetByID(int stationID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new StationDAL().GetByID(stationID);
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

		public int Insert(global::Common.Station station) 
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new StationDAL().Insert(station);
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

		public int Update(global::Common.Station station) {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new StationDAL().Update(station);
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

		public void Delete(int stationID) {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                new StationDAL().Delete(stationID);
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
