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
    class DiscountRefundProfileDAL
    {
        private DiscountRefundProfile FillEntity(IDataReader reader)
        {
            DiscountRefundProfile discountRefundProfile = new DiscountRefundProfile();
            discountRefundProfile.DiscountRefundProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("DiscountRefundProfileID")).ToString());
            discountRefundProfile.DiscountRefundProfileName = reader.GetValue(reader.GetOrdinal("DiscountRefundProfileName")).ToString();
            discountRefundProfile.OperationKind = byte.Parse(reader.GetValue(reader.GetOrdinal("OperationKind")).ToString());

            return discountRefundProfile;
        }

        private DiscountRefund FillEntityDiscountRefund(IDataReader reader)
        {
            DiscountRefund discountRefund = new DiscountRefund();
            discountRefund.DiscountRefundID = int.Parse(reader.GetValue(reader.GetOrdinal("DiscountRefundID")).ToString());
            discountRefund.StartCost = double.Parse(reader.GetValue(reader.GetOrdinal("StartCost")).ToString());
            discountRefund.FinishCost = double.Parse(reader.GetValue(reader.GetOrdinal("FinishCost")).ToString());
            discountRefund.Percent = Int16.Parse(reader.GetValue(reader.GetOrdinal("Percent")).ToString());

            return discountRefund;
        }

        public List<global::Common.DiscountRefundProfile> GetDiscountList()
        {
            List<DiscountRefundProfile> list = new List<DiscountRefundProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
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
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
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

        public List<global::Common.DiscountRefundProfile> GetRefundList()
        {
            List<DiscountRefundProfile> list = new List<DiscountRefundProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspRefundProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
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
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspRefundProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
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

        public List<global::Common.DiscountRefundProfile> GetList()
        {
            List<DiscountRefundProfile> list = new List<DiscountRefundProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (DiscountRefundProfile rr in list)
                    {
                        SqlCommand commandDiscountRefund = new SqlCommand("Ticket.NFPspDiscountRefundGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandDiscountRefund.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDiscountRefund.Parameters.Add("@fk_DiscountRefundID", SqlDbType.SmallInt).Value = rr.DiscountRefundProfileID;
                        SqlDataReader readerDiscountRefund = commandDiscountRefund.ExecuteReader();

                        List<DiscountRefund> discountRefund = new List<DiscountRefund>();
                        while (readerDiscountRefund.Read())
                            discountRefund.Add(FillEntityDiscountRefund(readerDiscountRefund));
                        readerDiscountRefund.Close();

                        rr.DiscountRefunds = discountRefund;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();

                    foreach (DiscountRefundProfile rr in list)
                    {
                        OleDbCommand commandDiscountRefund = new OleDbCommand("Ticket.NFPspDiscountRefundGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandDiscountRefund.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDiscountRefund.Parameters.Add("@fk_DiscountRefundID", OleDbType.SmallInt).Value = rr.DiscountRefundProfileID;
                        OleDbDataReader readerDiscountRefund = commandDiscountRefund.ExecuteReader();

                        List<DiscountRefund> discountRefund = new List<DiscountRefund>();
                        while (readerDiscountRefund.Read())
                            discountRefund.Add(FillEntityDiscountRefund(readerDiscountRefund));
                        readerDiscountRefund.Close();

                        rr.DiscountRefunds = discountRefund;
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

        public int InsertDiscountRefundProfile(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundProfileInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileName", SqlDbType.NVarChar, 50).Value = discountRefundProfile.DiscountRefundProfileName;
                    command.Parameters.Add("@OperationKind", SqlDbType.Bit).Value = discountRefundProfile.OperationKind;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileName", OleDbType.VarChar, 50).Value = discountRefundProfile.DiscountRefundProfileName;
                    command.Parameters.Add("@OperationKind", OleDbType.TinyInt).Value = discountRefundProfile.OperationKind;

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

        public int UpdateDiscountRefundProfile(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundProfileUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileID", SqlDbType.SmallInt).Value = discountRefundProfile.DiscountRefundProfileID;
                    command.Parameters.Add("@DiscountRefundProfileName", SqlDbType.NVarChar, 50).Value = discountRefundProfile.DiscountRefundProfileName;
                    command.Parameters.Add("@OperationKind", SqlDbType.Bit).Value = discountRefundProfile.OperationKind;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundProfileUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileID", OleDbType.SmallInt).Value = discountRefundProfile.DiscountRefundProfileID;
                    command.Parameters.Add("@DiscountRefundProfileName", OleDbType.VarChar, 50).Value = discountRefundProfile.DiscountRefundProfileName;
                    command.Parameters.Add("@OperationKind", OleDbType.TinyInt).Value = discountRefundProfile.OperationKind;

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

        public int DeleteDiscountRefundProfile(int discountRefundProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileID", SqlDbType.SmallInt).Value = discountRefundProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@DiscountRefundProfileID", OleDbType.SmallInt).Value = discountRefundProfileID;

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

        public int InsertDiscountRefund(List<global::Common.DiscountRefundProfile> discountRefundProfiles)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    foreach (DiscountRefundProfile discountRefundProfile in discountRefundProfiles)
                    {
                        foreach (DiscountRefund discountRefund in discountRefundProfile.DiscountRefunds)
                        {
                            SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_DiscountRefundID", SqlDbType.SmallInt).Value = discountRefundProfile.DiscountRefundProfileID;
                            command.Parameters.Add("@StartCost", SqlDbType.Money).Value = discountRefund.StartCost;
                            command.Parameters.Add("@FinishCost", SqlDbType.Money).Value = discountRefund.FinishCost;
                            command.Parameters.Add("@Percent", SqlDbType.SmallInt).Value = discountRefund.Percent;

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
                    foreach (DiscountRefundProfile discountRefundProfile in discountRefundProfiles)
                    {
                        foreach (DiscountRefund discountRefund in discountRefundProfile.DiscountRefunds)
                        {
                            OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.Add("@fk_DiscountRefundID", OleDbType.SmallInt).Value = discountRefundProfile.DiscountRefundProfileID;
                            command.Parameters.Add("@StartCost", OleDbType.Currency).Value = discountRefund.StartCost;
                            command.Parameters.Add("@FinishCost", OleDbType.Currency).Value = discountRefund.FinishCost;
                            command.Parameters.Add("@Percent", OleDbType.SmallInt).Value = discountRefund.Percent;

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

        public int UpdateDiscountRefund(global::Common.DiscountRefundProfile discountRefundProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@DiscountRefundID", SqlDbType.Int).Value = discountRefundProfile.DiscountRefunds[0].DiscountRefundID;
                    command.Parameters.Add("@StartCost", SqlDbType.Money).Value = discountRefundProfile.DiscountRefunds[0].StartCost;
                    command.Parameters.Add("@FinishCost", SqlDbType.Money).Value = discountRefundProfile.DiscountRefunds[0].FinishCost;
                    command.Parameters.Add("@Percent", SqlDbType.SmallInt).Value = discountRefundProfile.DiscountRefunds[0].Percent;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@DiscountRefundID", OleDbType.Integer).Value = discountRefundProfile.DiscountRefundProfileID;
                    command.Parameters.Add("@StartCost", OleDbType.Currency).Value = discountRefundProfile.DiscountRefunds[0].StartCost;
                    command.Parameters.Add("@FinishCost", OleDbType.Currency).Value = discountRefundProfile.DiscountRefunds[0].FinishCost;
                    command.Parameters.Add("@Percent", OleDbType.SmallInt).Value = discountRefundProfile.DiscountRefunds[0].Percent;

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

        public int DeleteDiscountRefund(int discountRefundID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspDiscountRefundDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@DiscountRefundID", SqlDbType.Int).Value = discountRefundID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspDiscountRefundDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add("@DiscountRefundID", OleDbType.Integer).Value = discountRefundID;

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
