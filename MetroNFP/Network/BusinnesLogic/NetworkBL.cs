using System;
using System.Collections.Generic;
using Network.DataAccess;
using Common;

namespace Network.BusinnesLogic
{
    public class NetworkBL
    {
        public void Insert(global::Common.Station station, List<global::Common.RailRoad> railRoads)
        {
            Common.Utility.ConnectionManager.Instance.BeginTransaction();
            try
            {
                int stationID = new StationDAL().Insert(station);
                foreach (RailRoad railRoad in railRoads)
                    foreach (Station st in railRoad.Stations)
                        st.StationID = stationID;
                new RailRoadDAL().InsertStationRailRoad(railRoads);
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

        public void Update(global::Common.Station station, List<global::Common.RailRoad> railRoads)
        {
            Common.Utility.ConnectionManager.Instance.BeginTransaction();
            try
            {
                new StationDAL().Update(station);
                new RailRoadDAL().DeleteStationRailRoad(0, station.StationID);
                new RailRoadDAL().InsertStationRailRoad(railRoads);
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
