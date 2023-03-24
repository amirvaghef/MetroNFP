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

namespace MetroNFP.Ticket.Presentation.UserControls
{
    public partial class Ticket2Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket2Wizard()
        {
            new WizardMain().SubmitControl(base.Next(this.GetType().FullName));
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindDropDowns();

            cmbMediaKind.Focus();
        }
        private void BindDropDowns()
        {
            cmbMediaKind.DataSource = new MediaKindBL().GetList();
            cmbTicketKind.DataSource = new TicketKindBL().GetList();

            if (ticket.fk_MediaKindID != 0)
            {
                cmbMediaKind.SelectedValue = ticket.fk_MediaKindID;
                cmbTicketKind.SelectedValue = ticket.fk_TicketKindID;
                txtDepositValue.Text = ticket.DepositeValue.ToString();
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
            if (cmbMediaKind.SelectedIndex != -1)
            {
                if (cmbTicketKind.SelectedIndex != -1)
                {
                    ticket.fk_TicketKindID = short.Parse(cmbTicketKind.SelectedValue.ToString());
                    ticket.fk_MediaKindID = short.Parse(cmbMediaKind.SelectedValue.ToString());
                    ticket.DepositeValue = decimal.Parse(txtDepositValue.Text);

                    base.TicketAssign(ticket.fk_MediaKindID, ticket.fk_TicketKindID);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbTicketKind, "لطفاً نوع بلیت را انتخاب نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMediaKind, "لطفاً نوع مدیا را انتخاب نمائید");
                return null;
            }
     
            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }

        private void cmbMediaKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cmbMediaKind.SelectedValue.ToString()) == 1)
            {
                lblDepositValue.Visible = true;
                lblAmount.Visible = true;
                txtDepositValue.Visible = true;
                txtDepositValue.Text = String.Empty;
            }
            else
            {
                lblDepositValue.Visible = false;
                lblAmount.Visible = false;
                txtDepositValue.Visible = false;
                txtDepositValue.Text = "0";
            }
        }

        //private void txtDepositValue_TextChanged(object sender, EventArgs e)
        //{
        //    String text = ((TextBox)sender).Text;
        //    text.format
        //    bool isDigit = Int32.TryParse(
        //    for (int i = 3; i < text.Length; i += 3)
        //        text = text.Insert(i-1, ",");
        //    ((TextBox)sender).Text = text;
        //}
    }
}
