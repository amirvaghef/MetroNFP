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
    class PRDMessageDAL
    {
        private PRDMessage FillEntityPRDMessage(IDataReader reader)
        {
            PRDMessage prdMessage = new PRDMessage();
            prdMessage.PRDMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("PRDMessageID")).ToString());
            prdMessage.PRDMessageName = reader.GetValue(reader.GetOrdinal("PRDMessageName")).ToString();
            prdMessage.PRDMeesageText = reader.GetValue(reader.GetOrdinal("PRDMessageText")).ToString();
            prdMessage.PRDMessageRTL = bool.Parse(reader.GetValue(reader.GetOrdinal("PRDMessageRTL")).ToString());

            return prdMessage;
        }
        private PRDDynamicMessage FillEntityPRDDynamicMessage(IDataReader reader)
        {
            PRDDynamicMessage prdDynamicMessage = new PRDDynamicMessage();
            prdDynamicMessage.PRDDynamicMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("PRDDynamicMessageID")).ToString());
            prdDynamicMessage.PRDDynamicMessageName = reader.GetValue(reader.GetOrdinal("PRDDynamicMessageName")).ToString();
            prdDynamicMessage.PRDDynamicMessageData = reader.GetValue(reader.GetOrdinal("PRDDynamicMessageData")).ToString();

            return prdDynamicMessage;
        }

        public List<global::Common.PRDMessage> GetPRDMessageList()
        {
            List<PRDMessage> list = new List<PRDMessage>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspPRDMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityPRDMessage(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPRDMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityPRDMessage(reader));
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
        public List<global::Common.PRDDynamicMessage> GetPRDDynamicMessageList()
        {
            List<PRDDynamicMessage> list = new List<PRDDynamicMessage>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspPRDDynamicMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityPRDDynamicMessage(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPRDDynamicMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityPRDDynamicMessage(reader));
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

        public int InsertPRDMessage(global::Common.PRDMessage prdMessage)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPRDMessageInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageName", SqlDbType.NVarChar, 50).Value = prdMessage.PRDMessageName;
                    command.Parameters.Add("@PRDMeesageText", SqlDbType.NVarChar, 40).Value = prdMessage.PRDMeesageText;
                    command.Parameters.Add("@PRDMessageRTL", SqlDbType.Bit).Value = prdMessage.PRDMessageRTL;
                    
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPRDMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageName", OleDbType.VarChar, 50).Value = prdMessage.PRDMessageName;
                    command.Parameters.Add("@PRDMeesageText", OleDbType.VarChar, 40).Value = prdMessage.PRDMeesageText;
                    command.Parameters.Add("@PRDMessageRTL", OleDbType.Boolean).Value = prdMessage.PRDMessageRTL;

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

        public int UpdatePRDMessage(global::Common.PRDMessage prdMessage)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPRDMessageUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageID", SqlDbType.SmallInt).Value = prdMessage.PRDMessageID;
                    command.Parameters.Add("@PRDMessageName", SqlDbType.NVarChar, 50).Value = prdMessage.PRDMessageName;
                    command.Parameters.Add("@PRDMeesageText", SqlDbType.NVarChar, 40).Value = prdMessage.PRDMeesageText;
                    command.Parameters.Add("@PRDMessageRTL", SqlDbType.Bit).Value = prdMessage.PRDMessageRTL;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspPRDMessageUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageID", OleDbType.SmallInt).Value = prdMessage.PRDMessageID;
                    command.Parameters.Add("@PRDMessageName", OleDbType.VarChar, 50).Value = prdMessage.PRDMessageName;
                    command.Parameters.Add("@PRDMeesageText", OleDbType.VarChar, 40).Value = prdMessage.PRDMeesageText;
                    command.Parameters.Add("@PRDMessageRTL", OleDbType.Boolean).Value = prdMessage.PRDMessageRTL;

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

        public int DeletePRDMessage(int prdMessageID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPRDMessageDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageID", SqlDbType.SmallInt).Value = prdMessageID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPRDMessageDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PRDMessageID", OleDbType.SmallInt).Value = prdMessageID;

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
