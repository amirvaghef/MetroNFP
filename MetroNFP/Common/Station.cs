using System;
namespace Common {
	public class Station {
        public Station()
        {
            StationID = 0;
            Name = String.Empty;
            ShortName = String.Empty;
            Sequence = 0;
            SectionNumber = 0;
        }
        public Station(int stationID, string name, string shortName, int sequence, int sectionNumber)
        {
            StationID = stationID;
            Name = name;
            ShortName = shortName;
            Sequence = sequence;
            SectionNumber = sectionNumber;
        }
		
        private int stationID;
		public int StationID {
			get {
				return stationID;
			}
			set {
				stationID = value;
			}
		}
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		private string shortName;
		public string ShortName {
			get {
				return shortName;
			}
			set {
				shortName = value;
			}
		}
		private int sequence;
		public int Sequence {
			get {
				return sequence;
			}
			set {
				sequence = value;
			}
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
	}
}
