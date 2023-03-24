using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
//using Common;
using System.Data;

namespace Ticket.DataAccess
{
    class TicketDAL
    {
        private Common.Ticket FillEntity(IDataReader reader)
        {
            Common.Ticket ticket = new Common.Ticket();
            ticket.AmountDefault = decimal.Parse(reader.GetValue(reader.GetOrdinal("AmountDefault")).ToString());
            ticket.BinTicket = bool.Parse(reader.GetValue(reader.GetOrdinal("BinTicket")).ToString());
            ticket.DepositeValue = decimal.Parse(reader.GetValue(reader.GetOrdinal("DepositeValue")).ToString());
            ticket.DurationValidation = short.Parse(reader.GetValue(reader.GetOrdinal("DurationValidation")).ToString());
            ticket.EndDate = reader.GetValue(reader.GetOrdinal("EndDate")).ToString();
            ticket.fk_BankCostSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_BankCostSlotProfileID")).ToString());
            ticket.fk_BankDaysSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_BankDaysSlotProfileID")).ToString());
            ticket.fk_DiscountID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_DiscountID")).ToString());
            ticket.fk_EntryProcessingAlgorithmID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_EntryProcessingAlgorithmID")).ToString());
            ticket.fk_ExitProcessingAlgorithmID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ExitProcessingAlgorithmID")).ToString());
            ticket.fk_IssuingPrintingProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_IssuingPrintingProfileID")).ToString());
            ticket.fk_MediaKindID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_MediaKindID")).ToString());
            ticket.fk_PRDProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_PRDProfileID")).ToString());
            ticket.fk_RefundID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_RefundID")).ToString());
            ticket.fk_RegularCostSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_RegularCostSlotProfileID")).ToString());
            ticket.fk_RegularDaysSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_RegularDaysSlotProfileID")).ToString());
            ticket.fk_SchoolCostSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SchoolCostSlotProfileID")).ToString());
            ticket.fk_SchoolDaysSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SchoolDaysSlotProfileID")).ToString());
            ticket.fk_SectionFareID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SectionFareID")).ToString());
            ticket.fk_TicketKindID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_TicketKindID")).ToString());
            ticket.fk_TransferProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_TransferProfileID")).ToString());
            ticket.fk_ValidatingPrintingProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ValidatingPrintingProfileID")).ToString());
            ticket.IssueMaxNumberOfTicket = int.Parse(reader.GetValue(reader.GetOrdinal("IssueMaxNumberOfTicket")).ToString());
            ticket.ReloadExist = bool.Parse(reader.GetValue(reader.GetOrdinal("ReloadExist")).ToString());
            ticket.ReloadMaxTreshold = decimal.Parse(reader.GetValue(reader.GetOrdinal("ReloadMaxTreshold")).ToString());
            ticket.ReloadMinTreshold = decimal.Parse(reader.GetValue(reader.GetOrdinal("ReloadMinTreshold")).ToString());
            ticket.SaleExist = bool.Parse(reader.GetValue(reader.GetOrdinal("SaleExist")).ToString());
            ticket.StartDate = reader.GetValue(reader.GetOrdinal("StartDate")).ToString();
            ticket.TicketCostFuture = decimal.Parse(reader.GetValue(reader.GetOrdinal("TicketCostFuture")).ToString());
            ticket.TicketCostNow = decimal.Parse(reader.GetValue(reader.GetOrdinal("TicketCostNow")).ToString());
            ticket.TicketID = short.Parse(reader.GetValue(reader.GetOrdinal("TicketID")).ToString());
            ticket.TicketName = reader.GetValue(reader.GetOrdinal("TicketName")).ToString();
            ticket.TicketShortName = reader.GetValue(reader.GetOrdinal("TicketShortName")).ToString();
            ticket.TripNumber = short.Parse(reader.GetValue(reader.GetOrdinal("TripNumber")).ToString());

            return ticket;
        }

        public List<global::Common.Ticket> GetList()
        {
            List<Common.Ticket> list = new List<Common.Ticket>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspTicketGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTicketGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
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

        public global::Common.Ticket GetByID(short ticketID)
        {
            Common.Ticket ticket = new Common.Ticket();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspTicketGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", SqlDbType.SmallInt).Value = ticketID;
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    ticket = FillEntity(reader);
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
                return ticket;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTicketGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", OleDbType.SmallInt).Value = ticketID;
                    OleDbDataReader reader = command.ExecuteReader();

                    reader.Read();
                    ticket = FillEntity(reader);
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
                return ticket;
            }
        }

