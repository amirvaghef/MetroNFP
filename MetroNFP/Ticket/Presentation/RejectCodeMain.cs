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
    public partial class RejectCodeMain : Form
    {
        private List<RejectCode> rejectCodes = new List<RejectCode>();

        public RejectCodeMain()
        {
            InitializeComponent();

            FillFineList();
            FillPRDMessageList();
            BindRejectCodeData();
        }

        private void BindRejectCodeData()
        {
            rejectCodes = new RejectCodeBL().GetRejectCodeList();
            gridEXRejectCode.DataSource = rejectCodes;
        }

        private void FillFineList()
        {
            gridEXRejectCode.DropDowns["Fine"].SetDataBinding(new FineBL().GetFineList(), "");
            gridEXRejectCode.DropDowns["Fine"].KeepRowSettings = false;
            gridEXRejectCode.DropDowns["Fine"].ReplaceValues = true;
        }

        private void FillPRDMessageList()
        {
            gridEXRejectCode.DropDowns["PRDMessage"].SetDataBinding(new PRDMessageBL().GetPRDMessageList(), "");
            gridEXRejectCode.DropDowns["PRDMessage"].KeepRowSettings = false;
            gridEXRejectCode.DropDowns["PRDMessage"].ReplaceValues = true;
        }

        private void gridEXRejectCode_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(rejectCodes, Utility.RefineText(gridEXRejectCode.GetRow().Cells["RejectCodeName"].Text), "RejectCodeName"))
            {
                RejectCode rejectCode = new RejectCode(0, Utility.RefineText(gridEXRejectCode.GetRow().Cells["RejectCodeName"].Text),
                    bool.Parse(gridEXRejectCode.GetRow().Cells["ActivityRecord"].Text), bool.Parse(gridEXRejectCode.GetRow().Cells["TicketRecord"].Text),
                    short.Parse(gridEXRejectCode.GetRow().Cells["fk_FineID"].Value.ToString()), short.Parse(gridEXRejectCode.GetRow().Cells["fk_PRDMessageID"].Value.ToString()));
                RejectCodeBL rejectCodeBL = new RejectCodeBL();
                rejectCodeBL.InsertRejectCode(rejectCode);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام قانون تردد را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXRejectCode_RecordAdded(object sender, EventArgs e)
        {
            BindRejectCodeData();
        }

        private void gridEXRejectCode_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<RejectCode> rejectCodeTemp = rejectCodes.GetRange(0, rejectCodes.Count);
            for (int i = 0; i < rejectCodeTemp.Count; i++)
                if (rejectCodeTemp[i].RejectCodeID == int.Parse(gridEXRejectCode.GetRow().Cells["RejectCodeID"].Text))
                    rejectCodeTemp.RemoveAt(i);

            if (!Utility.Exist(rejectCodeTemp, Utility.RefineText(gridEXRejectCode.GetRow().Cells["RejectCodeName"].Text), "RejectCodeName"))
            {
                RejectCode rejectCode = new RejectCode(short.Parse(gridEXRejectCode.GetRow().Cells["RejectCodeID"].Text), Utility.RefineText(gridEXRejectCode.GetRow().Cells["RejectCodeName"].Text),
                    bool.Parse(gridEXRejectCode.GetRow().Cells["ActivityRecord"].Text), bool.Parse(gridEXRejectCode.GetRow().Cells["TicketRecord"].Text),
                    short.Parse(gridEXRejectCode.GetRow().Cells["fk_FineID"].Value.ToString()), short.Parse(gridEXRejectCode.GetRow().Cells["fk_PRDMessageID"].Value.ToString()));
                RejectCodeBL rejectCodeBL = new RejectCodeBL();
                rejectCodeBL.UpdateRejectCode(rejectCode);

                rejectCodes = rejectCodeBL.GetRejectCodeList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام قانون تردد را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXRejectCode_DeletingRecords(object sender, CancelEventArgs e)
        {
            RejectCodeBL rejectCodeBL = new RejectCodeBL();

            rejectCodeBL.DeleteRejectCode(int.Parse(gridEXRejectCode.GetRow().Cells["RejectCodeID"].Text));
            rejectCodes = rejectCodeBL.GetRejectCodeList();
        }

        private void llPRDMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(PRDMessageMain)))
                {
                    f.Activate();
                    return;
                }
            PRDMessageMain prdMessage = new PRDMessageMain();
            prdMessage.MdiParent = MdiParent;
            prdMessage.Show();
        }

        private void llFine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(FineMain)))
                {
                    f.Activate();
                    return;
                }
            FineMain fine = new FineMain();
            fine.MdiParent = MdiParent;
            fine.Show();
        }
    }
}