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
    public partial class FineMain : Form
    {
        private List<Fine> fines = new List<Fine>();

        public FineMain()
        {
            InitializeComponent();
            BindFineData();
        }

        private void BindFineData()
        {
            fines = new FineBL().GetFineList();
            gridEXFine.DataSource = fines;
        }

        private void gridEXFine_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(fines, Utility.RefineText(gridEXFine.GetRow().Cells["FineName"].Text), "FineName"))
            {
                Fine fine = new Fine(0, Utility.RefineText(gridEXFine.GetRow().Cells["FineName"].Text), decimal.Parse(gridEXFine.GetRow().Cells["FineCost1"].Text), decimal.Parse(gridEXFine.GetRow().Cells["FineCost2"].Text));
                FineBL fineBL = new FineBL();
                fineBL.InsertFine(fine);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام جریمه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXFine_RecordAdded(object sender, EventArgs e)
        {
            BindFineData();
        }

        private void gridEXFine_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<Fine> fineTemp = fines.GetRange(0, fines.Count);
            for (int i = 0; i < fineTemp.Count; i++)
                if (fineTemp[i].FineID == int.Parse(gridEXFine.GetRow().Cells["FineID"].Text))
                    fineTemp.RemoveAt(i);

            if (!Utility.Exist(fineTemp, Utility.RefineText(gridEXFine.GetRow().Cells["FineName"].Text), "FineName"))
            {
                Fine fine = new Fine(short.Parse(gridEXFine.GetRow().Cells["FineID"].Text), Utility.RefineText(gridEXFine.GetRow().Cells["FineName"].Text), decimal.Parse(gridEXFine.GetRow().Cells["FineCost1"].Text), decimal.Parse(gridEXFine.GetRow().Cells["FineCost2"].Text));
                FineBL fineBL = new FineBL();
                fineBL.UpdateFine(fine);

                fines = fineBL.GetFineList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام جریمه را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXFine_DeletingRecords(object sender, CancelEventArgs e)
        {
            FineBL fineBL = new FineBL();

            fineBL.DeleteFine(int.Parse(gridEXFine.GetRow().Cells["FineID"].Text));
            fines = fineBL.GetFineList();
        }
    }
}