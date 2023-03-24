using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ticket.BussinesLogic;
using Common;
using Common.Utility;
using Ticket.DataAccess;

namespace MetroNFP.Ticket.Presentation.UserControls
{
    public partial class Ticket7Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket7Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindDropDowns();

            cmbValidation.Focus();
        }
        private void BindDropDowns()
        {
            cmbIssue.DataSource = new PrintingProfileBL().GetIssueList();
            cmbValidation.DataSource = new PrintingProfileBL().GetValidationList();

            if (ticket.fk_IssuingPrintingProfileID != 0)
            {
                cmbIssue.SelectedValue = ticket.fk_IssuingPrintingProfileID;
                cmbValidation.SelectedValue = ticket.fk_ValidatingPrintingProfileID;
                chkBin.Checked = ticket.BinTicket;
            }
        }
        private void Common2Wizard_Load(object sender, EventArgs e)
        {
            EnabledDisableWizard();
        }
        private void EnabledDisableWizard()
        {
            if (Parent != null)
            {
                ((WizardMain)Parent.Parent).EnabledPrevious = true;
                ((WizardMain)Parent.Parent).EnabledNext = true;
                ((WizardMain)Parent.Parent).EnabledFinish = false;
                ((WizardMain)Parent.Parent).EnabledCancel = true;
            }
        }

        public UserControl Next()
        {
            if (Submit() != null)
                return base.Next(this.GetType().FullName);
            else
                return null;
        }

        public UserControl Previous()
        {
            return base.Previous(this.GetType().FullName);
        }

        public override void Cancel()
        {
            base.Cancel();
        }

        public override bool Finish()
        {
            return false;
        }

        private object Submit()
        {
            if (cmbValidation.SelectedIndex != -1)
            {
                if (cmbIssue.SelectedIndex != -1)
                {
                    ticket.fk_IssuingPrintingProfileID = short.Parse(cmbIssue.SelectedValue.ToString());
                    ticket.fk_ValidatingPrintingProfileID = short.Parse(cmbValidation.SelectedValue.ToString());
                    ticket.BinTicket = chkBin.Checked;
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbIssue, "لطفاً پروفایل پرینت در صدور را انتخاب نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbValidation, "لطفاً پروفایل پرینت در اعتبارسنجی را انتخاب نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }
    }
}
