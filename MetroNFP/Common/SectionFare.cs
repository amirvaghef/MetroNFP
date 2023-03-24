using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class SectionFare
    {
        public SectionFare()
        {
            sectionNumber = 0;
            fare1 = 0;
            fare2 = 0;
        }

        public SectionFare(int lsectionNumber, double lfare1, double lfare2)
        {
            sectionNumber = lsectionNumber;
            fare1 = lfare1;
            fare2 = lfare2;
        }

        private int sectionNumber;
        public int SectionNumber
        {
            get
            {
                return sectionNumber;
            }
            set
            {
                sectionNumber = value;
            }
        }

        private double fare1;
        public double Fare1
        {
            get
            {
                return fare1;
            }
            set
            {
                fare1 = value;
            }
        }

        private double fare2;
        public double Fare2
        {
            get
            {
                return fare2;
            }
            set
            {
                fare2 = value;
            }
        }
    }
}
