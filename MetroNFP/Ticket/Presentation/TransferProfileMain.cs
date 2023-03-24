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
    public partial class TransferProfileMain : Form
    {
        private List<TransferProfile> transferProfiles = new List<TransferProfile>();

        public TransferProfileMain()
        {
            InitializeComponent();
            BindTransferProfileData();
        }

        private void BindTransferProfileData()
        {
            transferProfiles = new TransferProfileBL().GetTransferProfileList();
            gridEXTransferProfile.DataSource = transferProfiles;
        }

        private void gridEXTransferProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(transferProfiles, Utility.RefineText(gridEXTransferProfile.GetRow().Cells["TransferProfileName"].Text), "TransferProfileName"))
            {
                TransferProfile transferProfile = new TransferProfile(0, Utility.RefineText(gridEXTransferProfile.GetRow().Cells["TransferProfileName"].Text),
                    short.Parse(gridEXTransferProfile.GetRow().Cells["MaxNumberOfTravelInDay"].Text), short.Parse(gridEXTransferProfile.GetRow().Cells["TravelMaxDuration"].Text),
                    short.Parse(gridEXTransferProfile.GetRow().Cells["MultiUsersNumber"].Text), short.Parse(gridEXTransferProfile.GetRow().Cells["AntiPassBack"].Text));
                TransferProfileBL transferProfileBL = new TransferProfileBL();
                transferProfileBL.InsertTransferProfile(transferProfile);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام قانون تردد را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading , NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXTransferProfile_RecordAdded(object sender, EventArgs e)
        {
            BindTransferProfileData();
        }

        private void gridEXTransferProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<TransferProfile> transferProfileTemp = transferProfiles.GetRange(0, transferProfiles.Count);
            for (int i = 0; i < transferProfileTemp.Count; i++)
                if (transferProfileTemp[i].TransferProfileID == int.Parse(gridEXTransferProfile.GetRow().Cells["TransferProfileID"].Text))
                    transferProfileTemp.RemoveAt(i);

            if (!Utility.Exist(transferProfileTemp, Utility.RefineText(gridEXTransferProfile.GetRow().Cells["TransferProfileName"].Text), "TransferProfileName"))
            {
                TransferProfile transferProfile = new TransferProfile(short.Parse(gridEXTransferProfile.GetRow().Cells["TransferProfileID"].Text), Utility.RefineText(gridEXTransferProfile.GetRow().Cells["TransferProfileName"].Text),
                    short.Parse(gridEXTransferProfile.GetRow().Cells["MaxNumberOfTravelInDay"].Text), short.Parse(gridEXTransferProfile.GetRow().Cells["TravelMaxDuration"].Text),
                    short.Parse(gridEXTransferProfile.GetRow().Cells["MultiUsersNumber"].Text), short.Parse(gridEXTransferProfile.GetRow().Cells["AntiPassBack"].Text));
                TransferProfileBL transferProfileBL = new TransferProfileBL();
                transferProfileBL.UpdateTransferProfile(transferProfile);

                transferProfiles = transferProfileBL.GetTransferProfileList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام قانون تردد را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXTransferProfile_DeletingRecords(object sender, CancelEventArgs e)
        {
            TransferProfileBL transferProfileBL = new TransferProfileBL();

            transferProfileBL.DeleteTransferProfile(int.Parse(gridEXTransferProfile.GetRow().Cells["TransferProfileID"].Text));
            transferProfiles = transferProfileBL.GetTransferProfileList();
        }
    }
}