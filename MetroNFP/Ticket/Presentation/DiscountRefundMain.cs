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
    public partial class DiscountRefundMain : Form
    {
        List<DiscountRefundProfile> discountRefundProfiles = new List<DiscountRefundProfile>();
        List<DiscountRefund> discountRefunds = new List<DiscountRefund>();
        public DiscountRefundMain()
        {
            InitializeComponent();
            BindDiscountRefundData();
        }
        private void BindDiscountRefundData()
        {
            GridEXValueListItemCollection valueList = gridEXDiscountRefundProfile.Tables[0].Columns["OperationKind"].ValueList;
            valueList.Add(0, "تخفیف");
            valueList.Add(1, "استرداد");

            discountRefundProfiles = new DiscountRefundProfileBL().GetList();
            gridEXDiscountRefundProfile.DataSource = discountRefundProfiles;
        }


        #region DiscountRefundProfile Grid
        private void gridEXSectionFareProfile_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXDiscountRefundProfile.Row >= 0)
            {
                if (!String.IsNullOrWhiteSpace(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text))
                {
                    int DiscountRefundProfileID = int.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text);
                    foreach (DiscountRefundProfile discountRefundProfile in discountRefundProfiles)
                        if (discountRefundProfile.DiscountRefundProfileID == DiscountRefundProfileID)
                        {
                            discountRefunds = discountRefundProfile.DiscountRefunds;
                            gridEXDiscountRefund.DataSource = discountRefunds;
                            break;
                        }
                }
            }
        }

        private void gridEXSectionFareProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(discountRefundProfiles, Utility.RefineText(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text), "DiscountRefundProfileName"))
            {
                DiscountRefundProfile discountRefundProfile = new DiscountRefundProfile(0, Utility.RefineText(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text), byte.Parse(gridEXDiscountRefundProfile.GetRow().Cells["OperationKind"].Value.ToString()), null);
                DiscountRefundProfileBL discountRefundProfileBL = new DiscountRefundProfileBL();
                discountRefundProfileBL.InsertDiscountRefundProfile(discountRefundProfile);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_RecordAdded(object sender, EventArgs e)
        {
            BindDiscountRefundData();
        }

        private void gridEXSectionFareProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<DiscountRefundProfile> discountRefundProfilesTemp = discountRefundProfiles.GetRange(0, discountRefundProfiles.Count);
            for (int i = 0; i < discountRefundProfilesTemp.Count; i++)
                if (discountRefundProfilesTemp[i].DiscountRefundProfileID == int.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text))
                    discountRefundProfilesTemp.RemoveAt(i);

            if (!Utility.Exist(discountRefundProfilesTemp, Utility.RefineText(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text), "DiscountRefundProfileName"))
            {
                DiscountRefundProfile discountRefundProfile = new DiscountRefundProfile(short.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text), Utility.RefineText(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text), byte.Parse(gridEXDiscountRefundProfile.GetRow().Cells["OperationKind"].Value.ToString()), null);
                DiscountRefundProfileBL discountRefundProfileBL = new DiscountRefundProfileBL();
                discountRefundProfileBL.UpdateDiscountRefundProfile(discountRefundProfile);

                discountRefundProfiles = discountRefundProfileBL.GetList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_DeletingRecords(object sender, CancelEventArgs e)
        {
            DiscountRefundProfileBL discountRefundProfileBL = new DiscountRefundProfileBL();

            discountRefundProfileBL.DeleteDiscountRefundProfile(int.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text));
            discountRefundProfiles = discountRefundProfileBL.GetList();
        }
        #endregion

        #region Station Grid
        private void gridEXSectionFare_AddingRecord(object sender, CancelEventArgs e)
        {
            List<DiscountRefund> discountRefund = new List<DiscountRefund>();
            discountRefund.Add(new DiscountRefund(0, double.Parse(gridEXDiscountRefund.GetRow().Cells["StartCost"].Text), double.Parse(gridEXDiscountRefund.GetRow().Cells["FinishCost"].Text), short.Parse(gridEXDiscountRefund.GetRow().Cells["Percent"].Text)));
            List<DiscountRefundProfile> discountRefundProfileList = new List<DiscountRefundProfile>();
            discountRefundProfileList.Add(new DiscountRefundProfile(short.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text), gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text, byte.Parse(gridEXDiscountRefundProfile.GetRow().Cells["OperationKind"].Value.ToString()), discountRefund));
            new DiscountRefundProfileBL().InsertDiscountRefund(discountRefundProfileList);
        }

        private void gridEXSectionFare_RecordAdded(object sender, EventArgs e)
        {
            DiscountRefundProfileBL discountRefundProfileBL = new DiscountRefundProfileBL();

            discountRefundProfiles = discountRefundProfileBL.GetList();
            foreach (DiscountRefundProfile discountRefundProfile in discountRefundProfiles)
                if (discountRefundProfile.DiscountRefundProfileID == int.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text))
                {
                    discountRefunds = discountRefundProfile.DiscountRefunds;
                    gridEXDiscountRefund.DataSource = discountRefundProfile.DiscountRefunds;
                    break;
                }
        }

        private void gridEXSectionFare_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<DiscountRefund> discountRefund = new List<DiscountRefund>();
            discountRefund.Add(new DiscountRefund(int.Parse(gridEXDiscountRefund.GetRow().Cells["DiscountRefundID"].Text), double.Parse(gridEXDiscountRefund.GetRow().Cells["StartCost"].Text), double.Parse(gridEXDiscountRefund.GetRow().Cells["FinishCost"].Text), short.Parse(gridEXDiscountRefund.GetRow().Cells["Percent"].Text)));
            DiscountRefundProfile discountRefundProfile = new DiscountRefundProfile(short.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text), Utility.RefineText(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileName"].Text), byte.Parse(gridEXDiscountRefundProfile.GetRow().Cells["OperationKind"].Value.ToString()), discountRefund);
            new DiscountRefundProfileBL().UpdateDiscountRefund(discountRefundProfile);

            discountRefundProfiles = new DiscountRefundProfileBL().GetList();

            foreach (DiscountRefundProfile discountRefundProfileTemp in discountRefundProfiles)
                if (discountRefundProfileTemp.DiscountRefundProfileID == int.Parse(gridEXDiscountRefundProfile.GetRow().Cells["DiscountRefundProfileID"].Text))
                {
                    discountRefunds = discountRefundProfileTemp.DiscountRefunds;
                    break;
                }
        }

        private void gridEXSectionFare_DeletingRecords(object sender, CancelEventArgs e)
        {
            DiscountRefundProfileBL discountRefundProfileBL = new DiscountRefundProfileBL();

            discountRefundProfileBL.DeleteDiscountRefund(int.Parse(gridEXDiscountRefund.GetRow(gridEXDiscountRefund.Row).Cells["DiscountRefundID"].Text));
            discountRefundProfiles = discountRefundProfileBL.GetList();
        }
        #endregion
    }
}
