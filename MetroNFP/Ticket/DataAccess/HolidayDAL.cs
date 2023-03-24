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
    class HolidayDAL
    {
        private BankHoliday FillEntityBankHoliday(IDataReader reader)
        {
            BankHoliday bankHoliday = new BankHoliday();
            bankHoliday.BankHolidayID = short.Parse(reader.GetValue(reader.GetOrdinal("BankHolidayID")).ToString());
            bankHoliday.BankHolidayName = reader.GetValue(reader.GetOrdinal("BankHolidayName")).ToString();
            bankHoliday.Date = reader.GetValue(reader.GetOrdinal("Date")).ToString();

            return bankHoliday;
        }
        private SchoolHoliday FillEntitySchoolHoliday(IDataReader reader)
        {
            SchoolHoliday schoolHoliday = new SchoolHoliday();
            schoolHoliday.SchoolHolidayID = short.Parse(reader.GetValue(reader.GetOrdinal("SchoolHolidayID")).ToString());
            schoolHoliday.SchoolHolidayName = reader.GetValue(reader.GetOrdinal("SchoolHolidayName")).ToString();
            schoolHoliday.FromDate = reader.GetValue(reader.GetOrdinal("FromDate")).ToString();
            schoolHoliday.UntilDate = reader.GetValue(reader.GetOrdinal("UntilDate")).ToString();

            return schoolHoliday;
        }

        public List<global::Common.BankHoliday> GetBankHolidayList()
        {
            List<BankHoliday> list = new List<BankHoliday>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspBankHolidayGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityBankHoliday(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspBankHolidayGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityBankHoliday(reader));
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
        public List<global::Common.SchoolHoliday> GetSchoolHolidayList()
        {
            List<SchoolHoliday> list = new List<SchoolHoliday>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspSchoolHolidayGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntitySchoolHoliday(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSchoolHolidayGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntitySchoolHoliday(reader));
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

        public int InsertBankHoliday(global::Common.BankHoliday bankHoliday)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspBankHolidayInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayName", SqlDbType.NVarChar, 50).Value = bankHoliday.BankHolidayName;
                    command.Parameters.Add("@Date", SqlDbType.NChar, 10).Value = bankHoliday.Date;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspBankHolidayInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayName", OleDbType.VarChar, 50).Value = bankHoliday.BankHolidayName;
                    command.Parameters.Add("@Date", OleDbType.Char, 10).Value = bankHoliday.Date;

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
        public int InsertSchoolHoliday(global::Common.SchoolHoliday schoolHoliday)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSchoolHolidayInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayName", SqlDbType.NVarChar, 50).Value = schoolHoliday.SchoolHolidayName;
                    command.Parameters.Add("@FromDate", SqlDbType.NChar, 10).Value = schoolHoliday.FromDate;
                    command.Parameters.Add("@UntilDate", SqlDbType.NChar, 10).Value = schoolHoliday.UntilDate;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSchoolHolidayInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayName", OleDbType.VarChar, 50).Value = schoolHoliday.SchoolHolidayName;
                    command.Parameters.Add("@FromDate", OleDbType.Char, 10).Value = schoolHoliday.FromDate;
                    command.Parameters.Add("@UntilDate", OleDbType.Char, 10).Value = schoolHoliday.UntilDate;

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

        public int UpdateBankHoliday(global::Common.BankHoliday bankHoliday)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspBankHolidayUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayID", SqlDbType.SmallInt).Value = bankHoliday.BankHolidayID;
                    command.Parameters.Add("@BankHolidayName", SqlDbType.NVarChar, 50).Value = bankHoliday.BankHolidayName;
                    command.Parameters.Add("@Date", SqlDbType.NChar, 10).Value = bankHoliday.Date;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspBankHolidayUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayID", OleDbType.SmallInt).Value = bankHoliday.BankHolidayID;
                    command.Parameters.Add("@BankHolidayName", OleDbType.VarChar, 50).Value = bankHoliday.BankHolidayName;
                    command.Parameters.Add("@Date", OleDbType.Char, 10).Value = bankHoliday.Date;

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
        public int UpdateSchoolHoliday(global::Common.SchoolHoliday schoolHoliday)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSchoolHolidayUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayID", SqlDbType.SmallInt).Value = schoolHoliday.SchoolHolidayID;
                    command.Parameters.Add("@SchoolHolidayName", SqlDbType.NVarChar, 50).Value = schoolHoliday.SchoolHolidayName;
                    command.Parameters.Add("@FromDate", SqlDbType.NChar, 10).Value = schoolHoliday.FromDate;
                    command.Parameters.Add("@UntilDate", SqlDbType.NChar, 10).Value = schoolHoliday.UntilDate;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspSchoolHolidayUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayID", OleDbType.SmallInt).Value = schoolHoliday.SchoolHolidayID;
                    command.Parameters.Add("@SchoolHolidayName", OleDbType.VarChar, 50).Value = schoolHoliday.SchoolHolidayName;
                    command.Parameters.Add("@FromDate", OleDbType.Char, 10).Value = schoolHoliday.FromDate;
                    command.Parameters.Add("@UntilDate", OleDbType.Char, 10).Value = schoolHoliday.UntilDate;

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

        public int DeleteBankHoliday(short bankHolidayID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspBankHolidayDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayID", SqlDbType.SmallInt).Value = bankHolidayID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspBankHolidayDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@BankHolidayID", OleDbType.SmallInt).Value = bankHolidayID;

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
        public int DeleteSchoolHoliday(short schoolHolidayID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspSchoolHolidayDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayID", SqlDbType.SmallInt).Value = schoolHolidayID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspSchoolHolidayDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@SchoolHolidayID", OleDbType.SmallInt).Value = schoolHolidayID;

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
