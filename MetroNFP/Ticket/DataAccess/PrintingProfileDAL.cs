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
    class PrintingProfileDAL
    {
        private PrintingProfile FillProfileEntity(IDataReader reader)
        {
            PrintingProfile printingProfile = new PrintingProfile();
            printingProfile.PrintingProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("PrintingProfileID")).ToString());
            printingProfile.PrintingProfileName = reader.GetValue(reader.GetOrdinal("PrintingProfileName")).ToString();
            printingProfile.PrintingProfileOperationKind = bool.Parse(reader.GetValue(reader.GetOrdinal("PrintingProfileOperationKind")).ToString());

            return printingProfile;
        }
        private PrintingDynamicMessage FillDynamicMessageEntity(IDataReader reader)
        {
            PrintingDynamicMessage printingDynamicMessage = new PrintingDynamicMessage();
            printingDynamicMessage.PrintingDynamicVariableID = short.Parse(reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableID")).ToString());
            printingDynamicMessage.PrintingDynamicVariableName = reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableName")).ToString();
            printingDynamicMessage.PrintingDynamicVariableData = reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableData")).ToString();
            printingDynamicMessage.Direction = bool.Parse(reader.GetValue(reader.GetOrdinal("Direction")).ToString());
            printingDynamicMessage.Font = reader.GetValue(reader.GetOrdinal("Font")).ToString();
            printingDynamicMessage.FontSize = short.Parse(reader.GetValue(reader.GetOrdinal("FontSize")).ToString());
            printingDynamicMessage.X = short.Parse(reader.GetValue(reader.GetOrdinal("X")).ToString());
            printingDynamicMessage.Y = short.Parse(reader.GetValue(reader.GetOrdinal("Y")).ToString());

            return printingDynamicMessage;
        }
        private PrintingStaticMessage FillStaticMessageEntity(IDataReader reader)
        {
            PrintingStaticMessage printingStaticMessage = new PrintingStaticMessage();
            printingStaticMessage.PrintingStaticMessageData = reader.GetValue(reader.GetOrdinal("PrintingStaticMessageData")).ToString();
            printingStaticMessage.Direction = bool.Parse(reader.GetValue(reader.GetOrdinal("Direction")).ToString());
            printingStaticMessage.Font = reader.GetValue(reader.GetOrdinal("Font")).ToString();
            printingStaticMessage.FontSize = short.Parse(reader.GetValue(reader.GetOrdinal("FontSize")).ToString());
            printingStaticMessage.X = short.Parse(reader.GetValue(reader.GetOrdinal("X")).ToString());
            printingStaticMessage.Y = short.Parse(reader.GetValue(reader.GetOrdinal("Y")).ToString());

            return printingStaticMessage;
        }
        private PrintingDynamicVariable FillDynamicVariableEntity(IDataReader reader)
        {
            PrintingDynamicVariable printingDynamicVariable = new PrintingDynamicVariable();
            printingDynamicVariable.PrintingDynamicVariableID = short.Parse(reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableID")).ToString());
            printingDynamicVariable.PrintingDynamicVariableName = reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableName")).ToString();
            printingDynamicVariable.PrintingDynamicVariableData = reader.GetValue(reader.GetOrdinal("PrintingDynamicVariableData")).ToString();

            return printingDynamicVariable;
        }

        public List<global::Common.PrintingProfile> GetList()
        {
            List<PrintingProfile> list = new List<PrintingProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        SqlCommand commandStatics = new SqlCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        SqlCommand commandDynamics = new SqlCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        OleDbCommand commandStatics = new OleDbCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", OleDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        OleDbCommand commandDynamics = new OleDbCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
        public List<global::Common.PrintingDynamicVariable> GetVariableList()
        {
            List<PrintingDynamicVariable> list = new List<PrintingDynamicVariable>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingDynamicVariableGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillDynamicVariableEntity(reader));
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingDynamicVariableGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillDynamicVariableEntity(reader));
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
        public List<global::Common.PrintingProfile> GetValidationList()
        {
            List<PrintingProfile> list = new List<PrintingProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileValidationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        SqlCommand commandStatics = new SqlCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        SqlCommand commandDynamics = new SqlCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileValidationGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        OleDbCommand commandStatics = new OleDbCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", OleDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        OleDbCommand commandDynamics = new OleDbCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
        public List<global::Common.PrintingProfile> GetIssueList()
        {
            List<PrintingProfile> list = new List<PrintingProfile>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileIssueGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        SqlCommand commandStatics = new SqlCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        SqlCommand commandDynamics = new SqlCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        SqlDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileIssueGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillProfileEntity(reader));
                    reader.Close();

                    for (int i = 0; i < list.Count; i++)
                    {
                        OleDbCommand commandStatics = new OleDbCommand("Ticket.NFPspPrintingStaticMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandStatics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandStatics.Parameters.Add("@fk_PrintingProfileID", OleDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerStatics = commandStatics.ExecuteReader();

                        List<PrintingStaticMessage> Statics = new List<PrintingStaticMessage>();
                        while (readerStatics.Read())
                            Statics.Add(FillStaticMessageEntity(readerStatics));
                        readerStatics.Close();

                        list[i].PrintingStaticMessages = Statics;

                        OleDbCommand commandDynamics = new OleDbCommand("Ticket.NFPspPrintingDynamicMessageGetByID", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        commandDynamics.CommandType = System.Data.CommandType.StoredProcedure;
                        commandDynamics.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = list[i].PrintingProfileID;
                        OleDbDataReader readerDynamics = commandDynamics.ExecuteReader();

                        List<PrintingDynamicMessage> Dynamics = new List<PrintingDynamicMessage>();
                        while (readerDynamics.Read())
                            Dynamics.Add(FillDynamicMessageEntity(readerDynamics));
                        readerDynamics.Close();

                        list[i].PrintingDynamicMessages = Dynamics;
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
        public int Insert(global::Common.PrintingProfile printingProfile, bool profileOnly)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    if (profileOnly)
                    {
                        SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("@PrintingProfileName", SqlDbType.NVarChar, 50).Value = printingProfile.PrintingProfileName;
                        command.Parameters.Add("@PrintingProfileOperationKind", SqlDbType.Bit).Value = printingProfile.PrintingProfileOperationKind;

                        result = command.ExecuteNonQuery();
                    }
                    else
                    {
                        if (printingProfile.PrintingDynamicMessages != null)
                            foreach (PrintingDynamicMessage dynamic in printingProfile.PrintingDynamicMessages)
                            {
                                SqlCommand command1 = new SqlCommand("Ticket.NFPspPrintingDynamicMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                                command1.CommandType = System.Data.CommandType.StoredProcedure;
                                command1.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = dynamic.fk_PrintingProfileID;
                                command1.Parameters.Add("@fk_PrintingDynamicVariableID", SqlDbType.SmallInt).Value = dynamic.PrintingDynamicVariableID;
                                command1.Parameters.Add("@X", SqlDbType.SmallInt).Value = dynamic.X;
                                command1.Parameters.Add("@Y", SqlDbType.SmallInt).Value = dynamic.Y;
                                command1.Parameters.Add("@FontSize", SqlDbType.SmallInt).Value = dynamic.FontSize;
                                command1.Parameters.Add("@Direction", SqlDbType.Bit).Value = dynamic.Direction;
                                command1.Parameters.Add("@Font", SqlDbType.VarChar, 50).Value = dynamic.Font;

                                result = command1.ExecuteNonQuery();
                            }

                        if (printingProfile.PrintingStaticMessages != null)
                            foreach (PrintingStaticMessage stat in printingProfile.PrintingStaticMessages)
                            {
                                SqlCommand command2 = new SqlCommand("Ticket.NFPspPrintingStaticMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                                command2.CommandType = System.Data.CommandType.StoredProcedure;
                                command2.Parameters.Add("@fk_PrintingProfileID", SqlDbType.SmallInt).Value = stat.fk_PrintingProfileID;
                                command2.Parameters.Add("@PrintingStaticMessageData", SqlDbType.NVarChar, 50).Value = stat.PrintingStaticMessageData;
                                command2.Parameters.Add("@X", SqlDbType.SmallInt).Value = stat.X;
                                command2.Parameters.Add("@Y", SqlDbType.SmallInt).Value = stat.Y;
                                command2.Parameters.Add("@FontSize", SqlDbType.SmallInt).Value = stat.FontSize;
                                command2.Parameters.Add("@Direction", SqlDbType.Bit).Value = stat.Direction;
                                command2.Parameters.Add("@Font", SqlDbType.VarChar, 50).Value = stat.Font;

                                result = command2.ExecuteNonQuery();
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
                    if (profileOnly)
                    {
                        OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("@PrintingProfileName", OleDbType.VarChar, 50).Value = printingProfile.PrintingProfileName;
                        command.Parameters.Add("@PrintingProfileOperationKind", OleDbType.Boolean).Value = printingProfile.PrintingProfileOperationKind;

                        result = command.ExecuteNonQuery();

                    }
                    else
                    {
                        if (printingProfile.PrintingDynamicMessages != null)
                            foreach (PrintingDynamicMessage dynamic in printingProfile.PrintingDynamicMessages)
                            {
                                OleDbCommand command1 = new OleDbCommand("Ticket.NFPspPrintingDynamicMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                                command1.CommandType = System.Data.CommandType.StoredProcedure;
                                command1.Parameters.Add("@fk_PrintingProfileID", OleDbType.SmallInt).Value = dynamic.fk_PrintingProfileID;
                                command1.Parameters.Add("@fk_PrintingDynamicVariableID", OleDbType.SmallInt).Value = dynamic.PrintingDynamicVariableID;
                                command1.Parameters.Add("@X", OleDbType.SmallInt).Value = dynamic.X;
                                command1.Parameters.Add("@Y", OleDbType.SmallInt).Value = dynamic.Y;
                                command1.Parameters.Add("@FontSize", OleDbType.SmallInt).Value = dynamic.FontSize;
                                command1.Parameters.Add("@Direction", OleDbType.Boolean).Value = dynamic.Direction;
                                command1.Parameters.Add("@Font", OleDbType.VarChar, 50).Value = dynamic.Font;

                                result = command1.ExecuteNonQuery();
                            }

                        if (printingProfile.PrintingStaticMessages != null)
                            foreach (PrintingStaticMessage stat in printingProfile.PrintingStaticMessages)
                            {
                                OleDbCommand command2 = new OleDbCommand("Ticket.NFPspPrintingStaticMessageInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                                command2.CommandType = System.Data.CommandType.StoredProcedure;
                                command2.Parameters.Add("@fk_PrintingProfileID", OleDbType.SmallInt).Value = stat.fk_PrintingProfileID;
                                command2.Parameters.Add("@PrintingStaticMessageData", OleDbType.VarChar, 50).Value = stat.PrintingStaticMessageData;
                                command2.Parameters.Add("@X", OleDbType.SmallInt).Value = stat.X;
                                command2.Parameters.Add("@Y", OleDbType.SmallInt).Value = stat.Y;
                                command2.Parameters.Add("@FontSize", OleDbType.SmallInt).Value = stat.FontSize;
                                command2.Parameters.Add("@Direction", OleDbType.Boolean).Value = stat.Direction;
                                command2.Parameters.Add("@Font", OleDbType.VarChar, 50).Value = stat.Font;

                                result = command2.ExecuteNonQuery();
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
        public int Update(global::Common.PrintingProfile printingProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PrintingProfileID", SqlDbType.SmallInt).Value = printingProfile.PrintingProfileID;
                    command.Parameters.Add("@PrintingProfileName", SqlDbType.NVarChar, 50).Value = printingProfile.PrintingProfileName;
                    command.Parameters.Add("@PrintingProfileOperationKind", SqlDbType.Bit).Value = printingProfile.PrintingProfileOperationKind;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PrintingProfileID", OleDbType.SmallInt).Value = printingProfile.PrintingProfileID;
                    command.Parameters.Add("@PrintingProfileName", OleDbType.VarChar, 50).Value = printingProfile.PrintingProfileName;
                    command.Parameters.Add("@PrintingProfileOperationKind", OleDbType.Boolean).Value = printingProfile.PrintingProfileOperationKind;

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
        public int Delete(short printingProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspPrintingProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PrintingProfileID", SqlDbType.SmallInt).Value = printingProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspPrintingProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@PrintingProfileID", OleDbType.SmallInt).Value = printingProfileID;

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
