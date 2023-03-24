using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class SchoolHoliday
    {
        public SchoolHoliday()
        {
            this.schoolHolidayID = 0;
            this.schoolHolidayName = String.Empty;
            this.fromDate = String.Empty;
            this.untilDate = String.Empty;
        }

        public SchoolHoliday(short schoolHolidayID, string schoolHolidayName, string fromDate, string untilDate)
        {
            this.schoolHolidayID = schoolHolidayID;
            this.schoolHolidayName = schoolHolidayName;
            this.fromDate = fromDate;
            this.untilDate = untilDate;
        }

        private short schoolHolidayID;
        public short SchoolHolidayID
        {
            get
            {
                return schoolHolidayID;
            }
            set
            {
                schoolHolidayID = value;
            }
        }

        private string schoolHolidayName;
        public string SchoolHolidayName
        {
            get
            {
                return schoolHolidayName;
            }
            set
            {
                schoolHolidayName = value;
            }
        }

        private string fromDate;
        public string FromDate
        {
            get
            {
                return fromDate;
            }
            set
            {
                fromDate = value;
            }
        }

        private string untilDate;
        public string UntilDate
        {
            get
            {
                return untilDate;
            }
            set
            {
                untilDate = value;
            }
        }
    }
}
