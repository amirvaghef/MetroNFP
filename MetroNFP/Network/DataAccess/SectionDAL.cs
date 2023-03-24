using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using Common;
using System.ComponentModel;

namespace Network.DataAccess
{
    public class SectionDAL
    {

        private Section FillOriginEntity(IDataReader reader)
        {
            Section section = new Section();
            section.StationID = int.Parse(reader.GetValue(reader.GetOrdinal("StationID")).ToString());
            section.Name = reader.GetValue(reader.GetOrdinal("Name")).ToString();
            section.ShortName = reader.GetValue(reader.GetOrdinal("ShortName")).ToString();

            return section;
        }
        private Station FillDestinationEntity(IDataReader reader)
        {
            Station station = new Station();
            station.StationID = int.Parse(reader.GetValue(reader.GetOrdinal("DestinationStationID")).ToString());
            station.Name = reader.GetValue(reader.GetOrdinal("DestinationName")).ToString();
            station.ShortName = reader.GetValue(reader.GetOrdinal("DestinationShortName")).ToString();
            station.SectionNumber = String.IsNullOrEmpty(reader.GetValue(reader.GetOrdinal("SectionNumber")).ToString()) ? 0 : int.Parse(reader.GetValue(reader.GetOrdinal("SectionNumber")).ToString());

            return station;
        }

        public List<global::Common.Section> GetList()
        {
            List<Section> list = new List<Section>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillOriginEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        SqlCommand commandStations = new SqlCommand("Network.NFPspSectionGetByOriginStation", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@OriginStationID", SqlDbType.Int).Value = list[i].StationID;
                        SqlDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> destinations = new List<Station>();
                        while (readerStations.Read())
                        {
                            bool temp = true;
                            for (int j = 0; j < i; j++)
                                if (int.Parse(readerStations.GetValue(readerStations.GetOrdinal("DestinationStationID")).ToString()) == list[j].StationID)
                                {
                                    temp = false;
                                    break;
                                }
                            if (temp)
                                destinations.Add(FillDestinationEntity(readerStations));
                        }
                        readerStations.Close();

                        list[i].Destinations = destinations;
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
                    OleDbCommand command = new OleDbCommand("Network.NFPspStationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillOriginEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        OleDbCommand commandStations = new OleDbCommand("Network.NFPspSectionGetByOriginStation", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStations.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStations.Parameters.Add("@OriginStationID", OleDbType.Integer).Value = list[i].StationID;
                        OleDbDataReader readerStations = commandStations.ExecuteReader();

                        List<Station> destinations = new List<Station>();
                        while (readerStations.Read())
                        {
                            bool temp = true;
                            for (int j = 0; j < i; j++)
                                if (int.Parse(readerStations.GetValue(readerStations.GetOrdinal("DestinationStationID")).ToString()) == list[j].StationID)
                                {
                                    temp = false;
                                    break;
                                }
                            if (temp)
                                destinations.Add(FillDestinationEntity(readerStations));
                        }
                        readerStations.Close();

                        list[i].Destinations = destinations;
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
        public int Update(global::Common.Section section)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Network.NFPspSectionManipulate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@fk_OriginStationID", SqlDbType.Int).Value = section.StationID;
                    command.Parameters.Add("@fk_DestinationStationID", SqlDbType.Int).Value = section.Destinations[0].StationID;
                    command.Parameters.Add("@SectionNumber", SqlDbType.Int).Value = section.Destinations[0].SectionNumber;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspSectionManipulate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@fk_OriginStationID", OleDbType.Integer).Value = section.StationID;
                    command.Parameters.Add("@fk_DestinationStationID", OleDbType.Integer).Value = section.Destinations[0].StationID;
                    command.Parameters.Add("@SectionNumber", OleDbType.Integer).Value = section.Destinations[0].SectionNumber;

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
