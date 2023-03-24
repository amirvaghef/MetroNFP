using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ticket.BussinesLogic;
using Common;
using Common.Utility;
using Janus.Windows.GridEX;

namespace Ticket.Presentation
{
    public partial class TimeSlotProfileMain : Form
    {
        private List<TimeSlotProfile> timeSlotProfiles = new List<TimeSlotProfile>();
        private short checkCondition = 0;

        public TimeSlotProfileMain()
        {
            InitializeComponent();

            gridEXTimeSlot.DropDowns["TimeSlotProfile"].SetDataBinding(new SectionFareProfileBL().GetList(), "");
            gridEXTimeSlot.DropDowns["TimeSlotProfile"].KeepRowSettings = false;
            gridEXTimeSlot.DropDowns["TimeSlotProfile"].ReplaceValues = true;

            GridEXValueListItemCollection valueList = gridEXTimeSlot.Tables[0].Columns["fk_WeekDayID"].ValueList;
            List<WeekDays> weekDays = new List<WeekDays>();
            weekDays = new WeekDaysBL().GetList();
            foreach (WeekDays weekday in weekDays)
                valueList.Add(weekday.WeekDayID, weekday.WeekDayName);

            cbTimeSlotProfile.DataSource = new TimeSlotProfileBL().GetList();
        }

