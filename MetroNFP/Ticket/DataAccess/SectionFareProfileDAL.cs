using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Ticket.DataAccess
{
    class SectionFareProfileDAL
    {
        private SectionFareProfile FillEntity(IDataReader reader)
        {
            SectionFareProfile sectionFareProfile = new SectionFareProfile();
            sectionFareProfile.SectionFareProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("SectionFareProfileID")).ToString());
            sectionFareProfile.SectionFareProfileName = reader.GetValue(reader.GetOrdinal("SectionFareProfileName")).ToString();

            return sectionFareProfile;
        }

        private SectionFare FillEntitySectionFare(IDataReader reader)
        {
            SectionFare sectionFare = new SectionFare();
            sectionFare.SectionNumber = int.Parse(reader.GetValue(reader.GetOrdinal("SectionNumber")).ToString());
            sectionFare.Fare1 = double.Parse(reader.GetValue(reader.GetOrdinal("Fare1")).ToString());
            sectionFare.Fare2 = double.Parse(reader.GetValue(reader.GetOrdinal("Fare2")).ToString());

            return sectionFare;
        }

        public List<global::Common.SectionFareProfile> GetList()
        {
            List<SectionFareProfile> list = new List<SectionFareProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (SectionFareProfile rr in list)
                    {
                        SqlCommand commandSectionFare = new SqlCommand("Ticket.NFPspSectionFareGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandSectionFare.CommandType = System.Data.CommandType.StoredProcedure;
                        commandSectionFare.Parameters.Add("@fk_SectionFareProfileID", SqlDbType.Int).Value = rr.SectionFareProfileID;
                        SqlDataReader readerSectionFare = commandSectionFare.ExecuteReader();

                        List<SectionFare> sectionFare = new List<SectionFare>();
                        while (readerSectionFare.Read())
                            sectionFare.Add(FillEntitySectionFare(readerSectionFare));
                        readerSectionFare.Close();

                        rr.SectionFares = sectionFare;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (SectionFareProfile rr in list)
                    {
                        OleDbCommand commandSectionFare = new OleDbCommand("Ticket.NFPspSectionFareGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandSectionFare.CommandType = System.Data.CommandType.StoredProcedure;
                        commandSectionFare.Parameters.Add("@fk_SectionFareProfileID", OleDbType.Integer).Value = rr.SectionFareProfileID;
                        OleDbDataReader readerSectionFare = commandSectionFare.ExecuteReader();

                        List<SectionFare> sectionFare = new List<SectionFare>();
                        while (readerSectionFare.Read())
                            sectionFare.Add(FillEntitySectionFare(readerSectionFare));
                        readerSectionFare.Close();

                        rr.SectionFares = sectionFare;
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

        public int InsertSectionFareProfile(global::Common.SectionFareProfile sectionFareProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareProfileInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SectionFareProfileName", SqlDbType.NVarChar, 50).Value = sectionFareProfile.SectionFareProfileName;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SectionFareProfileName", OleDbType.VarChar, 50).Value = sectionFareProfile.SectionFareProfileName;

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

        public int UpdateSectionFareProfile(global::Common.SectionFareProfile sectionFareProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareProfileUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SectionFareProfileID", SqlDbType.Int).Value = sectionFareProfile.SectionFareProfileID;
                    command.Parameters.Add("@SectionFareProfileName", SqlDbType.NVarChar, 50).Value = sectionFareProfile.SectionFareProfileName;

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
                    command.Parameters.Add("@SectionFareProfileID", OleDbType.Integer).Value = sectionFareProfile.SectionFareProfileID;
                    command.Parameters.Add("@SectionFareProfileName", OleDbType.VarChar, 50).Value = sectionFareProfile.SectionFareProfileName;

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

        public int DeleteSectionFareProfile(int sectionFareProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SectionFareProfileID", SqlDbType.Int).Value = sectionFareProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SectionFareProfileID", OleDbType.Integer).Value = sectionFareProfileID;

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

        public int InsertSectionFare(List<global::Common.SectionFareProfile> sectionFareProfiles)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    foreach (SectionFareProfile sectionFareProfile in sectionFareProfiles)
                    {
                        foreach (SectionFare sectionFare in sectionFareProfile.SectionFares)
                        {
                            SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_SectionFareProfileID", SqlDbType.Int).Value = sectionFareProfile.SectionFareProfileID;
                            command.Parameters.Add("@SectionNumber", SqlDbType.Int).Value = sectionFare.SectionNumber;
                            command.Parameters.Add("@Fare1", SqlDbType.Money).Value = sectionFare.Fare1;
                            command.Parameters.Add("@Fare2", SqlDbType.Money).Value = sectionFare.Fare2;

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
                    foreach (SectionFareProfile sectionFareProfile in sectionFareProfiles)
                    {
                        foreach (SectionFare sectionFare in sectionFareProfile.SectionFares)
                        {
                            OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_SectionFareProfileID", OleDbType.Integer).Value = sectionFareProfile.SectionFareProfileID;
                            command.Parameters.Add("@SectionNumber", OleDbType.Integer).Value = sectionFare.SectionNumber;
                            command.Parameters.Add("@Fare1", OleDbType.Currency).Value = sectionFare.Fare1;
                            command.Parameters.Add("@Fare2", OleDbType.Currency).Value = sectionFare.Fare2;

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

        public int UpdateSectionFare(global::Common.SectionFareProfile sectionFareProfile, int OldSectionNumber)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_SectionFareProfileID", SqlDbType.Int).Value = sectionFareProfile.SectionFareProfileID;
                    command.Parameters.Add("@SectionNumber", SqlDbType.Int).Value = sectionFareProfile.SectionFares[0].SectionNumber;
                    command.Parameters.Add("@OldSectionNumber", SqlDbType.Int).Value = OldSectionNumber;
                    command.Parameters.Add("@Fare1", SqlDbType.Money).Value = sectionFareProfile.SectionFares[0].Fare1;
                    command.Parameters.Add("@Fare2", SqlDbType.Money).Value = sectionFareProfile.SectionFares[0].Fare2;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_SectionFareProfileID", OleDbType.Integer).Value = sectionFareProfile.SectionFareProfileID;
                    command.Parameters.Add("@SectionNumber", OleDbType.Integer).Value = sectionFareProfile.SectionFares[0].SectionNumber;
                    command.Parameters.Add("@OldSectionNumber", OleDbType.Integer).Value = OldSectionNumber;
                    command.Parameters.Add("@Fare1", OleDbType.Currency).Value = sectionFareProfile.SectionFares[0].Fare1;
                    command.Parameters.Add("@Fare2", OleDbType.Currency).Value = sectionFareProfile.SectionFares[0].Fare2;

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

        public int DeleteSectionFare(int sectionFareProfileID, int sectionNumber)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSectionFareDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_SectionFareProfileID", SqlDbType.Int).Value = sectionFareProfileID;
                    command.Parameters.Add("@SectionNumber", SqlDbType.Int).Value = sectionNumber;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSectionFareDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_SectionFareProfileID", OleDbType.Integer).Value = sectionFareProfileID;
                    command.Parameters.Add("@SectionNumber", OleDbType.Integer).Value = sectionNumber;

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
