using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public class Utility
    {
        public static string RefineText(string txt)
        {
            //return txt.Replace("ى", "ي").Replace("ک", "ك").Replace("ى", "ي");
            Encoding encoding1256 = Encoding.GetEncoding(1256);
            byte[] inputStrBuf = encoding1256.GetBytes(txt);
            byte[] inputStrUtf8Buf = Encoding.Convert(encoding1256, Encoding.UTF8, inputStrBuf);
            string dest = Encoding.GetEncoding("utf-8").GetString(inputStrUtf8Buf);

            return dest;
        }

        public static bool Exist(Object list, string str, string fieldName)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (list.GetType() == typeof(List<Station>))
                {
                    List<Station> stations = (List<Station>)list;
                    switch (fieldName)
                    {
                        case "StationID":
                            foreach (Station station in stations)
                            {
                                if (station.StationID.ToString() == str)
                                    return true;
                            }
                            break;

                        case "Name":
                            foreach (Station station in stations)
                            {
                                if (station.Name.ToLower() == str.ToLower())
                                    return true;
                            }
                            break;

                        case "ShortName":
                            foreach (Station station in stations)
                            {
                                if (station.ShortName.ToLower() == str.ToLower())
                                    return true;
                            }
                            break;

                        case "Sequence":
                            foreach (Station station in stations)
                            {
                                if (station.Sequence.ToString() == str)
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<RailRoad>))
                {
                    List<RailRoad> railRoads = (List<RailRoad>)list;
                    switch (fieldName)
                    {
                        case "Name":
                            foreach (RailRoad railRoad in railRoads)
                            {
                                if (railRoad.Name.ToLower() == str.ToLower())
                                    return true;
                            }
                            break;

                        case "ShortName":
                            foreach (RailRoad railRoad in railRoads)
                            {
                                if (railRoad.ShortName.ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<SectionFareProfile>))
                {
                    List<SectionFareProfile> sectionFareProfiles = (List<SectionFareProfile>)list;
                    switch (fieldName)
                    {
                        case "SectionFareProfileName":
                            foreach (SectionFareProfile sectionFareProfile in sectionFareProfiles)
                            {
                                if (sectionFareProfile.SectionFareProfileName.ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<SectionFare>))
                {
                    List<SectionFare> sectionFares = (List<SectionFare>)list;
                    switch (fieldName)
                    {
                        case "SectionNumber":
                            foreach (SectionFare sectionFare in sectionFares)
                            {
                                if (sectionFare.SectionNumber.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<DiscountRefundProfile>))
                {
                    List<DiscountRefundProfile> discountRefundProfiles = (List<DiscountRefundProfile>)list;
                    switch (fieldName)
                    {
                        case "DiscountRefundProfileName":
                            foreach (DiscountRefundProfile discountRefundProfile in discountRefundProfiles)
                            {
                                if (discountRefundProfile.DiscountRefundProfileName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<ReaderMessage>))
                {
                    List<ReaderMessage> readerMessages = (List<ReaderMessage>)list;
                    switch (fieldName)
                    {
                        case "ReaderMessageName":
                            foreach (ReaderMessage readerMessage in readerMessages)
                            {
                                if (readerMessage.ReaderMessageName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<PRDMessage>))
                {
                    List<PRDMessage> prdMessages = (List<PRDMessage>)list;
                    switch (fieldName)
                    {
                        case "PRDMessageName":
                            foreach (PRDMessage prdMessage in prdMessages)
                            {
                                if (prdMessage.PRDMessageName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<Fine>))
                {
                    List<Fine> fines = (List<Fine>)list;
                    switch (fieldName)
                    {
                        case "FineName":
                            foreach (Fine fine in fines)
                            {
                                if (fine.FineName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<TransferProfile>))
                {
                    List<TransferProfile> transferProfiles = (List<TransferProfile>)list;
                    switch (fieldName)
                    {
                        case "TransferProfileName":
                            foreach (TransferProfile transferProfile in transferProfiles)
                            {
                                if (transferProfile.TransferProfileName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<RejectCode>))
                {
                    List<RejectCode> rejectCodes = (List<RejectCode>)list;
                    switch (fieldName)
                    {
                        case "RejectCodeName":
                            foreach (RejectCode rejectCode in rejectCodes)
                            {
                                if (rejectCode.RejectCodeName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<ProcessingAlgorithmProfile>))
                {
                    List<ProcessingAlgorithmProfile> processingAlgorithmProfiles = (List<ProcessingAlgorithmProfile>)list;
                    switch (fieldName)
                    {
                        case "ProcessingAlgorithmProfileName":
                            foreach (ProcessingAlgorithmProfile processingAlgorithmProfile in processingAlgorithmProfiles)
                            {
                                if (processingAlgorithmProfile.ProcessingAlgorithmProfileName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<Ticket>))
                {
                    List<Ticket> tickets = (List<Ticket>)list;
                    switch (fieldName)
                    {
                        case "TicketName":
                            foreach (Ticket ticket in tickets)
                            {
                                if (ticket.TicketName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;

                        case "TicketShortName":
                            foreach (Ticket ticket in tickets)
                            {
                                if (ticket.TicketShortName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<ProcessingAlgorithm>))
                {
                    List<ProcessingAlgorithm> processingAlgorithms = (List<ProcessingAlgorithm>)list;
                    switch (fieldName)
                    {
                        case "Sequence":
                            foreach (ProcessingAlgorithm processingAlgorithm in processingAlgorithms)
                            {
                                if (processingAlgorithm.Sequence.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;

                        case "fk_ProcessingAlgorithmOperationKindID":
                            foreach (ProcessingAlgorithm processingAlgorithm in processingAlgorithms)
                            {
                                if (processingAlgorithm.fk_ProcessingAlgorithmOperationKindID.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<TimeSlotProfile>))
                {
                    List<TimeSlotProfile> timeSlotProfiles = (List<TimeSlotProfile>)list;
                    switch (fieldName)
                    {
                        case "TimeSlotProfileName":
                            foreach (TimeSlotProfile timeSlotProfile in timeSlotProfiles)
                            {
                                if (timeSlotProfile.TimeSlotProfileName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<PrintingProfile>))
                {
                    List<PrintingProfile> printingProfiles = (List<PrintingProfile>)list;
                    switch (fieldName)
                    {
                        case "PrintingProfileName":
                            foreach (PrintingProfile printingProfile in printingProfiles)
                            {
                                if (printingProfile.PrintingProfileName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<SchoolHoliday>))
                {
                    List<SchoolHoliday> schoolHolidays = (List<SchoolHoliday>)list;
                    switch (fieldName)
                    {
                        case "SchoolHolidayName":
                            foreach (SchoolHoliday schoolHoliday in schoolHolidays)
                            {
                                if (schoolHoliday.SchoolHolidayName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                if (list.GetType() == typeof(List<BankHoliday>))
                {
                    List<BankHoliday> bankHolidays = (List<BankHoliday>)list;
                    switch (fieldName)
                    {
                        case "BankHolidayName":
                            foreach (BankHoliday bankHoliday in bankHolidays)
                            {
                                if (bankHoliday.BankHolidayName.ToString().ToLower() == str.ToLower())
                                    return true;
                            }
                            break;
                    }
                    return false;
                }

                return true;
            }
            else
                return true;
        }
    }
}
