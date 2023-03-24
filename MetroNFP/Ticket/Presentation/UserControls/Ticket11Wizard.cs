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
using Ticket.Presentation;

namespace MetroNFP.Ticket.Presentation.UserControls
{
    public partial class Ticket11Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket11Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindData();

            txtMaxIssue.Focus();
        }
        private void BindData()
        {
            if (ticket.IssueMaxNumberOfTicket != 0)
            {
                txtMaxIssue.Text = ticket.IssueMaxNumberOfTicket.ToString();
                chbIssueExist.Checked = ticket.SaleExist;
                chbReloadExist.Checked = ticket.ReloadExist;
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
                ((WizardMain)Parent.Parent).EnabledFinish = true;
                ((WizardMain)Parent.Parent).EnabledCancel = true;
                ((WizardMain)Parent.Parent).EnabledNext = false;
            }
        }

        public UserControl Next()
        {
            return base.Next(this.GetType().FullName);
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
            if (Submit() != null)
                return base.Finish();
            else
                return false;
        }

        private object Submit()
        {
            try
            {
                if (txtMaxIssue.Text != String.Empty)
                {
                    ticket.IssueMaxNumberOfTicket = int.Parse(txtMaxIssue.Text);
                    ticket.SaleExist = chbIssueExist.Checked;
                    ticket.ReloadExist = chbReloadExist.Checked;

                    if (opKind == OperationKind.Insert)
                        new TicketBL().InsertTicket(ticket);
                    else
                        new TicketBL().UpdateTicket(ticket);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtMaxIssue, "لطفاً حداکثر تعداد صدور را انتخاب نمائید");
                    return null;
                }

                data[Common.Utility.Constant.TicketInfo] = ticket;
                return data[Common.Utility.Constant.TicketInfo];
            }
            catch
            {
                return null;
            }
        }
    }
}
