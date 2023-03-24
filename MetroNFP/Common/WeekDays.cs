using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class WeekDays
    {
        private short weekDayID;
        public short WeekDayID
        {
            get
            {
                return weekDayID;
            }
            set
            {
                weekDayID = value;
            }
        }

        private string weekDayName;
        public string WeekDayName
        {
            get
            {
                return weekDayName;
            }
            set
            {
                weekDayName = value;
            }
        }
    }
}
