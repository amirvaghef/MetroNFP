using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Ticket.BussinesLogic;
using Common;
using Common.Utility;

namespace Ticket.Presentation
{
    public partial class SectionFareMain : Form
    {
        List<SectionFareProfile> sectionFareProfiles = new List<SectionFareProfile>();
        List<SectionFare> SectionFares = new List<SectionFare>();
        public SectionFareMain()
        {
            InitializeComponent();
            BindSectionFareData();
        }
        private void BindSectionFareData()
        {
            sectionFareProfiles = new SectionFareProfileBL().GetList();
            gridEXSectionFareProfile.DataSource = sectionFareProfiles;
        }


        #region SectionFareProfile Grid
        private void gridEXSectionFareProfile_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXSectionFareProfile.Row >= 0)
            {
                if (!String.IsNullOrWhiteSpace(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text))
                {
                    int SectionFareProfileID = int.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text);
                    foreach (SectionFareProfile sectionFareProfile in sectionFareProfiles)
                        if (sectionFareProfile.SectionFareProfileID == SectionFareProfileID)
                        {
                            SectionFares = sectionFareProfile.SectionFares;
                            gridEXSectionFare.DataSource = SectionFares;
                            break;
                        }
                }
            }
        }

        private void gridEXSectionFareProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(sectionFareProfiles, Utility.RefineText(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text), "SectionFareProfileName"))
            {
                SectionFareProfile sectionFareProfile = new SectionFareProfile(0, Utility.RefineText(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text), null);
                SectionFareProfileBL sectionFareProfileBL = new SectionFareProfileBL();
                sectionFareProfileBL.InsertSectionFareProfile(sectionFareProfile);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_RecordAdded(object sender, EventArgs e)
        {
            BindSectionFareData();
        }

        private void gridEXSectionFareProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<SectionFareProfile> sectionFareProfilesTemp = sectionFareProfiles.GetRange(0, sectionFareProfiles.Count);
            for (int i = 0; i < sectionFareProfilesTemp.Count; i++)
                if (sectionFareProfilesTemp[i].SectionFareProfileID == int.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text))
                    sectionFareProfilesTemp.RemoveAt(i);

            if (!Utility.Exist(sectionFareProfilesTemp, Utility.RefineText(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text), "SectionFareProfileName"))
            {
                SectionFareProfile sectionFareProfile = new SectionFareProfile(short.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text), Utility.RefineText(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text), null);
                SectionFareProfileBL sectionFareProfileBL = new SectionFareProfileBL();
                sectionFareProfileBL.UpdateSectionFareProfile(sectionFareProfile);

                sectionFareProfiles = sectionFareProfileBL.GetList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_DeletingRecords(object sender, CancelEventArgs e)
        {
            SectionFareProfileBL sectionFareProfileBL = new SectionFareProfileBL();

            sectionFareProfileBL.DeleteSectionFareProfile(int.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text));
            sectionFareProfiles = sectionFareProfileBL.GetList();
        }
        #endregion

        #region Station Grid
        private void gridEXSectionFare_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(SectionFares, gridEXSectionFare.GetRow().Cells["SectionNumber"].Value.ToString(), "SectionNumber"))
            {
                List<SectionFare> sectionFares = new List<SectionFare>();
                sectionFares.Add(new SectionFare(int.Parse(gridEXSectionFare.GetRow().Cells["SectionNumber"].Value.ToString()), double.Parse(gridEXSectionFare.GetRow().Cells["Fare1"].Text), double.Parse(gridEXSectionFare.GetRow().Cells["Fare2"].Text)));
                List<SectionFareProfile> sectionFareProfileList = new List<SectionFareProfile>();
                sectionFareProfileList.Add(new SectionFareProfile(short.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text), gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text, sectionFares));
                new SectionFareProfileBL().InsertSectionFare(sectionFareProfileList);
            }
            else
            {
                NFPMessageBox.Show("لطفاً شماره بخش را با عددی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFare_RecordAdded(object sender, EventArgs e)
        {
            SectionFareProfileBL sectionFareProfileBL = new SectionFareProfileBL();

            sectionFareProfiles = sectionFareProfileBL.GetList();
            foreach (SectionFareProfile sectionFareProfile in sectionFareProfiles)
                if (sectionFareProfile.SectionFareProfileID == int.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text))
                {
                    SectionFares = sectionFareProfile.SectionFares;
                    gridEXSectionFare.DataSource = sectionFareProfile.SectionFares;
                    break;
                }
        }

        private void gridEXSectionFare_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<SectionFare> sectionFaresTemp = SectionFares.GetRange(0, SectionFares.Count);
            for (int i = 0; i < sectionFaresTemp.Count; i++)
                if (sectionFaresTemp[i].SectionNumber == int.Parse(gridEXSectionFare.GetRow().Cells["OldSectionNumber"].Text))
                    sectionFaresTemp.RemoveAt(i);

            if (!Utility.Exist(sectionFaresTemp, gridEXSectionFare.GetRow().Cells["SectionNumber"].Value.ToString(), "SectionNumber"))
            {
                List<SectionFare> sectionFare = new List<SectionFare>();
                sectionFare.Add(new SectionFare(int.Parse(gridEXSectionFare.GetRow().Cells["SectionNumber"].Value.ToString()), double.Parse(gridEXSectionFare.GetRow().Cells["Fare1"].Text), double.Parse(gridEXSectionFare.GetRow().Cells["Fare2"].Text)));
                SectionFareProfile sectionFareProfile = new SectionFareProfile(short.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text), gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileName"].Text, sectionFare);
                new SectionFareProfileBL().UpdateSectionFare(sectionFareProfile, int.Parse(gridEXSectionFare.GetRow().Cells["OldSectionNumber"].Text));

                sectionFareProfiles = new SectionFareProfileBL().GetList();

                foreach (SectionFareProfile sectionFareProfileTemp in sectionFareProfiles)
                    if (sectionFareProfileTemp.SectionFareProfileID == int.Parse(gridEXSectionFareProfile.GetRow().Cells["SectionFareProfileID"].Text))
                    {
                        SectionFares = sectionFareProfileTemp.SectionFares;
                        break;
                    }
            }
            else
            {
                NFPMessageBox.Show("لطفاً شماره بخش را با عددی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFare_DeletingRecords(object sender, CancelEventArgs e)
        {
            SectionFareProfileBL sectionFareProfileBL = new SectionFareProfileBL();

            sectionFareProfileBL.DeleteSectionFare(int.Parse(gridEXSectionFareProfile.GetRow(gridEXSectionFareProfile.Row).Cells["SectionFareProfileID"].Text), int.Parse(gridEXSectionFare.GetRow(gridEXSectionFare.Row).Cells["OldSectionNumber"].Text));
            sectionFareProfiles = sectionFareProfileBL.GetList();
        }
        #endregion
    }
}