        private void gridEXTransferProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (checkCondition == 0)
            {
                if (gridEXTimeSlot.GetRow().Cells["fk_WeekDayID"].Value != null)
                {
                    if ((gridEXTimeSlot.GetRow().Cells["fk_EighthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FifthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FirstSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FourthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SecondSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SeventhSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SixthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_ThirdSectionFare"].Value != null))
                    {
                        TimeSlot timeSlot = new TimeSlot();
                        timeSlot.EighthFinishTime = gridEXTimeSlot.GetRow().Cells["EighthFinishTime"].Text;
                        timeSlot.EighthStartTime = gridEXTimeSlot.GetRow().Cells["EighthStartTime"].Text;
                        timeSlot.FifthFinishTime = gridEXTimeSlot.GetRow().Cells["FifthFinishTime"].Text;
                        timeSlot.FifthStartTime = gridEXTimeSlot.GetRow().Cells["FifthStartTime"].Text;
                        timeSlot.FirstFinishTime = gridEXTimeSlot.GetRow().Cells["FirstFinishTime"].Text;
                        timeSlot.FirstStartTime = gridEXTimeSlot.GetRow().Cells["FirstStartTime"].Text;
                        timeSlot.fk_EighthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_EighthSectionFare"].Value.ToString());
                        timeSlot.fk_FifthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FifthSectionFare"].Value.ToString());
                        timeSlot.fk_FirstSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FirstSectionFare"].Value.ToString());
                        timeSlot.fk_FourthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FourthSectionFare"].Value.ToString());
                        timeSlot.fk_SecondSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SecondSectionFare"].Value.ToString());
                        timeSlot.fk_SeventhSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SeventhSectionFare"].Value.ToString());
                        timeSlot.fk_SixthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SixthSectionFare"].Value.ToString());
                        timeSlot.fk_ThirdSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_ThirdSectionFare"].Value.ToString());
                        timeSlot.fk_TimeSlotProfileID = timeSlotProfiles[cbTimeSlotProfile.SelectedIndex].TimeSlotProfileID;
                        timeSlot.fk_WeekDayID = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_WeekDayID"].Value.ToString());
                        timeSlot.FourthFinishTime = gridEXTimeSlot.GetRow().Cells["FourthFinishTime"].Text;
                        timeSlot.FourthStartTime = gridEXTimeSlot.GetRow().Cells["FourthStartTime"].Text;
                        timeSlot.SecondFinishTime = gridEXTimeSlot.GetRow().Cells["SecondFinishTime"].Text;
                        timeSlot.SecondStartTime = gridEXTimeSlot.GetRow().Cells["SecondStartTime"].Text;
                        timeSlot.SeventhFinishTime = gridEXTimeSlot.GetRow().Cells["SeventhFinishTime"].Text;
                        timeSlot.SeventhStartTime = gridEXTimeSlot.GetRow().Cells["SeventhStartTime"].Text;
                        timeSlot.SixthFinishTime = gridEXTimeSlot.GetRow().Cells["SixthFinishTime"].Text;
                        timeSlot.SixthStartTime = gridEXTimeSlot.GetRow().Cells["SixthStartTime"].Text;
                        timeSlot.ThirdFinishTime = gridEXTimeSlot.GetRow().Cells["ThirdFinishTime"].Text;
                        timeSlot.ThirdStartTime = gridEXTimeSlot.GetRow().Cells["ThirdStartTime"].Text;
                        new TimeSlotProfileBL().InsertTimeSlot(timeSlot);
                    }
                    else
                        NFPMessageBox.Show("شما پروفایل های کرایه را پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                }
                else
                    NFPMessageBox.Show("شما یکی از روزهای هفته را انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
            }
            else
            {
                switch (checkCondition)
                {
                    case 1:
                        NFPMessageBox.Show("شما تمامی روزهای هفته را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                    case 2:
                        NFPMessageBox.Show("لطفاً روز هفته را با روزی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                    case 3:
                        NFPMessageBox.Show("شما روز دیگری را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                }
            }
        }

        private void gridEXTransferProfile_RecordAdded(object sender, EventArgs e)
        {
            timeSlotProfiles = new TimeSlotProfileBL().GetList();
            gridEXTimeSlot.DataSource = timeSlotProfiles[cbTimeSlotProfile.SelectedIndex].TimeSlots;
        }

        private void gridEXTransferProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            if (checkCondition == 0)
            {
                if (gridEXTimeSlot.GetRow().Cells["fk_WeekDayID"].Value != null)
                {
                    if ((gridEXTimeSlot.GetRow().Cells["fk_EighthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FifthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FirstSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_FourthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SecondSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SeventhSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_SixthSectionFare"].Value != null) &&
                        (gridEXTimeSlot.GetRow().Cells["fk_ThirdSectionFare"].Value != null))
                    {
                        TimeSlot timeSlot = new TimeSlot();
                        timeSlot.EighthFinishTime = gridEXTimeSlot.GetRow().Cells["EighthFinishTime"].Text;
                        timeSlot.EighthStartTime = gridEXTimeSlot.GetRow().Cells["EighthStartTime"].Text;
                        timeSlot.FifthFinishTime = gridEXTimeSlot.GetRow().Cells["FifthFinishTime"].Text;
                        timeSlot.FifthStartTime = gridEXTimeSlot.GetRow().Cells["FifthStartTime"].Text;
                        timeSlot.FirstFinishTime = gridEXTimeSlot.GetRow().Cells["FirstFinishTime"].Text;
                        timeSlot.FirstStartTime = gridEXTimeSlot.GetRow().Cells["FirstStartTime"].Text;
                        timeSlot.fk_EighthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_EighthSectionFare"].Value.ToString());
                        timeSlot.fk_FifthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FifthSectionFare"].Value.ToString());
                        timeSlot.fk_FirstSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FirstSectionFare"].Value.ToString());
                        timeSlot.fk_FourthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_FourthSectionFare"].Value.ToString());
                        timeSlot.fk_SecondSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SecondSectionFare"].Value.ToString());
                        timeSlot.fk_SeventhSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SeventhSectionFare"].Value.ToString());
                        timeSlot.fk_SixthSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_SixthSectionFare"].Value.ToString());
                        timeSlot.fk_ThirdSectionFare = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_ThirdSectionFare"].Value.ToString());
                        timeSlot.fk_TimeSlotProfileID = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_TimeSlotProfileID"].Value.ToString());
                        timeSlot.fk_WeekDayID = short.Parse(gridEXTimeSlot.GetRow().Cells["fk_WeekDayID"].Value.ToString());
                        timeSlot.FourthFinishTime = gridEXTimeSlot.GetRow().Cells["FourthFinishTime"].Text;
                        timeSlot.FourthStartTime = gridEXTimeSlot.GetRow().Cells["FourthStartTime"].Text;
                        timeSlot.SecondFinishTime = gridEXTimeSlot.GetRow().Cells["SecondFinishTime"].Text;
                        timeSlot.SecondStartTime = gridEXTimeSlot.GetRow().Cells["SecondStartTime"].Text;
                        timeSlot.SeventhFinishTime = gridEXTimeSlot.GetRow().Cells["SeventhFinishTime"].Text;
                        timeSlot.SeventhStartTime = gridEXTimeSlot.GetRow().Cells["SeventhStartTime"].Text;
                        timeSlot.SixthFinishTime = gridEXTimeSlot.GetRow().Cells["SixthFinishTime"].Text;
                        timeSlot.SixthStartTime = gridEXTimeSlot.GetRow().Cells["SixthStartTime"].Text;
                        timeSlot.ThirdFinishTime = gridEXTimeSlot.GetRow().Cells["ThirdFinishTime"].Text;
                        timeSlot.ThirdStartTime = gridEXTimeSlot.GetRow().Cells["ThirdStartTime"].Text;

                        new TimeSlotProfileBL().UpdateTimeSlot(timeSlot, short.Parse(gridEXTimeSlot.GetRow().Cells["oldfk_WeekDayID"].Value.ToString()));

                        timeSlotProfiles = new TimeSlotProfileBL().GetList();
                    }
                    else
                        NFPMessageBox.Show("شما پروفایل های کرایه را پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                }
                else
                    NFPMessageBox.Show("شما یکی از روزهای هفته را انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
            }
            else
            {
                switch (checkCondition)
                {
                    case 1:
                        NFPMessageBox.Show("شما تمامی روزهای هفته را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                    case 2:
                        NFPMessageBox.Show("لطفاً روز هفته را با روزی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                    case 3:
                        NFPMessageBox.Show("شما روز دیگری را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TimeSlotProfileBL().DeleteTimeSlotProfile(int.Parse(cbTimeSlotProfile.SelectedValue.ToString()));

            timeSlotProfiles = new TimeSlotProfileBL().GetList();
            cbTimeSlotProfile.DataSource = timeSlotProfiles;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtTimeSlotProfileName.Text.Trim() != String.Empty)
            {
                if (!Utility.Exist(timeSlotProfiles, Utility.RefineText(txtTimeSlotProfileName.Text), "TimeSlotProfileName"))
                {
                    TimeSlotProfile timeSlotProfile = new TimeSlotProfile();
                    timeSlotProfile.TimeSlotProfileName = Utility.RefineText(txtTimeSlotProfileName.Text);
                    new TimeSlotProfileBL().InsertTimeSlotProfile(timeSlotProfile);

                    timeSlotProfiles = new TimeSlotProfileBL().GetList();
                    cbTimeSlotProfile.DataSource = timeSlotProfiles;

                    txtTimeSlotProfileName.Text = String.Empty;
                }
                else
                    NFPMessageBox.Show("لطفاً فیلد نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
            }
            else
                NFPMessageBox.Show("لطفاً فیلد نام پروفایل را پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);

        }

        private void cbTimeSlotProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((gridEXTimeSlot.GetRows().Length == 1) && (gridEXTimeSlot.GetRow(0).Cells["fk_WeekDayID"].Value.ToString() == "8")) || (gridEXTimeSlot.GetRows().Length == 7) || (gridEXTimeSlot.GetRows().Length == 0))
            {
                timeSlotProfiles = new TimeSlotProfileBL().GetList();
                gridEXTimeSlot.DataSource = timeSlotProfiles[cbTimeSlotProfile.SelectedIndex].TimeSlots;
            }
            else
            {
                NFPMessageBox.Show("شما باید تمامی روزهای هفته را انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
            }
        }

        private void gridEXTimeSlot_CellUpdated(object sender, ColumnActionEventArgs e)
        {
            if (e.Column == gridEXTimeSlot.Tables[0].Columns["fk_weekDayID"])
            {
                checkCondition = 0;
                if ((short.Parse(gridEXTimeSlot.GetRow().Cells[e.Column].Value.ToString()) == 8))
                {
                    if ((gridEXTimeSlot.GetRows().Length > 1) || ((gridEXTimeSlot.GetRows().Length == 1) && (gridEXTimeSlot.GetRow().Position == -1)))
                    {
                        checkCondition = 1;
                        NFPMessageBox.Show("شما تمامی روزهای هفته را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                        return;
                    }
                }

                GridEXRow[] rows = gridEXTimeSlot.GetRows();

                foreach (GridEXRow row in rows)
                {
                    if (!row.Equals(gridEXTimeSlot.GetRow()))
                    {
                        if (short.Parse(row.Cells[e.Column].Value.ToString()) == short.Parse(gridEXTimeSlot.GetRow().Cells[e.Column].Value.ToString()))
                        {
                            checkCondition = 2;
                            NFPMessageBox.Show("لطفاً روز هفته را با روزی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                            return;
                        }
                        if ((short.Parse(row.Cells[e.Column].Value.ToString()) == 8) && (gridEXTimeSlot.GetRow().Cells[e.Column].DataChanged))
                        {
                            checkCondition = 3;
                            NFPMessageBox.Show("شما روز دیگری را نمی توانید انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                            return;
                        }
                    }
                }
            }
        }

        private void TimeSlotProfileMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((gridEXTimeSlot.GetRows().Length != 1) || (gridEXTimeSlot.GetRow(0).Cells["fk_WeekDayID"].Value.ToString() != "8")) && (gridEXTimeSlot.GetRows().Length != 7) && (gridEXTimeSlot.GetRows().Length != 0))
            {
                NFPMessageBox.Show("شما باید تمامی روزهای هفته را انتخاب نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }
    }
}