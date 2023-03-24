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
    class TimeSlotProfileDAL
    {
        private TimeSlot FillEntityTimeSlot(IDataReader reader)
        {
            TimeSlot timeSlot = new TimeSlot();
            timeSlot.EighthFinishTime = reader.GetValue(reader.GetOrdinal("EighthFinishTime")).ToString();
            timeSlot.EighthStartTime = reader.GetValue(reader.GetOrdinal("EighthStartTime")).ToString();
            timeSlot.FifthFinishTime = reader.GetValue(reader.GetOrdinal("FifthFinishTime")).ToString();
            timeSlot.FifthStartTime = reader.GetValue(reader.GetOrdinal("FifthStartTime")).ToString();
            timeSlot.FirstFinishTime = reader.GetValue(reader.GetOrdinal("FirstFinishTime")).ToString();
            timeSlot.FirstStartTime = reader.GetValue(reader.GetOrdinal("FirstStartTime")).ToString();
            timeSlot.fk_EighthSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_EighthSectionFare")).ToString());
            timeSlot.fk_FifthSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_FifthSectionFare")).ToString());
            timeSlot.fk_FirstSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_FirstSectionFare")).ToString());
            timeSlot.fk_FourthSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_FourthSectionFare")).ToString());
            timeSlot.fk_SecondSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SecondSectionFare")).ToString());
            timeSlot.fk_SeventhSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SeventhSectionFare")).ToString());
            timeSlot.fk_SixthSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_SixthSectionFare")).ToString());
            timeSlot.fk_ThirdSectionFare = short.Parse(reader.GetValue(reader.GetOrdinal("fk_ThirdSectionFare")).ToString());
            timeSlot.fk_WeekDayID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_WeekDayID")).ToString());
            timeSlot.fk_TimeSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("fk_TimeSlotProfileID")).ToString());
            timeSlot.FourthFinishTime = reader.GetValue(reader.GetOrdinal("FourthFinishTime")).ToString();
            timeSlot.FourthStartTime = reader.GetValue(reader.GetOrdinal("FourthStartTime")).ToString();
            timeSlot.SecondFinishTime = reader.GetValue(reader.GetOrdinal("SecondFinishTime")).ToString();
            timeSlot.SecondStartTime = reader.GetValue(reader.GetOrdinal("SecondStartTime")).ToString();
            timeSlot.SeventhFinishTime = reader.GetValue(reader.GetOrdinal("SeventhFinishTime")).ToString();
            timeSlot.SeventhStartTime = reader.GetValue(reader.GetOrdinal("SeventhStartTime")).ToString();
            timeSlot.SixthFinishTime = reader.GetValue(reader.GetOrdinal("SixthFinishTime")).ToString();
            timeSlot.SixthStartTime = reader.GetValue(reader.GetOrdinal("SixthStartTime")).ToString();
            timeSlot.ThirdFinishTime = reader.GetValue(reader.GetOrdinal("ThirdFinishTime")).ToString();
            timeSlot.ThirdStartTime = reader.GetValue(reader.GetOrdinal("ThirdStartTime")).ToString();

            return timeSlot;
        }
        private TimeSlotProfile FillEntityTimeSlotProfile(IDataReader reader)
        {
            TimeSlotProfile timeSlotProfile = new TimeSlotProfile();
            timeSlotProfile.TimeSlotProfileID = short.Parse(reader.GetValue(reader.GetOrdinal("TimeSlotProfileID")).ToString());
            timeSlotProfile.TimeSlotProfileName = reader.GetValue(reader.GetOrdinal("TimeSlotProfileName")).ToString();

            return timeSlotProfile;
        }

        public List<global::Common.TimeSlotProfile> GetList()
        {
            List<TimeSlotProfile> list = new List<TimeSlotProfile>();
            List<TimeSlot> timeSlotList = new List<TimeSlot>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTimeSlotProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityTimeSlotProfile(reader));
                    reader.Close();

                    SqlCommand commandtimeSlot = new SqlCommand("Ticket.NFPspTimeSlotGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    commandtimeSlot.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader readertimeSlot = commandtimeSlot.ExecuteReader();

                    while (readertimeSlot.Read())
                        timeSlotList.Add(FillEntityTimeSlot(readertimeSlot));
                    reader.Close();

                    foreach (TimeSlotProfile timeSlotProfile in list)
                    {
                        List<TimeSlot> matched = new List<TimeSlot>();
                        foreach (TimeSlot timeSlot in timeSlotList) 
                        {
                            if (timeSlot.fk_TimeSlotProfileID == timeSlotProfile.TimeSlotProfileID)
                                matched.Add(timeSlot);
                        }
                        timeSlotProfile.TimeSlots = matched;
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTimeSlotProfileGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntityTimeSlotProfile(reader));
                    reader.Close();

                    OleDbCommand commandtimeSlot = new OleDbCommand("Ticket.NFPspTimeSlotGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    commandtimeSlot.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader readertimeSlot = command.ExecuteReader();

                    while (readertimeSlot.Read())
                        timeSlotList.Add(FillEntityTimeSlot(readertimeSlot));
                    reader.Close();

                    foreach (TimeSlotProfile timeSlotProfile in list)
                    {
                        List<TimeSlot> matched = new List<TimeSlot>();
                        foreach (TimeSlot timeSlot in timeSlotList)
                        {
                            if (timeSlot.fk_TimeSlotProfileID == timeSlotProfile.TimeSlotProfileID)
                                matched.Add(timeSlot);
                        }
                        timeSlotProfile.TimeSlots = matched;
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

        public int InsertTimeSlotProfile(global::Common.TimeSlotProfile timeSlotProfile)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTimeSlotProfileInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TimeSlotProfileName", SqlDbType.NVarChar, 50).Value = timeSlotProfile.TimeSlotProfileName;
                    
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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTimeSlotProfileInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TimeSlotProfileName", OleDbType.VarChar, 50).Value = timeSlotProfile.TimeSlotProfileName;

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

        public int InsertTimeSlot(global::Common.TimeSlot timeSlot)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTimeSlotInsert", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@EighthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.EighthFinishTime;
                    command.Parameters.Add("@EighthStartTime", SqlDbType.NChar, 5).Value = timeSlot.EighthStartTime;
                    command.Parameters.Add("@FifthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FifthFinishTime;
                    command.Parameters.Add("@FifthStartTime", SqlDbType.NChar, 5).Value = timeSlot.FifthStartTime;
                    command.Parameters.Add("@FirstFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FirstFinishTime;
                    command.Parameters.Add("@FirstStartTime", SqlDbType.NChar, 5).Value = timeSlot.FirstStartTime;
                    command.Parameters.Add("@fk_EighthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_EighthSectionFare;
                    command.Parameters.Add("@fk_FifthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FifthSectionFare;
                    command.Parameters.Add("@fk_FirstSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FirstSectionFare;
                    command.Parameters.Add("@fk_FourthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FourthSectionFare;
                    command.Parameters.Add("@fk_SecondSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SecondSectionFare;
                    command.Parameters.Add("@fk_SeventhSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SeventhSectionFare;
                    command.Parameters.Add("@fk_SixthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SixthSectionFare;
                    command.Parameters.Add("@fk_ThirdSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_ThirdSectionFare;
                    command.Parameters.Add("@fk_TimeSlotProfileID", SqlDbType.SmallInt).Value = timeSlot.fk_TimeSlotProfileID;
                    command.Parameters.Add("@fk_WeekDayID", SqlDbType.SmallInt).Value = timeSlot.fk_WeekDayID;
                    command.Parameters.Add("@FourthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FourthFinishTime;
                    command.Parameters.Add("@FourthStartTime", SqlDbType.NChar, 5).Value = timeSlot.FourthStartTime;
                    command.Parameters.Add("@SecondFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SecondFinishTime;
                    command.Parameters.Add("@SecondStartTime", SqlDbType.NChar, 5).Value = timeSlot.SecondStartTime;
                    command.Parameters.Add("@SeventhFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SeventhFinishTime;
                    command.Parameters.Add("@SeventhStartTime", SqlDbType.NChar, 5).Value = timeSlot.SeventhStartTime;
                    command.Parameters.Add("@SixthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SixthFinishTime;
                    command.Parameters.Add("@SixthStartTime", SqlDbType.NChar, 5).Value = timeSlot.SixthStartTime;
                    command.Parameters.Add("@ThirdFinishTime", SqlDbType.NChar, 5).Value = timeSlot.ThirdFinishTime;
                    command.Parameters.Add("@ThirdStartTime", SqlDbType.NChar, 5).Value = timeSlot.ThirdStartTime;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTimeSlotInsert", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@EighthFinishTime", OleDbType.Char, 5).Value = timeSlot.EighthFinishTime;
                    command.Parameters.Add("@EighthStartTime", OleDbType.Char, 5).Value = timeSlot.EighthStartTime;
                    command.Parameters.Add("@FifthFinishTime", OleDbType.Char, 5).Value = timeSlot.FifthFinishTime;
                    command.Parameters.Add("@FifthStartTime", OleDbType.Char, 5).Value = timeSlot.FifthStartTime;
                    command.Parameters.Add("@FirstFinishTime", OleDbType.Char, 5).Value = timeSlot.FirstFinishTime;
                    command.Parameters.Add("@FirstStartTime", OleDbType.Char, 5).Value = timeSlot.FirstStartTime;
                    command.Parameters.Add("@fk_EighthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_EighthSectionFare;
                    command.Parameters.Add("@fk_FifthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FifthSectionFare;
                    command.Parameters.Add("@fk_FirstSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FirstSectionFare;
                    command.Parameters.Add("@fk_FourthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FourthSectionFare;
                    command.Parameters.Add("@fk_SecondSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SecondSectionFare;
                    command.Parameters.Add("@fk_SeventhSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SeventhSectionFare;
                    command.Parameters.Add("@fk_SixthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SixthSectionFare;
                    command.Parameters.Add("@fk_ThirdSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_ThirdSectionFare;
                    command.Parameters.Add("@fk_TimeSlotProfileID", OleDbType.SmallInt).Value = timeSlot.fk_TimeSlotProfileID;
                    command.Parameters.Add("@fk_WeekDayID", OleDbType.SmallInt).Value = timeSlot.fk_WeekDayID;
                    command.Parameters.Add("@FourthFinishTime", OleDbType.Char, 5).Value = timeSlot.FourthFinishTime;
                    command.Parameters.Add("@FourthStartTime", OleDbType.Char, 5).Value = timeSlot.FourthStartTime;
                    command.Parameters.Add("@SecondFinishTime", OleDbType.Char, 5).Value = timeSlot.SecondFinishTime;
                    command.Parameters.Add("@SecondStartTime", OleDbType.Char, 5).Value = timeSlot.SecondStartTime;
                    command.Parameters.Add("@SeventhFinishTime", OleDbType.Char, 5).Value = timeSlot.SeventhFinishTime;
                    command.Parameters.Add("@SeventhStartTime", OleDbType.Char, 5).Value = timeSlot.SeventhStartTime;
                    command.Parameters.Add("@SixthFinishTime", OleDbType.Char, 5).Value = timeSlot.SixthFinishTime;
                    command.Parameters.Add("@SixthStartTime", OleDbType.Char, 5).Value = timeSlot.SixthStartTime;
                    command.Parameters.Add("@ThirdFinishTime", OleDbType.Char, 5).Value = timeSlot.ThirdFinishTime;
                    command.Parameters.Add("@ThirdStartTime", OleDbType.Char, 5).Value = timeSlot.ThirdStartTime;

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

        public int UpdateTimeSlot(global::Common.TimeSlot timeSlot, short oldfk_WeekDayID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTimeSlotUpdate", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@EighthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.EighthFinishTime;
                    command.Parameters.Add("@EighthStartTime", SqlDbType.NChar, 5).Value = timeSlot.EighthStartTime;
                    command.Parameters.Add("@FifthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FifthFinishTime;
                    command.Parameters.Add("@FifthStartTime", SqlDbType.NChar, 5).Value = timeSlot.FifthStartTime;
                    command.Parameters.Add("@FirstFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FirstFinishTime;
                    command.Parameters.Add("@FirstStartTime", SqlDbType.NChar, 5).Value = timeSlot.FirstStartTime;
                    command.Parameters.Add("@fk_EighthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_EighthSectionFare;
                    command.Parameters.Add("@fk_FifthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FifthSectionFare;
                    command.Parameters.Add("@fk_FirstSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FirstSectionFare;
                    command.Parameters.Add("@fk_FourthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_FourthSectionFare;
                    command.Parameters.Add("@fk_SecondSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SecondSectionFare;
                    command.Parameters.Add("@fk_SeventhSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SeventhSectionFare;
                    command.Parameters.Add("@fk_SixthSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_SixthSectionFare;
                    command.Parameters.Add("@fk_ThirdSectionFare", SqlDbType.SmallInt).Value = timeSlot.fk_ThirdSectionFare;
                    command.Parameters.Add("@fk_TimeSlotProfileID", SqlDbType.SmallInt).Value = timeSlot.fk_TimeSlotProfileID;
                    command.Parameters.Add("@fk_WeekDayID", SqlDbType.SmallInt).Value = timeSlot.fk_WeekDayID;
                    command.Parameters.Add("@oldfk_WeekDayID", SqlDbType.SmallInt).Value = oldfk_WeekDayID;
                    command.Parameters.Add("@FourthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.FourthFinishTime;
                    command.Parameters.Add("@FourthStartTime", SqlDbType.NChar, 5).Value = timeSlot.FourthStartTime;
                    command.Parameters.Add("@SecondFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SecondFinishTime;
                    command.Parameters.Add("@SecondStartTime", SqlDbType.NChar, 5).Value = timeSlot.SecondStartTime;
                    command.Parameters.Add("@SeventhFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SeventhFinishTime;
                    command.Parameters.Add("@SeventhStartTime", SqlDbType.NChar, 5).Value = timeSlot.SeventhStartTime;
                    command.Parameters.Add("@SixthFinishTime", SqlDbType.NChar, 5).Value = timeSlot.SixthFinishTime;
                    command.Parameters.Add("@SixthStartTime", SqlDbType.NChar, 5).Value = timeSlot.SixthStartTime;
                    command.Parameters.Add("@ThirdFinishTime", SqlDbType.NChar, 5).Value = timeSlot.ThirdFinishTime;
                    command.Parameters.Add("@ThirdStartTime", SqlDbType.NChar, 5).Value = timeSlot.ThirdStartTime;

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
                    OleDbCommand command = new OleDbCommand("Network.NFPspTimeSlotUpdate", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@EighthFinishTime", OleDbType.Char, 5).Value = timeSlot.EighthFinishTime;
                    command.Parameters.Add("@EighthStartTime", OleDbType.Char, 5).Value = timeSlot.EighthStartTime;
                    command.Parameters.Add("@FifthFinishTime", OleDbType.Char, 5).Value = timeSlot.FifthFinishTime;
                    command.Parameters.Add("@FifthStartTime", OleDbType.Char, 5).Value = timeSlot.FifthStartTime;
                    command.Parameters.Add("@FirstFinishTime", OleDbType.Char, 5).Value = timeSlot.FirstFinishTime;
                    command.Parameters.Add("@FirstStartTime", OleDbType.Char, 5).Value = timeSlot.FirstStartTime;
                    command.Parameters.Add("@fk_EighthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_EighthSectionFare;
                    command.Parameters.Add("@fk_FifthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FifthSectionFare;
                    command.Parameters.Add("@fk_FirstSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FirstSectionFare;
                    command.Parameters.Add("@fk_FourthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_FourthSectionFare;
                    command.Parameters.Add("@fk_SecondSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SecondSectionFare;
                    command.Parameters.Add("@fk_SeventhSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SeventhSectionFare;
                    command.Parameters.Add("@fk_SixthSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_SixthSectionFare;
                    command.Parameters.Add("@fk_ThirdSectionFare", OleDbType.SmallInt).Value = timeSlot.fk_ThirdSectionFare;
                    command.Parameters.Add("@fk_TimeSlotProfileID", OleDbType.SmallInt).Value = timeSlot.fk_TimeSlotProfileID;
                    command.Parameters.Add("@fk_WeekDayID", OleDbType.SmallInt).Value = timeSlot.fk_WeekDayID;
                    command.Parameters.Add("@oldfk_WeekDayID", OleDbType.SmallInt).Value = oldfk_WeekDayID;
                    command.Parameters.Add("@FourthFinishTime", OleDbType.Char, 5).Value = timeSlot.FourthFinishTime;
                    command.Parameters.Add("@FourthStartTime", OleDbType.Char, 5).Value = timeSlot.FourthStartTime;
                    command.Parameters.Add("@SecondFinishTime", OleDbType.Char, 5).Value = timeSlot.SecondFinishTime;
                    command.Parameters.Add("@SecondStartTime", OleDbType.Char, 5).Value = timeSlot.SecondStartTime;
                    command.Parameters.Add("@SeventhFinishTime", OleDbType.Char, 5).Value = timeSlot.SeventhFinishTime;
                    command.Parameters.Add("@SeventhStartTime", OleDbType.Char, 5).Value = timeSlot.SeventhStartTime;
                    command.Parameters.Add("@SixthFinishTime", OleDbType.Char, 5).Value = timeSlot.SixthFinishTime;
                    command.Parameters.Add("@SixthStartTime", OleDbType.Char, 5).Value = timeSlot.SixthStartTime;
                    command.Parameters.Add("@ThirdFinishTime", OleDbType.Char, 5).Value = timeSlot.ThirdFinishTime;
                    command.Parameters.Add("@ThirdStartTime", OleDbType.Char, 5).Value = timeSlot.ThirdStartTime;

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

        public int DeleteTimeSlotProfile(int timeSlotProfileID)
        {
            int result = 0;
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection sqlConnection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {
                    SqlCommand command = new SqlCommand("Ticket.NFPspTimeSlotProfileDelete", sqlConnection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TimeSlotProfileID", SqlDbType.SmallInt).Value = timeSlotProfileID;

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
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspTimeSlotProfileDelete", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@TimeSlotProfileID", OleDbType.SmallInt).Value = timeSlotProfileID;

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
