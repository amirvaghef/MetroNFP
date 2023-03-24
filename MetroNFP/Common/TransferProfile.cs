using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class TransferProfile
    {
        public TransferProfile()
        {
            transferProfileID = 0;
            transferProfileName = "";
            maxNumberOfTravelInDay = 0;
            travelMaxDuration = 0;
            multiUsersNumber = 0;
            antiPassBack = 0;
        }
        public TransferProfile(short id, string name, short maxTravel, short maxDuration, short multiUsers, short passBack)
        {
            transferProfileID = id;
            transferProfileName = name;
            maxNumberOfTravelInDay = maxTravel;
            travelMaxDuration = maxDuration;
            multiUsersNumber = multiUsers;
            antiPassBack = passBack;
        }

        private short transferProfileID;
        public short TransferProfileID
        {
            get
            {
                return transferProfileID;
            }
            set
            {
                transferProfileID = value;
            }
        }

        private string transferProfileName;
        public string TransferProfileName
        {
            get
            {
                return transferProfileName;
            }
            set
            {
                transferProfileName = value;
            }
        }

        private short maxNumberOfTravelInDay;
        public short MaxNumberOfTravelInDay
        {
            get
            {
                return maxNumberOfTravelInDay;
            }
            set
            {
                maxNumberOfTravelInDay = value;
            }
        }

        private short travelMaxDuration;
        public short TravelMaxDuration
        {
            get
            {
                return travelMaxDuration;
            }
            set
            {
                travelMaxDuration = value;
            }
        }

        private short multiUsersNumber;
        public short MultiUsersNumber
        {
            get
            {
                return multiUsersNumber;
            }
            set
            {
                multiUsersNumber = value;
            }
        }

        private short antiPassBack;
        public short AntiPassBack
        {
            get
            {
                return antiPassBack;
            }
            set
            {
                antiPassBack = value;
            }
        }
    }
}
