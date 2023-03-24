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
    public partial class HolidaysMain : Form
    {
        List<BankHoliday> bankHolidays = new List<BankHoliday>();
        List<SchoolHoliday> schoolHolidays = new List<SchoolHoliday>();
        public HolidaysMain()
        {
            InitializeComponent();

            gridEXSchoolHoliday.DataSource = new HolidayBL().GetSchoolHolidayList();
            gridEXBankHoliday.DataSource = new HolidayBL().GetBankHolidayList();
        }

        #region gridEXSchoolHoliday Grid
        private void gridEXSchoolHoliday_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(schoolHolidays, Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayName"].Text), "SchoolHolidayName"))
            {
                SchoolHoliday schoolHoliday = new SchoolHoliday(0, Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayName"].Text), Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["FromDate"].Text), Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["UntilDate"].Text));
                HolidayBL holidayBL = new HolidayBL();
                holidayBL.InsertSchoolHoliday(schoolHoliday);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام تعطیلات را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSchoolHoliday_RecordAdded(object sender, EventArgs e)
        {
            gridEXSchoolHoliday.DataSource = new HolidayBL().GetSchoolHolidayList();
        }

        private void gridEXSchoolHoliday_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<SchoolHoliday> schoolHolidaysTemp = schoolHolidays.GetRange(0, schoolHolidays.Count);
            for (int i = 0; i < schoolHolidaysTemp.Count; i++)
                if (schoolHolidaysTemp[i].SchoolHolidayID == short.Parse(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayID"].Text))
                    schoolHolidaysTemp.RemoveAt(i);

            if (!Utility.Exist(schoolHolidaysTemp, Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayName"].Text), "SchoolHolidayName"))
            {
                SchoolHoliday schoolHoliday = new SchoolHoliday(short.Parse(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayID"].Text), Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayName"].Text), Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["FromDate"].Text), Utility.RefineText(gridEXSchoolHoliday.GetRow().Cells["UntilDate"].Text));
                HolidayBL holidayBL = new HolidayBL();
                holidayBL.UpdateSchoolHoliday(schoolHoliday);

                schoolHolidays = holidayBL.GetSchoolHolidayList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام تعطیلات را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSchoolHoliday_DeletingRecords(object sender, CancelEventArgs e)
        {
            HolidayBL holidayBL = new HolidayBL();
            holidayBL.DeleteSchoolHoliday(short.Parse(gridEXSchoolHoliday.GetRow().Cells["SchoolHolidayID"].Text));
            schoolHolidays = holidayBL.GetSchoolHolidayList();
        }
        #endregion

        #region gridEXBankHoliday Grid
        private void gridEXBankHoliday_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(bankHolidays, gridEXBankHoliday.GetRow().Cells["BankHolidayName"].Text, "BankHolidayName"))
            {
                BankHoliday bankHoliday = new BankHoliday(0, Utility.RefineText(gridEXBankHoliday.GetRow().Cells["BankHolidayName"].Text), Utility.RefineText(gridEXBankHoliday.GetRow().Cells["Date"].Text));
                HolidayBL holidayBL = new HolidayBL();
                holidayBL.InsertBankHoliday(bankHoliday);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام تعطیلات را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXBankHoliday_RecordAdded(object sender, EventArgs e)
        {
            gridEXBankHoliday.DataSource = new HolidayBL().GetBankHolidayList();
        }

        private void gridEXBankHoliday_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<BankHoliday> bankHolidaysTemp = bankHolidays.GetRange(0, bankHolidays.Count);
            for (int i = 0; i < bankHolidaysTemp.Count; i++)
                if (bankHolidaysTemp[i].BankHolidayID == short.Parse(gridEXBankHoliday.GetRow().Cells["BankHolidayID"].Text))
                    bankHolidaysTemp.RemoveAt(i);

            if (!Utility.Exist(bankHolidaysTemp, Utility.RefineText(gridEXBankHoliday.GetRow().Cells["BankHolidayName"].Text), "BankHolidayName"))
            {
                BankHoliday bankHoliday = new BankHoliday(short.Parse(gridEXBankHoliday.GetRow().Cells["BankHolidayID"].Text), Utility.RefineText(gridEXBankHoliday.GetRow().Cells["BankHolidayName"].Text), Utility.RefineText(gridEXBankHoliday.GetRow().Cells["Date"].Text));
                HolidayBL holidayBL = new HolidayBL();
                holidayBL.UpdateBankHoliday(bankHoliday);

                bankHolidays = holidayBL.GetBankHolidayList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام تعطیلات را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXBankHoliday_DeletingRecords(object sender, CancelEventArgs e)
        {
            HolidayBL holidayBL = new HolidayBL();
            holidayBL.DeleteBankHoliday(short.Parse(gridEXBankHoliday.GetRow().Cells["BankHolidayID"].Text));
            bankHolidays = holidayBL.GetBankHolidayList();
        }
        #endregion
    }
}
