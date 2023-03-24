using System;
using System.Collections.Generic;

namespace Common
{
    public class TimeSlotProfile
    {
        private short timeSlotProfileID;
        public short TimeSlotProfileID
        {
            get
            {
                return timeSlotProfileID;
            }
            set
            {
                timeSlotProfileID = value;
            }
        }

        private string timeSlotProfileName;
        public string TimeSlotProfileName
        {
            get
            {
                return timeSlotProfileName;
            }
            set
            {
                timeSlotProfileName = value;
            }
        }

        private List<TimeSlot> timeSlots;
        public List<TimeSlot> TimeSlots
        {
            get
            {
                return timeSlots;
            }
            set
            {
                timeSlots = value;
            }
        }
    }
}
