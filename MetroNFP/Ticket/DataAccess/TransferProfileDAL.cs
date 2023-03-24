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
    class TransferProfileDAL
    {
        private TransferProfile FillEntityTransferProfile(IDataReader reader)
        {
            TransferProfile transferProfile = new TransferProfile();
            transferProfile.TransferProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("TransferProfileID")).ToString());
            transferProfile.TransferProfileName = reader.GetValue(reader.GetOrdinal("TransferProfileName")).ToString();
            transferProfile.MaxNumberOfTravelInDay = short.Parse(reader.GetValue(reader.GetOrdinal("MaxNumberOfTravelInDay")).ToString());
            transferProfile.TravelMaxDuration = short.Parse(reader.GetValue(reader.GetOrdinal("TravelMaxDuration")).ToString());
            transferProfile.MultiUsersNumber = short.Parse(reader.GetValue(reader.GetOrdinal("MultiUsersNumber")).ToString());
            transferProfile.AntiPassBack = short.Parse(reader.GetValue(reader.GetOrdinal("AntiPassBack")).ToString());

            return transferProfile;
        }

        public List<global::Common.TransferProfile> GetTransferProfileList()
        {
            List<TransferProfile> list = new List<TransferProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspTransferProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityTransferProfile(reader));
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
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTransferProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityTransferProfile(reader));
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

        public int InsertTransferProfile(global::Common.TransferProfile transferProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTransferProfileInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileName", SqlDbType.NVarChar, 50).Value = transferProfile.TransferProfileName;
                    command.Parameters.Add("@MaxNumberOfTravelInDay", SqlDbType.SmallInt).Value = transferProfile.MaxNumberOfTravelInDay;
                    command.Parameters.Add("@TravelMaxDuration", SqlDbType.SmallInt).Value = transferProfile.TravelMaxDuration;
                    command.Parameters.Add("@MultiUsersNumber", SqlDbType.SmallInt).Value = transferProfile.MultiUsersNumber;
                    command.Parameters.Add("@AntiPassBack", SqlDbType.SmallInt).Value = transferProfile.AntiPassBack;
                    
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTransferProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileName", OleDbType.VarChar, 50).Value = transferProfile.TransferProfileName;
                    command.Parameters.Add("@MaxNumberOfTravelInDay", OleDbType.SmallInt).Value = transferProfile.MaxNumberOfTravelInDay;
                    command.Parameters.Add("@TravelMaxDuration", OleDbType.SmallInt).Value = transferProfile.TravelMaxDuration;
                    command.Parameters.Add("@MultiUsersNumber", OleDbType.SmallInt).Value = transferProfile.MultiUsersNumber;
                    command.Parameters.Add("@AntiPassBack", OleDbType.SmallInt).Value = transferProfile.AntiPassBack;

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

        public int UpdateTransferProfile(global::Common.TransferProfile transferProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTransferProfileUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileID", SqlDbType.SmallInt).Value = transferProfile.TransferProfileID;
                    command.Parameters.Add("@TransferProfileName", SqlDbType.NVarChar, 50).Value = transferProfile.TransferProfileName;
                    command.Parameters.Add("@MaxNumberOfTravelInDay", SqlDbType.SmallInt).Value = transferProfile.MaxNumberOfTravelInDay;
                    command.Parameters.Add("@TravelMaxDuration", SqlDbType.SmallInt).Value = transferProfile.TravelMaxDuration;
                    command.Parameters.Add("@MultiUsersNumber", SqlDbType.SmallInt).Value = transferProfile.MultiUsersNumber;
                    command.Parameters.Add("@AntiPassBack", SqlDbType.SmallInt).Value = transferProfile.AntiPassBack;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspTransferProfileUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileID", OleDbType.SmallInt).Value = transferProfile.TransferProfileID;
                    command.Parameters.Add("@TransferProfileName", OleDbType.VarChar, 50).Value = transferProfile.TransferProfileName;
                    command.Parameters.Add("@MaxNumberOfTravelInDay", OleDbType.SmallInt).Value = transferProfile.MaxNumberOfTravelInDay;
                    command.Parameters.Add("@TravelMaxDuration", OleDbType.SmallInt).Value = transferProfile.TravelMaxDuration;
                    command.Parameters.Add("@MultiUsersNumber", OleDbType.SmallInt).Value = transferProfile.MultiUsersNumber;
                    command.Parameters.Add("@AntiPassBack", OleDbType.SmallInt).Value = transferProfile.AntiPassBack;

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

        public int DeleteTransferProfile(int transferProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTransferProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileID", SqlDbType.SmallInt).Value = transferProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTransferProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TransferProfileID", OleDbType.SmallInt).Value = transferProfileID;

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
