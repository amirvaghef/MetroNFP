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
    class ReaderMessageDAL
    {
        private ReaderMessage FillEntityReaderMessage(IDataReader reader)
        {
            ReaderMessage readerMessage = new ReaderMessage();
            readerMessage.ReaderMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("ReaderMessageID")).ToString());
            readerMessage.ReaderMessageName = reader.GetValue(reader.GetOrdinal("ReaderMessageName")).ToString();
            readerMessage.ReaderMeesageText = reader.GetValue(reader.GetOrdinal("ReaderMeesageText")).ToString();
            readerMessage.ReaderMessageRTL = bool.Parse(reader.GetValue(reader.GetOrdinal("ReaderMessageRTL")).ToString());

            return readerMessage;
        }
        private ReaderDynamicMessage FillEntityReaderDynamicMessage(IDataReader reader)
        {
            ReaderDynamicMessage readerDynamicMessage = new ReaderDynamicMessage();
            readerDynamicMessage.ReaderDynamicMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("ReaderDynamicMessageID")).ToString());
            readerDynamicMessage.ReaderDynamicMessageName = reader.GetValue(reader.GetOrdinal("ReaderDynamicMessageName")).ToString();
            readerDynamicMessage.ReaderDynamicMessageData = reader.GetValue(reader.GetOrdinal("ReaderDynamicMessageData")).ToString();

            return readerDynamicMessage;
        }

        public List<global::Common.ReaderMessage> GetReaderMessageList()
        {
            List<ReaderMessage> list = new List<ReaderMessage>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspReaderMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityReaderMessage(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspReaderMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityReaderMessage(reader));
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
        public List<global::Common.ReaderDynamicMessage> GetReaderDynamicMessageList()
        {
            List<ReaderDynamicMessage> list = new List<ReaderDynamicMessage>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspReaderDynamicMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityReaderDynamicMessage(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspReaderDynamicMessageGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityReaderDynamicMessage(reader));
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

        public int InsertReaderMessage(global::Common.ReaderMessage readerMessage)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspReaderMessageInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageName", SqlDbType.NVarChar, 50).Value = readerMessage.ReaderMessageName;
                    command.Parameters.Add("@ReaderMeesageText", SqlDbType.NVarChar, 40).Value = readerMessage.ReaderMeesageText;
                    command.Parameters.Add("@ReaderMessageRTL", SqlDbType.Bit).Value = readerMessage.ReaderMessageRTL;
                    
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspReaderMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageName", OleDbType.VarChar, 50).Value = readerMessage.ReaderMessageName;
                    command.Parameters.Add("@ReaderMeesageText", OleDbType.VarChar, 40).Value = readerMessage.ReaderMeesageText;
                    command.Parameters.Add("@ReaderMessageRTL", OleDbType.Boolean).Value = readerMessage.ReaderMessageRTL;

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

        public int UpdateReaderMessage(global::Common.ReaderMessage readerMessage)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspReaderMessageUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageID", SqlDbType.SmallInt).Value = readerMessage.ReaderMessageID;
                    command.Parameters.Add("@ReaderMessageName", SqlDbType.NVarChar, 50).Value = readerMessage.ReaderMessageName;
                    command.Parameters.Add("@ReaderMeesageText", SqlDbType.NVarChar, 40).Value = readerMessage.ReaderMeesageText;
                    command.Parameters.Add("@ReaderMessageRTL", SqlDbType.Bit).Value = readerMessage.ReaderMessageRTL;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspReaderMessageUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageID", OleDbType.SmallInt).Value = readerMessage.ReaderMessageID;
                    command.Parameters.Add("@ReaderMessageName", OleDbType.VarChar, 50).Value = readerMessage.ReaderMessageName;
                    command.Parameters.Add("@ReaderMeesageText", OleDbType.VarChar, 40).Value = readerMessage.ReaderMeesageText;
                    command.Parameters.Add("@ReaderMessageRTL", OleDbType.Boolean).Value = readerMessage.ReaderMessageRTL;

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

        public int DeleteReaderMessage(int readerMessageID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspReaderMessageDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageID", SqlDbType.SmallInt).Value = readerMessageID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspReaderMessageDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ReaderMessageID", OleDbType.SmallInt).Value = readerMessageID;

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
