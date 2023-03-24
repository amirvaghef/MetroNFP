using System;
using System.Collections.Generic;
using Network.DataAccess;

namespace Network.BusinnesLogic {
	public class RailRoadBL {
		public List<global::Common.RailRoad> GetList() {
            try
            {
                return new RailRoadDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        public List<global::Common.RailRoad> GetByID(int stationID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().GetByID(stationID);
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

		public int InsertRailRoad(global::Common.RailRoad railRoad) {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().InsertRailRoad(railRoad);
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

		public int UpdateRailRoad(global::Common.RailRoad railRoad) {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().UpdateRailRoad(railRoad);
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

		public int DeleteRailRoad(int railRoadID) {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().DeleteRailRoad(railRoadID);
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

        public int InsertStationRailRoad(List<global::Common.RailRoad> railRoad)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().InsertStationRailRoad(railRoad);
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

        public int UpdateStationRailRoad(global::Common.RailRoad railRoad, int oldStationID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().UpdateStationRailRoad(railRoad, oldStationID);
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

        public int DeleteStationRailRoad(int railRoadID, int stationID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new RailRoadDAL().DeleteStationRailRoad(railRoadID, stationID);
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