        public int InsertTicket(global::Common.Ticket ticket)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTicketInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketName", SqlDbType.NVarChar, 255).Value = ticket.TicketName;
                    command.Parameters.Add("@TicketShortName", SqlDbType.NVarChar, 50).Value = ticket.TicketShortName;
                    command.Parameters.Add("@fk_TicketKindID", SqlDbType.SmallInt).Value = ticket.fk_TicketKindID;
                    command.Parameters.Add("@fk_MediaKindID", SqlDbType.SmallInt).Value = ticket.fk_MediaKindID;
                    command.Parameters.Add("@fk_SectionFareID", SqlDbType.SmallInt).Value = ticket.fk_SectionFareID;
                    command.Parameters.Add("@DepositeValue", SqlDbType.Money).Value = ticket.DepositeValue;
                    command.Parameters.Add("@AmountDefault", SqlDbType.Money).Value = ticket.AmountDefault;
                    command.Parameters.Add("@fk_DiscountID", SqlDbType.SmallInt).Value = ticket.fk_DiscountID;
                    command.Parameters.Add("@fk_RefundID", SqlDbType.SmallInt).Value = ticket.fk_RefundID;
                    command.Parameters.Add("@fk_EntryProcessingAlgorithmID", SqlDbType.SmallInt).Value = ticket.fk_EntryProcessingAlgorithmID;
                    command.Parameters.Add("@fk_ExitProcessingAlgorithmID", SqlDbType.SmallInt).Value = ticket.fk_ExitProcessingAlgorithmID;
                    command.Parameters.Add("@fk_TransferProfileID", SqlDbType.SmallInt).Value = ticket.fk_TransferProfileID;
                    command.Parameters.Add("@TicketCostNow", SqlDbType.Money).Value = ticket.TicketCostNow;
                    command.Parameters.Add("@TicketCostFuture", SqlDbType.Money).Value = ticket.TicketCostFuture;
                    command.Parameters.Add("@TripNumber", SqlDbType.SmallInt).Value = ticket.TripNumber;
                    command.Parameters.Add("@DurationValidation", SqlDbType.SmallInt).Value = ticket.DurationValidation;
                    command.Parameters.Add("@StartDate", SqlDbType.NChar, 10).Value = ticket.StartDate;
                    command.Parameters.Add("@EndDate", SqlDbType.NChar, 10).Value = ticket.EndDate;
                    command.Parameters.Add("@BinTicket", SqlDbType.Bit).Value = ticket.BinTicket;
                    command.Parameters.Add("@fk_ValidatingPrintingProfileID", SqlDbType.SmallInt).Value = ticket.fk_ValidatingPrintingProfileID;
                    command.Parameters.Add("@fk_IssuingPrintingProfileID", SqlDbType.SmallInt).Value = ticket.fk_IssuingPrintingProfileID;
                    command.Parameters.Add("@fk_RegularDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_RegularDaysSlotProfileID;
                    command.Parameters.Add("@fk_SchoolDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_SchoolDaysSlotProfileID;
                    command.Parameters.Add("@fk_BankDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_BankDaysSlotProfileID;
                    command.Parameters.Add("@fk_RegularCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_RegularCostSlotProfileID;
                    command.Parameters.Add("@fk_SchoolCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_SchoolCostSlotProfileID;
                    command.Parameters.Add("@fk_BankCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_BankCostSlotProfileID;
                    command.Parameters.Add("@ReloadMinTreshold", SqlDbType.Money).Value = ticket.ReloadMinTreshold;
                    command.Parameters.Add("@ReloadMaxTreshold", SqlDbType.Money).Value = ticket.ReloadMaxTreshold;
                    command.Parameters.Add("@IssueMaxNumberOfTicket", SqlDbType.Int).Value = ticket.IssueMaxNumberOfTicket;
                    command.Parameters.Add("@SaleExist", SqlDbType.Bit).Value = ticket.SaleExist;
                    command.Parameters.Add("@ReloadExist", SqlDbType.Bit).Value = ticket.ReloadExist;
                    command.Parameters.Add("@fk_PRDProfileID", SqlDbType.SmallInt).Value = ticket.fk_PRDProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTicketInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", OleDbType.SmallInt).Value = ticket.TicketID;
                    command.Parameters.Add("@TicketName", OleDbType.VarChar, 255).Value = ticket.TicketName;
                    command.Parameters.Add("@TicketShortName", OleDbType.VarChar, 50).Value = ticket.TicketShortName;
                    command.Parameters.Add("@fk_TicketKindID", OleDbType.SmallInt).Value = ticket.fk_TicketKindID;
                    command.Parameters.Add("@fk_MediaKindID", OleDbType.SmallInt).Value = ticket.fk_MediaKindID;
                    command.Parameters.Add("@fk_SectionFareID", OleDbType.SmallInt).Value = ticket.fk_SectionFareID;
                    command.Parameters.Add("@DepositeValue", OleDbType.Currency).Value = ticket.DepositeValue;
                    command.Parameters.Add("@AmountDefault", OleDbType.Currency).Value = ticket.AmountDefault;
                    command.Parameters.Add("@fk_DiscountID", OleDbType.SmallInt).Value = ticket.fk_DiscountID;
                    command.Parameters.Add("@fk_RefundID", OleDbType.SmallInt).Value = ticket.fk_RefundID;
                    command.Parameters.Add("@fk_EntryProcessingAlgorithmID", OleDbType.SmallInt).Value = ticket.fk_EntryProcessingAlgorithmID;
                    command.Parameters.Add("@fk_ExitProcessingAlgorithmID", OleDbType.SmallInt).Value = ticket.fk_ExitProcessingAlgorithmID;
                    command.Parameters.Add("@fk_TransferProfileID", OleDbType.SmallInt).Value = ticket.fk_TransferProfileID;
                    command.Parameters.Add("@TicketCostNow", OleDbType.Currency).Value = ticket.TicketCostNow;
                    command.Parameters.Add("@TicketCostFuture", OleDbType.Currency).Value = ticket.TicketCostFuture;
                    command.Parameters.Add("@TripNumber", OleDbType.SmallInt).Value = ticket.TripNumber;
                    command.Parameters.Add("@DurationValidation", OleDbType.SmallInt).Value = ticket.DurationValidation;
                    command.Parameters.Add("@StartDate", OleDbType.Char, 10).Value = ticket.StartDate;
                    command.Parameters.Add("@EndDate", OleDbType.Char, 10).Value = ticket.EndDate;
                    command.Parameters.Add("@BinTicket", OleDbType.Boolean).Value = ticket.BinTicket;
                    command.Parameters.Add("@fk_ValidatingPrintingProfileID", OleDbType.SmallInt).Value = ticket.fk_ValidatingPrintingProfileID;
                    command.Parameters.Add("@fk_IssuingPrintingProfileID", OleDbType.SmallInt).Value = ticket.fk_IssuingPrintingProfileID;
                    command.Parameters.Add("@fk_RegularDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_RegularDaysSlotProfileID;
                    command.Parameters.Add("@fk_SchoolDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_SchoolDaysSlotProfileID;
                    command.Parameters.Add("@fk_BankDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_BankDaysSlotProfileID;
                    command.Parameters.Add("@fk_RegularCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_RegularCostSlotProfileID;
                    command.Parameters.Add("@fk_SchoolCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_SchoolCostSlotProfileID;
                    command.Parameters.Add("@fk_BankCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_BankCostSlotProfileID;
                    command.Parameters.Add("@ReloadMinTreshold", OleDbType.Currency).Value = ticket.ReloadMinTreshold;
                    command.Parameters.Add("@ReloadMaxTreshold", OleDbType.Currency).Value = ticket.ReloadMaxTreshold;
                    command.Parameters.Add("@IssueMaxNumberOfTicket", OleDbType.Integer).Value = ticket.IssueMaxNumberOfTicket;
                    command.Parameters.Add("@SaleExist", OleDbType.Boolean).Value = ticket.SaleExist;
                    command.Parameters.Add("@ReloadExist", OleDbType.Boolean).Value = ticket.ReloadExist;
                    command.Parameters.Add("@fk_PRDProfileID", OleDbType.SmallInt).Value = ticket.fk_PRDProfileID;

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

        public int UpdateTicket(global::Common.Ticket ticket)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTicketUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", SqlDbType.SmallInt).Value = ticket.TicketID;
                    command.Parameters.Add("@TicketName", SqlDbType.NVarChar, 255).Value = ticket.TicketName;
                    command.Parameters.Add("@TicketShortName", SqlDbType.NVarChar, 50).Value = ticket.TicketShortName;
                    command.Parameters.Add("@fk_TicketKindID", SqlDbType.SmallInt).Value = ticket.fk_TicketKindID;
                    command.Parameters.Add("@fk_MediaKindID", SqlDbType.SmallInt).Value = ticket.fk_MediaKindID;
                    command.Parameters.Add("@fk_SectionFareID", SqlDbType.SmallInt).Value = ticket.fk_SectionFareID;
                    command.Parameters.Add("@DepositeValue", SqlDbType.Money).Value = ticket.DepositeValue;
                    command.Parameters.Add("@AmountDefault", SqlDbType.Money).Value = ticket.AmountDefault;
                    command.Parameters.Add("@fk_DiscountID", SqlDbType.SmallInt).Value = ticket.fk_DiscountID;
                    command.Parameters.Add("@fk_RefundID", SqlDbType.SmallInt).Value = ticket.fk_RefundID;
                    command.Parameters.Add("@fk_EntryProcessingAlgorithmID", SqlDbType.SmallInt).Value = ticket.fk_EntryProcessingAlgorithmID;
                    command.Parameters.Add("@fk_ExitProcessingAlgorithmID", SqlDbType.SmallInt).Value = ticket.fk_ExitProcessingAlgorithmID;
                    command.Parameters.Add("@fk_TransferProfileID", SqlDbType.SmallInt).Value = ticket.fk_TransferProfileID;
                    command.Parameters.Add("@TicketCostNow", SqlDbType.Money).Value = ticket.TicketCostNow;
                    command.Parameters.Add("@TicketCostFuture", SqlDbType.Money).Value = ticket.TicketCostFuture;
                    command.Parameters.Add("@TripNumber", SqlDbType.SmallInt).Value = ticket.TripNumber;
                    command.Parameters.Add("@DurationValidation", SqlDbType.SmallInt).Value = ticket.DurationValidation;
                    command.Parameters.Add("@StartDate", SqlDbType.NChar, 10).Value = ticket.StartDate;
                    command.Parameters.Add("@EndDate", SqlDbType.NChar, 10).Value = ticket.EndDate;
                    command.Parameters.Add("@BinTicket", SqlDbType.Bit).Value = ticket.BinTicket;
                    command.Parameters.Add("@fk_ValidatingPrintingProfileID", SqlDbType.SmallInt).Value = ticket.fk_ValidatingPrintingProfileID;
                    command.Parameters.Add("@fk_IssuingPrintingProfileID", SqlDbType.SmallInt).Value = ticket.fk_IssuingPrintingProfileID;
                    command.Parameters.Add("@fk_RegularDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_RegularDaysSlotProfileID;
                    command.Parameters.Add("@fk_SchoolDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_SchoolDaysSlotProfileID;
                    command.Parameters.Add("@fk_BankDaysSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_BankDaysSlotProfileID;
                    command.Parameters.Add("@fk_RegularCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_RegularCostSlotProfileID;
                    command.Parameters.Add("@fk_SchoolCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_SchoolCostSlotProfileID;
                    command.Parameters.Add("@fk_BankCostSlotProfileID", SqlDbType.SmallInt).Value = ticket.fk_BankCostSlotProfileID;
                    command.Parameters.Add("@ReloadMinTreshold", SqlDbType.Money).Value = ticket.ReloadMinTreshold;
                    command.Parameters.Add("@ReloadMaxTreshold", SqlDbType.Money).Value = ticket.ReloadMaxTreshold;
                    command.Parameters.Add("@IssueMaxNumberOfTicket", SqlDbType.Int).Value = ticket.IssueMaxNumberOfTicket;
                    command.Parameters.Add("@SaleExist", SqlDbType.Bit).Value = ticket.SaleExist;
                    command.Parameters.Add("@ReloadExist", SqlDbType.Bit).Value = ticket.ReloadExist;
                    command.Parameters.Add("@fk_PRDProfileID", SqlDbType.SmallInt).Value = ticket.fk_PRDProfileID;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspTicketUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", OleDbType.SmallInt).Value = ticket.TicketID;
                    command.Parameters.Add("@TicketName", OleDbType.VarChar, 255).Value = ticket.TicketName;
                    command.Parameters.Add("@TicketShortName", OleDbType.VarChar, 50).Value = ticket.TicketShortName;
                    command.Parameters.Add("@fk_TicketKindID", OleDbType.SmallInt).Value = ticket.fk_TicketKindID;
                    command.Parameters.Add("@fk_MediaKindID", OleDbType.SmallInt).Value = ticket.fk_MediaKindID;
                    command.Parameters.Add("@fk_SectionFareID", OleDbType.SmallInt).Value = ticket.fk_SectionFareID;
                    command.Parameters.Add("@DepositeValue", OleDbType.Currency).Value = ticket.DepositeValue;
                    command.Parameters.Add("@AmountDefault", OleDbType.Currency).Value = ticket.AmountDefault;
                    command.Parameters.Add("@fk_DiscountID", OleDbType.SmallInt).Value = ticket.fk_DiscountID;
                    command.Parameters.Add("@fk_RefundID", OleDbType.SmallInt).Value = ticket.fk_RefundID;
                    command.Parameters.Add("@fk_EntryProcessingAlgorithmID", OleDbType.SmallInt).Value = ticket.fk_EntryProcessingAlgorithmID;
                    command.Parameters.Add("@fk_ExitProcessingAlgorithmID", OleDbType.SmallInt).Value = ticket.fk_ExitProcessingAlgorithmID;
                    command.Parameters.Add("@fk_TransferProfileID", OleDbType.SmallInt).Value = ticket.fk_TransferProfileID;
                    command.Parameters.Add("@TicketCostNow", OleDbType.Currency).Value = ticket.TicketCostNow;
                    command.Parameters.Add("@TicketCostFuture", OleDbType.Currency).Value = ticket.TicketCostFuture;
                    command.Parameters.Add("@TripNumber", OleDbType.SmallInt).Value = ticket.TripNumber;
                    command.Parameters.Add("@DurationValidation", OleDbType.SmallInt).Value = ticket.DurationValidation;
                    command.Parameters.Add("@StartDate", OleDbType.Char, 10).Value = ticket.StartDate;
                    command.Parameters.Add("@EndDate", OleDbType.Char, 10).Value = ticket.EndDate;
                    command.Parameters.Add("@BinTicket", OleDbType.Boolean).Value = ticket.BinTicket;
                    command.Parameters.Add("@fk_ValidatingPrintingProfileID", OleDbType.SmallInt).Value = ticket.fk_ValidatingPrintingProfileID;
                    command.Parameters.Add("@fk_IssuingPrintingProfileID", OleDbType.SmallInt).Value = ticket.fk_IssuingPrintingProfileID;
                    command.Parameters.Add("@fk_RegularDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_RegularDaysSlotProfileID;
                    command.Parameters.Add("@fk_SchoolDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_SchoolDaysSlotProfileID;
                    command.Parameters.Add("@fk_BankDaysSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_BankDaysSlotProfileID;
                    command.Parameters.Add("@fk_RegularCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_RegularCostSlotProfileID;
                    command.Parameters.Add("@fk_SchoolCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_SchoolCostSlotProfileID;
                    command.Parameters.Add("@fk_BankCostSlotProfileID", OleDbType.SmallInt).Value = ticket.fk_BankCostSlotProfileID;
                    command.Parameters.Add("@ReloadMinTreshold", OleDbType.Currency).Value = ticket.ReloadMinTreshold;
                    command.Parameters.Add("@ReloadMaxTreshold", OleDbType.Currency).Value = ticket.ReloadMaxTreshold;
                    command.Parameters.Add("@IssueMaxNumberOfTicket", OleDbType.Integer).Value = ticket.IssueMaxNumberOfTicket;
                    command.Parameters.Add("@SaleExist", OleDbType.Boolean).Value = ticket.SaleExist;
                    command.Parameters.Add("@ReloadExist", OleDbType.Boolean).Value = ticket.ReloadExist;
                    command.Parameters.Add("@fk_PRDProfileID", OleDbType.SmallInt).Value = ticket.fk_PRDProfileID;

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

        public int DeleteTicket(int ticketID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTicketDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", OleDbType.SmallInt).Value = ticketID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTicketDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TicketID", OleDbType.SmallInt).Value = ticketID;

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
