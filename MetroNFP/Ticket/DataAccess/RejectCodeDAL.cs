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
    class RejectCodeDAL
    {
        private RejectCode FillEntityRejectCode(IDataReader reader)
        {
            RejectCode rejectCode = new RejectCode();
            rejectCode.RejectCodeID = short.Parse(reader.GetValue(reader.GetOrdinal("RejectCodeID")).ToString());
            rejectCode.RejectCodeName = reader.GetValue(reader.GetOrdinal("RejectCodeName")).ToString();
            rejectCode.ActivityRecord = bool.Parse(reader.GetValue(reader.GetOrdinal("ActivityRecord")).ToString());
            rejectCode.TicketRecord = bool.Parse(reader.GetValue(reader.GetOrdinal("TicketRecord")).ToString());
            rejectCode.fk_FineID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_FineID")).ToString());
            rejectCode.fk_PRDMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_PRDMessageID")).ToString());

            return rejectCode;
        }

        public List<global::Common.RejectCode> GetRejectCodeList()
        {
            List<RejectCode> list = new List<RejectCode>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspRejectCodeGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityRejectCode(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspRejectCodeGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityRejectCode(reader));
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

        public int InsertRejectCode(global::Common.RejectCode rejectCode)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspRejectCodeInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeName", SqlDbType.NVarChar, 50).Value = rejectCode.RejectCodeName;
                    command.Parameters.Add("@ActivityRecord", SqlDbType.Bit).Value = rejectCode.ActivityRecord;
                    command.Parameters.Add("@TicketRecord", SqlDbType.Bit).Value = rejectCode.TicketRecord;
                    command.Parameters.Add("@fk_FineID", SqlDbType.SmallInt).Value = rejectCode.fk_FineID;
                    command.Parameters.Add("@fk_PRDMessageID", SqlDbType.SmallInt).Value = rejectCode.fk_PRDMessageID;
                    
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspRejectCodeInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeName", OleDbType.VarChar, 50).Value = rejectCode.RejectCodeName;
                    command.Parameters.Add("@ActivityRecord", OleDbType.Boolean).Value = rejectCode.ActivityRecord;
                    command.Parameters.Add("@TicketRecord", OleDbType.Boolean).Value = rejectCode.TicketRecord;
                    command.Parameters.Add("@fk_FineID", OleDbType.SmallInt).Value = rejectCode.fk_FineID;
                    command.Parameters.Add("@fk_PRDMessageID", OleDbType.SmallInt).Value = rejectCode.fk_PRDMessageID;

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

        public int UpdateRejectCode(global::Common.RejectCode rejectCode)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspRejectCodeUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeID", SqlDbType.SmallInt).Value = rejectCode.RejectCodeID;
                    command.Parameters.Add("@RejectCodeName", SqlDbType.NVarChar, 50).Value = rejectCode.RejectCodeName;
                    command.Parameters.Add("@ActivityRecord", SqlDbType.Bit).Value = rejectCode.ActivityRecord;
                    command.Parameters.Add("@TicketRecord", SqlDbType.Bit).Value = rejectCode.TicketRecord;
                    command.Parameters.Add("@fk_FineID", SqlDbType.SmallInt).Value = rejectCode.fk_FineID;
                    command.Parameters.Add("@fk_PRDMessageID", SqlDbType.SmallInt).Value = rejectCode.fk_PRDMessageID;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspRejectCodeUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeID", OleDbType.SmallInt).Value = rejectCode.RejectCodeID;
                    command.Parameters.Add("@RejectCodeName", OleDbType.VarChar, 50).Value = rejectCode.RejectCodeName;
                    command.Parameters.Add("@ActivityRecord", OleDbType.Boolean).Value = rejectCode.ActivityRecord;
                    command.Parameters.Add("@TicketRecord", OleDbType.Boolean).Value = rejectCode.TicketRecord;
                    command.Parameters.Add("@fk_FineID", OleDbType.SmallInt).Value = rejectCode.fk_FineID;
                    command.Parameters.Add("@fk_PRDMessageID", OleDbType.SmallInt).Value = rejectCode.fk_PRDMessageID;

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

        public int DeleteRejectCode(int rejectCodeID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspRejectCodeDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeID", SqlDbType.SmallInt).Value = rejectCodeID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspRejectCodeDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@RejectCodeID", OleDbType.SmallInt).Value = rejectCodeID;

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
