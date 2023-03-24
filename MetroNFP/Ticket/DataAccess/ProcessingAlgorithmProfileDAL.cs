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
    class ProcessingAlgorithmProfileDAL
    {
        private ProcessingAlgorithmProfile FillEntity(IDataReader reader)
        {
            ProcessingAlgorithmProfile processingAlgorithmProfile = new ProcessingAlgorithmProfile();
            processingAlgorithmProfile.ProcessingAlgorithmProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("ProcessingAlgorithmProfileID")).ToString());
            processingAlgorithmProfile.ProcessingAlgorithmProfileName = reader.GetValue(reader.GetOrdinal("ProcessingAlgorithmProfileName")).ToString();
            processingAlgorithmProfile.fk_ReaderMessageID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ReaderMessageID")).ToString());

            return processingAlgorithmProfile;
        }

        private ProcessingAlgorithm FillEntityProcessingAlgorithm(IDataReader reader)
        {
            ProcessingAlgorithm processingAlgorithm = new ProcessingAlgorithm();
            processingAlgorithm.fk_ProcessingAlgorithmOperationKindID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ProcessingAlgorithmOperationKindID")).ToString());
            processingAlgorithm.Sequence = short.Parse(reader.GetValue(reader.GetOrdinal("Sequence")).ToString());
            processingAlgorithm.fk_ProcessingID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ProcessingID")).ToString());
            processingAlgorithm.fk_RejectCodeID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_RejectCodeID")).ToString());
            processingAlgorithm.fk_ErrorReaderMessage = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ErrorReaderMessage")).ToString());
            processingAlgorithm.fk_EntryReaderMessage = short.Parse(reader.GetValue(reader.GetOrdinal("fk_EntryReaderMessage")).ToString());

            return processingAlgorithm;
        }

        public List<global::Common.ProcessingAlgorithmProfile> GetList()
        {
            List<ProcessingAlgorithmProfile> list = new List<ProcessingAlgorithmProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (ProcessingAlgorithmProfile rr in list)
                    {
                        SqlCommand commandProcessingAlgorithm = new SqlCommand("Ticket.NFPspProcessingAlgorithmGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandProcessingAlgorithm.CommandType = System.Data.CommandType.StoredProcedure;
                        commandProcessingAlgorithm.Parameters.Add("@fk_ProcessingAlgorithmProfileID", SqlDbType.SmallInt).Value = rr.ProcessingAlgorithmProfileID;
                        SqlDataReader readerProcessingAlgorithm = commandProcessingAlgorithm.ExecuteReader();

                        List<ProcessingAlgorithm> processingAlgorithm = new List<ProcessingAlgorithm>();
                        while (readerProcessingAlgorithm.Read())
                            processingAlgorithm.Add(FillEntityProcessingAlgorithm(readerProcessingAlgorithm));
                        readerProcessingAlgorithm.Close();

                        rr.ProcessingAlgorithms = processingAlgorithm;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (ProcessingAlgorithmProfile rr in list)
                    {
                        OleDbCommand commandProcessingAlgorithm = new OleDbCommand("Ticket.NFPspProcessingAlgorithmGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandProcessingAlgorithm.CommandType = System.Data.CommandType.StoredProcedure;
                        commandProcessingAlgorithm.Parameters.Add("@fk_ProcessingAlgorithmProfileID", OleDbType.SmallInt).Value = rr.ProcessingAlgorithmProfileID;
                        OleDbDataReader readerProcessingAlgorithm = commandProcessingAlgorithm.ExecuteReader();

                        List<ProcessingAlgorithm> processingAlgorithm = new List<ProcessingAlgorithm>();
                        while (readerProcessingAlgorithm.Read())
                            processingAlgorithm.Add(FillEntityProcessingAlgorithm(readerProcessingAlgorithm));
                        readerProcessingAlgorithm.Close();

                        rr.ProcessingAlgorithms = processingAlgorithm;
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

        public int InsertProcessingAlgorithmProfile(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmProfileInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ProcessingAlgorithmProfileName", SqlDbType.NVarChar, 50).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileName;
                    command.Parameters.Add("@fk_ReaderMessageID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.fk_ReaderMessageID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ProcessingAlgorithmProfileName", OleDbType.VarChar, 50).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileName;
                    command.Parameters.Add("@fk_ReaderMessageID", OleDbType.SmallInt).Value = processingAlgorithmProfile.fk_ReaderMessageID;

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

        public int UpdateProcessingAlgorithmProfile(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmProfileUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ProcessingAlgorithmProfileID", SqlDbType.Int).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                    command.Parameters.Add("@ProcessingAlgorithmProfileName", SqlDbType.NVarChar, 50).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileName;
                    command.Parameters.Add("@fk_ReaderMessageID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.fk_ReaderMessageID;

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
                    command.Parameters.Add("@ProcessingAlgorithmProfileID", OleDbType.Integer).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                    command.Parameters.Add("@ProcessingAlgorithmProfileName", OleDbType.VarChar, 50).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileName;
                    command.Parameters.Add("@fk_ReaderMessageID", OleDbType.SmallInt).Value = processingAlgorithmProfile.fk_ReaderMessageID;

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

        public int DeleteProcessingAlgorithmProfile(int processingAlgorithmProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ProcessingAlgorithmProfileID", SqlDbType.Int).Value = processingAlgorithmProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@ProcessingAlgorithmProfileID", OleDbType.Integer).Value = processingAlgorithmProfileID;

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

        public int InsertProcessingAlgorithm(List<global::Common.ProcessingAlgorithmProfile> processingAlgorithmProfiles)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    foreach (ProcessingAlgorithmProfile processingAlgorithmProfile in processingAlgorithmProfiles)
                    {
                        foreach (ProcessingAlgorithm processingAlgorithm in processingAlgorithmProfile.ProcessingAlgorithms)
                        {
                            SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", SqlDbType.SmallInt).Value = processingAlgorithm.fk_ProcessingAlgorithmOperationKindID;
                            command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                            command.Parameters.Add("@Sequence", SqlDbType.SmallInt).Value = processingAlgorithm.Sequence;
                            command.Parameters.Add("@fk_ProcessingID", SqlDbType.SmallInt).Value = processingAlgorithm.fk_ProcessingID;
                            command.Parameters.Add("@fk_RejectCodeID", SqlDbType.SmallInt).Value = processingAlgorithm.fk_RejectCodeID;
                            command.Parameters.Add("@fk_ErrorReaderMessage", SqlDbType.SmallInt).Value = processingAlgorithm.fk_ErrorReaderMessage;
                            command.Parameters.Add("@fk_EntryReaderMessage", SqlDbType.SmallInt).Value = processingAlgorithm.fk_EntryReaderMessage;

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
                    foreach (ProcessingAlgorithmProfile processingAlgorithmProfile in processingAlgorithmProfiles)
                    {
                        foreach (ProcessingAlgorithm processingAlgorithm in processingAlgorithmProfile.ProcessingAlgorithms)
                        {
                            OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", OleDbType.SmallInt).Value = processingAlgorithm.fk_ProcessingAlgorithmOperationKindID;
                            command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                            command.Parameters.Add("@Sequence", OleDbType.SmallInt).Value = processingAlgorithm.Sequence;
                            command.Parameters.Add("@fk_ProcessingID", OleDbType.SmallInt).Value = processingAlgorithm.fk_ProcessingID;
                            command.Parameters.Add("@fk_RejectCodeID", OleDbType.SmallInt).Value = processingAlgorithm.fk_RejectCodeID;
                            command.Parameters.Add("@fk_ErrorReaderMessage", OleDbType.SmallInt).Value = processingAlgorithm.fk_ErrorReaderMessage;
                            command.Parameters.Add("@fk_EntryReaderMessage", OleDbType.SmallInt).Value = processingAlgorithm.fk_EntryReaderMessage;

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

        public int UpdateProcessingAlgorithm(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile, short Oldfk_ProcessingAlgorithmOperationKindID, short OldSequence)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@oldfk_ProcessingAlgorithmOperationKindID", SqlDbType.SmallInt).Value = Oldfk_ProcessingAlgorithmOperationKindID;
                    command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_ProcessingAlgorithmOperationKindID;
                    command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                    command.Parameters.Add("@oldSequence", SqlDbType.SmallInt).Value = OldSequence;
                    command.Parameters.Add("@Sequence", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].Sequence;
                    command.Parameters.Add("@fk_ProcessingID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_ProcessingID;
                    command.Parameters.Add("@fk_RejectCodeID", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_RejectCodeID;
                    command.Parameters.Add("@fk_ErrorReaderMessage", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_ErrorReaderMessage;
                    command.Parameters.Add("@fk_EntryReaderMessage", SqlDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_EntryReaderMessage;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", OleDbType.SmallInt).Value = Oldfk_ProcessingAlgorithmOperationKindID;
                    command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithmProfileID;
                    command.Parameters.Add("@Sequence", OleDbType.SmallInt).Value = OldSequence;
                    command.Parameters.Add("@fk_ProcessingID", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_ProcessingID;
                    command.Parameters.Add("@fk_RejectCodeID", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_RejectCodeID;
                    command.Parameters.Add("@fk_ErrorReaderMessage", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_ErrorReaderMessage;
                    command.Parameters.Add("@fk_EntryReaderMessage", OleDbType.SmallInt).Value = processingAlgorithmProfile.ProcessingAlgorithms[0].fk_EntryReaderMessage;

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

        public int DeleteProcessingAlgorithm(short processingAlgorithmOperationKind, short processingAlgorithmProfileID, short sequence)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", SqlDbType.SmallInt).Value = processingAlgorithmOperationKind;
                    command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", SqlDbType.SmallInt).Value = processingAlgorithmProfileID;
                    command.Parameters.Add("@Sequence", SqlDbType.SmallInt).Value = sequence;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@fk_ProcessingAlgorithmOperationKindID", OleDbType.SmallInt).Value = processingAlgorithmOperationKind;
                    command.Parameters.Add("@fk_ProcessingAlgorithmProfileID", OleDbType.SmallInt).Value = processingAlgorithmProfileID;
                    command.Parameters.Add("@Sequence", OleDbType.SmallInt).Value = sequence;

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
