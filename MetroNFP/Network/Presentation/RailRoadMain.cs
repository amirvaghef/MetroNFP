using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Network.BusinnesLogic;
using Common;
using Common.Utility;

namespace Network.Presentation
{
    public partial class RailRoadMain : Form
    {
        List<RailRoad> railRoads = new List<RailRoad>();
        List<Station> railRoadStations = new List<Station>();
        public RailRoadMain()
        {
            InitializeComponent();

            FillStationList();
            BindRailRoadData();
        }
        private void BindRailRoadData()
        {
            railRoads = new RailRoadBL().GetList();
            gridEXRailRoad.DataSource = railRoads;
        }
        private void FillStationList()
        {
            gridEXStation.DropDowns["Stations"].SetDataBinding(new StationBL().GetList(), "");
            gridEXStation.DropDowns["Stations"].KeepRowSettings = false;
            gridEXStation.DropDowns["Stations"].ReplaceValues = true;
        }

        #region RailRoad Grid
        private void gridEX1_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXRailRoad.Row >= 0)
            {
                if (!String.IsNullOrWhiteSpace(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text))
                {
                    int railRoadID = int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text);
                    foreach (RailRoad railRoad in railRoads)
                        if (railRoad.RailRoadID == railRoadID)
                        {
                            railRoadStations = railRoad.Stations;
                            gridEXStation.DataSource = railRoadStations;
                            break;
                        }
                }
            }
        }

        private void gridEX1_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(railRoads, Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadName"].Text), "Name"))
            {
                if (!Utility.Exist(railRoads, Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadShortName"].Text), "ShortName"))
                {
                    RailRoad railRoad = new RailRoad(0, Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadName"].Text), Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadShortName"].Text), null);
                    RailRoadBL railRoadBL = new RailRoadBL();
                    railRoadBL.InsertRailRoad(railRoad);
                }
                else
                {
                    NFPMessageBox.Show("لطفاً نام مختصر مسیر را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                    e.Cancel = true;
                }
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام مسیر را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXRailRoad_RecordAdded(object sender, EventArgs e)
        {
            BindRailRoadData();
        }

        private void gridEX1_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<RailRoad> railRoadsTemp = railRoads.GetRange(0, railRoads.Count);
            for (int i = 0; i < railRoadsTemp.Count; i++)
                if (railRoadsTemp[i].RailRoadID == int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text))
                    railRoadsTemp.RemoveAt(i);

            if (!Utility.Exist(railRoadsTemp, Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadName"].Text), "Name"))
            {
                if (!Utility.Exist(railRoadsTemp, Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadShortName"].Text), "ShortName"))
                {
                    RailRoad railRoad = new RailRoad(int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text), Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadName"].Text), Utility.RefineText(gridEXRailRoad.GetRow().Cells["RailRoadShortName"].Text), null);
                    RailRoadBL railRoadBL = new RailRoadBL();
                    railRoadBL.UpdateRailRoad(railRoad);

                    railRoads = railRoadBL.GetList();
                }
                else
                {
                    NFPMessageBox.Show("لطفاً نام مختصر مسیر را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                    e.Cancel = true;
                }
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام مسیر را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXRailRoad_DeletingRecords(object sender, CancelEventArgs e)
        {
            RailRoadBL railRoadBL = new RailRoadBL();

            railRoadBL.DeleteRailRoad(int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text));
            railRoads = railRoadBL.GetList();
        }
        #endregion

        #region Station Grid
        private void gridEXStation_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(railRoadStations, gridEXStation.GetRow().Cells["StationID"].Value.ToString(), "StationID"))
            {
                if (!Utility.Exist(railRoadStations, gridEXStation.GetRow().Cells["Sequence"].Text, "Sequence"))
                {
                    List<Station> stations = new List<Station>();
                    stations.Add(new Station(int.Parse(gridEXStation.GetRow().Cells["StationID"].Value.ToString()), "", "", int.Parse(gridEXStation.GetRow().Cells["Sequence"].Text), 0));
                    List<RailRoad> railRoadList = new List<RailRoad>();
                    railRoadList.Add(new RailRoad(int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text), "", "", stations));
                    new RailRoadBL().InsertStationRailRoad(railRoadList);
                }
                else
                {
                    NFPMessageBox.Show("لطفاً شماره ترتیب ایستگاه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                    e.Cancel = true;
                }
            }
            else
            {
                NFPMessageBox.Show("لطفاً ایستگاه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXStation_RecordAdded(object sender, EventArgs e)
        {
            RailRoadBL railRoadBL = new RailRoadBL();

            railRoads = railRoadBL.GetList();
            foreach (RailRoad railRoad in railRoads)
                if (railRoad.RailRoadID == int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text))
                {
                    railRoadStations = railRoad.Stations;
                    gridEXStation.DataSource = railRoad.Stations;
                    break;
                }
        }

        private void gridEXStation_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<Station> railRoadStationsTemp = railRoadStations.GetRange(0, railRoadStations.Count);
            for (int i = 0; i < railRoadStationsTemp.Count; i++)
                if (railRoadStationsTemp[i].StationID == int.Parse(gridEXStation.GetRow().Cells["oldStationID"].Text))
                    railRoadStationsTemp.RemoveAt(i);

            if (!Utility.Exist(railRoadStationsTemp, gridEXStation.GetRow().Cells["StationID"].Value.ToString(), "StationID"))
            {
                if (!Utility.Exist(railRoadStationsTemp, gridEXStation.GetRow().Cells["Sequence"].Text, "Sequence"))
                {
                    List<Station> stations = new List<Station>();
                    stations.Add(new Station(int.Parse(gridEXStation.GetRow().Cells["StationID"].Value.ToString()), "", "", int.Parse(gridEXStation.GetRow().Cells["Sequence"].Text), 0));
                    RailRoad railRoad = new RailRoad(int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text), "", "", stations);
                    new RailRoadBL().UpdateStationRailRoad(railRoad, int.Parse(gridEXStation.GetRow().Cells["oldStationID"].Text));

                    railRoads = new RailRoadBL().GetList();

                    foreach (RailRoad railRoadTemp in railRoads)
                        if (railRoadTemp.RailRoadID == int.Parse(gridEXRailRoad.GetRow().Cells["RailRoadID"].Text))
                        {
                            railRoadStations = railRoadTemp.Stations;
                            break;
                        }
                }
                else
                {
                    NFPMessageBox.Show("لطفاً شماره ترتیب ایستگاه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                    e.Cancel = true;
                }
            }
            else
            {
                NFPMessageBox.Show("لطفاً ایستگاه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXStation_DeletingRecords(object sender, CancelEventArgs e)
        {
            RailRoadBL railRoadBL = new RailRoadBL();

            railRoadBL.DeleteStationRailRoad(int.Parse(gridEXRailRoad.GetRow(gridEXRailRoad.Row).Cells["RailRoadID"].Text), int.Parse(gridEXStation.GetRow(gridEXStation.Row).Cells["oldStationID"].Text));
            railRoads = railRoadBL.GetList();
        }
        #endregion
    }
}
