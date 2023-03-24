using System;
using System.Collections.Generic;

namespace Common
{
    public class SectionFareProfile
    {
        public SectionFareProfile()
        {
            sectionFareProfileID = 0;
            sectionFareProfileName = String.Empty;
            sectionFares = new List<SectionFare>();
        }

        public SectionFareProfile(short lsectionFareProfileID, string lsectionFareProfileName, List<SectionFare> lsectionFares)
        {
            sectionFareProfileID = lsectionFareProfileID;
            sectionFareProfileName = lsectionFareProfileName;
            sectionFares = lsectionFares;
        }

        private short sectionFareProfileID;
        public short SectionFareProfileID
        {
            get
            {
                return sectionFareProfileID;
            }
            set
            {
                sectionFareProfileID = value;
            }
        }

        private string sectionFareProfileName;
        public string SectionFareProfileName
        {
            get
            {
                return sectionFareProfileName;
            }
            set
            {
                sectionFareProfileName = value;
            }
        }

        private List<SectionFare> sectionFares;
        public List<SectionFare> SectionFares
        {
            get
            {
                return sectionFares;
            }
            set
            {
                sectionFares = value;
            }
        }
    }
}
