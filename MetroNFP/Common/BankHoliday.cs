using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class BankHoliday
    {
        public BankHoliday()
        {
            this.bankHolidayID = 0;
            this.bankHolidayName = String.Empty;
            this.date = String.Empty;
        }
        public BankHoliday(short bankHolidayID, string bankHolidayName, string date)
        {
            this.bankHolidayID = bankHolidayID;
            this.bankHolidayName = bankHolidayName;
            this.date = date;
        }

        private short bankHolidayID;
        public short BankHolidayID
        {
            get
            {
                return bankHolidayID;
            }
            set
            {
                bankHolidayID = value;
            }
        }

        private string bankHolidayName;
        public string BankHolidayName
        {
            get
            {
                return bankHolidayName;
            }
            set
            {
                bankHolidayName = value;
            }
        }

        private string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}
