using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Common;
using System.ComponentModel;

namespace Network.DataAccess {
	public class StationDAL {

        private Station FillEntity(IDataReader reader)
        {
            Station station = new Station();
            station.StationID = int.Parse(reader.GetValue(reader.GetOrdinal("StationID")).ToString());
            station.Name = reader.GetValue(reader.GetOrdinal("Name")).ToString();
            station.ShortName = reader.GetValue(reader.GetOrdinal("ShortName")).ToString();

            return station;
        }

		public List<global::Common.Station> GetList() {
            List<Station> list = new List<Station>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationGetList", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                        list.Add(FillEntity(reader));

                    reader.Close();
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

        public Station GetByID(int stationID)
        {
            Station station = new Station();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationGetByID", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = stationID;
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    station = FillEntity(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
                return station;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = stationID;
                    OleDbDataReader reader = command.ExecuteReader();

                    reader.Read();
                    station = FillEntity(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return station;
            }
        }
                    
		public int Insert(global::Common.Station station) {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 255).Value = station.Name;
                    command.Parameters.Add("@ShortName", SqlDbType.NVarChar, 10).Value = station.ShortName;
                    SqlParameter param = command.Parameters.Add("@StationID", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    result = int.Parse(param.Value.ToString());
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
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", OleDbType.VarChar, 255).Value = station.Name;
                    command.Parameters.Add("@ShortName", OleDbType.VarChar, 10).Value = station.ShortName;
                    OleDbParameter param = command.Parameters.Add("@StationID", OleDbType.Integer);
                    param.Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    result = int.Parse(param.Value.ToString());
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

		public int Update(global::Common.Station station) {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 255).Value = station.Name;
                    command.Parameters.Add("@ShortName", SqlDbType.NVarChar, 10).Value = station.ShortName;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = station.StationID;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@Name", OleDbType.VarChar, 255).Value = station.Name;
                    command.Parameters.Add("@ShortName", OleDbType.VarChar, 10).Value = station.ShortName;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = station.StationID;

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

		public void Delete(int stationID) {
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", SqlDbType.Int).Value = stationID;

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(sqlConnection);
                }
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@StationID", OleDbType.Integer).Value = stationID;

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
            }
		}
	}
}