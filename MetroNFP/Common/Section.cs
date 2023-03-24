using System;
using System.Collections.Generic;

namespace Common {
	public class Section {
        public Section()
        {
            StationID = 0;
            Name = String.Empty;
            ShortName = String.Empty;
            Destinations = new List<Station>();
        }
        public Section(int stationID, string name, string shortName, List<Station> destinations)
        {
            StationID = stationID;
            Name = name;
            ShortName = shortName;
            Destinations = destinations;
        }

        private int stationID;
        public int StationID
        {
            get
            {
                return stationID;
            }
            set
            {
                stationID = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string shortName;
        public string ShortName
        {
            get
            {
                return shortName;
            }
            set
            {
                shortName = value;
            }
        }
        private List<Station> destinations;
		public List<Station> Destinations {
			get {
				return destinations;
			}
			set {
				destinations = value;
			}
		}
	}
}
