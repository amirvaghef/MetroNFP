using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Common;
using System.ComponentModel;


namespace Network.DataAccess
{
    public class RailRoadDAL
    {
        private RailRoad FillEntity(IDataReader reader)
        {
            RailRoad railRoad = new RailRoad();
            railRoad.RailRoadID = int.Parse(reader.GetValue(reader.GetOrdinal("RailRoadID")).ToString());
            railRoad.Name = reader.GetValue(reader.GetOrdinal("Name")).ToString();
            railRoad.ShortName = reader.GetValue(reader.GetOrdinal("ShortName")).ToString();
            //railRoad.Stations = stations;

            return railRoad;
        }

        private Station FillEntityStation(IDataReader reader)
        {
            Station station = new Station();
            station.StationID = int.Parse(reader.GetValue(reader.GetOrdinal("StationID")).ToString());
            station.Name = reader.GetValue(reader.GetOrdinal("Name")).ToString();
            station.ShortName = reader.GetValue(reader.GetOrdinal("ShortName")).ToString();
            station.Sequence = int.Parse(reader.GetValue(reader.GetOrdinal("Sequence")).ToString());

            return station;
        }

        public List<global::Common.RailRoad> GetList()
        {
            List<RailRoad> list = new List<RailRoad>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (RailRoad rr in list)
                    {
                        SqlCommand commandStations = new SqlCommand("Network.NFPspRailRoadStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = rr.RailRoadID;
                        SqlDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> stations = new List<Station>();
                        while (readerStations.Read())
                            stations.Add(FillEntityStation(readerStations));
                        readerStations.Close();

                        rr.Stations = stations;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (RailRoad rr in list)
                    {
                        OleDbCommand commandStations = new OleDbCommand("Network.NFPspRailRoadStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = rr.RailRoadID;
                        OleDbDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> stations = new List<Station>();
                        while (readerStations.Read())
                            stations.Add(FillEntityStation(readerStations));
                        readerStations.Close();

                        rr.Stations = stations;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
        }

        public List<global::Common.RailRoad> GetByID(int stationID)
        {
            List<RailRoad> list = new List<RailRoad>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadGetByStationID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = stationID;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (RailRoad rr in list)
                    {
                        SqlCommand commandStations = new SqlCommand("Network.NFPspRailRoadStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = rr.RailRoadID;
                        SqlDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> stations = new List<Station>();
                        while (readerStations.Read())
                            stations.Add(FillEntityStation(readerStations));
                        readerStations.Close();

                        rr.Stations = stations;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadGetByStationID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = stationID;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (RailRoad rr in list)
                    {
                        OleDbCommand commandStations = new OleDbCommand("Network.NFPspRailRoadStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = rr.RailRoadID;
                        OleDbDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> stations = new List<Station>();
                        while (readerStations.Read())
                            stations.Add(FillEntityStation(readerStations));
                        readerStations.Close();

                        rr.Stations = stations;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
        }

        public int InsertRailRoad(global::Common.RailRoad railRoad)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 255).Value = railRoad.Name;
                    command.Parameters.Add("@ShortName", SqlDbType.NVarChar, 10).Value = railRoad.ShortName;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", OleDbType.VarChar, 255).Value = railRoad.Name;
                    command.Parameters.Add("@ShortName", OleDbType.VarChar, 10).Value = railRoad.ShortName;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }

        public int UpdateRailRoad(global::Common.RailRoad railRoad)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = railRoad.RailRoadID;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 255).Value = railRoad.Name;
                    command.Parameters.Add("@ShortName", SqlDbType.NVarChar, 10).Value = railRoad.ShortName;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = railRoad.RailRoadID;
                    command.Parameters.Add("@Name", OleDbType.VarChar, 255).Value = railRoad.Name;
                    command.Parameters.Add("@ShortName", OleDbType.VarChar, 10).Value = railRoad.ShortName;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }

        public int DeleteRailRoad(int railRoadID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = railRoadID;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = railRoadID;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }

        public int InsertStationRailRoad(List<global::Common.RailRoad> railRoads)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    foreach (RailRoad railRoad in railRoads)
                    {
                        foreach (Station station in railRoad.Stations)
                        {
                            SqlCommand command = new SqlCommand("Network.NFPspRailRoadStationInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = railRoad.RailRoadID;
                            command.Parameters.Add("@StationID", SqlDbType.Int).Value = station.StationID;
                            command.Parameters.Add("@Sequence", SqlDbType.Int).Value = station.Sequence;

                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    foreach (RailRoad railRoad in railRoads)
                    {
                        foreach (Station station in railRoad.Stations)
                        {
                            OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadStationInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = railRoad.RailRoadID;
                            command.Parameters.Add("@StationID", OleDbType.Integer).Value = station.StationID;
                            command.Parameters.Add("@Sequence", OleDbType.Integer).Value = station.Sequence;

                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }

        public int UpdateStationRailRoad(global::Common.RailRoad railRoad, int oldStationID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadStationUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@oldStationID", SqlDbType.Int).Value = oldStationID;
                    command.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = railRoad.RailRoadID;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = railRoad.Stations[0].StationID;
                    command.Parameters.Add("@Sequence", SqlDbType.Int).Value = railRoad.Stations[0].Sequence;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadStationUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@oldStationID", OleDbType.Integer).Value = oldStationID;
                    command.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = railRoad.RailRoadID;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = railRoad.Stations[0].StationID;
                    command.Parameters.Add("@Sequence", OleDbType.Integer).Value = railRoad.Stations[0].Sequence;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }

        /// <summary>
        /// if "railRoadID=0" delete "stationID" from all RailRoads
        /// </summary>
        /// <param name="railRoadID">
        /// 
        /// </param>
        /// <param name="stationID">
        /// 
        /// </param>
        public int DeleteStationRailRoad(int railRoadID, int stationID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspRailRoadStationDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@RailRoadID", SqlDbType.Int).Value = railRoadID;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = stationID;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspRailRoadStationDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@RailRoadID", OleDbType.Integer).Value = railRoadID;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = stationID;

                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return result;
            }
        }
    }
}
