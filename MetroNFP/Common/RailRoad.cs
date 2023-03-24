using System;
using System.Collections.Generic;

namespace Common {
	public class RailRoad {

        public RailRoad()
        {
            RailRoadID = 0;
            Name = "";
            ShortName = "";
            Stations = new List<Station>();
        }
        public RailRoad(int railRoadID, string name, string shortName, List<Station> stations)
        {
            RailRoadID = railRoadID;
            Name = name;
            ShortName = shortName;
            Stations = stations;
        }

		private int railRoadID;
		public int RailRoadID {
			get {
				return railRoadID;
			}
			set {
				railRoadID = value;
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
		private List<Station> stations;
        public List<Station> Stations
        {
			get {
				return stations;
			}
			set {
				stations = value;
			}
		}
	}
}
