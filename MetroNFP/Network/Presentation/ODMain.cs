using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network.BusinnesLogic;
using Common;

namespace Network.Presentation
{
    public partial class ODMain : Form
    {
        List<Section> sections = new List<Section>();
        public ODMain()
        {
            InitializeComponent();
            
            sections = new SectionBL().GetList();
            gridEXOriginStations.DataSource = sections;
        }

        private void gridEXOriginStations_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXOriginStations.Row >= 0)
            {
                int originStationID = int.Parse(gridEXOriginStations.GetRow().Cells["OriginStationID"].Text);
                foreach (Section section in sections)
                    if (section.StationID == originStationID)
                    {
                        gridEXDestinationStations.DataSource = section.Destinations;
                        break;
                    }
            }
        }

        private void gridEXDestinationStations_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<Station> destinations = new List<Station>();
            destinations.Add(new Station(int.Parse(gridEXDestinationStations.GetRow().Cells["DestinationStationID"].Text), "", "", 0, int.Parse(gridEXDestinationStations.GetRow().Cells["SectionNumber"].Text)));
            Section section = new Section(int.Parse(gridEXOriginStations.GetRow().Cells["OriginStationID"].Text), "", "", destinations);

            SectionBL sectionBL = new SectionBL();
            sectionBL.Update(section);
            sections = sectionBL.GetList();
        }
    }
}
