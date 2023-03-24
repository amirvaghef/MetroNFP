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
    public partial class Ticket5Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket5Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            if (ticket.fk_TicketKindID == 2)
            {
                lblTripAmount.Visible = true;
                lblTripNumber.Visible = true;
                txtTripNumber.Visible = true;
            }
            else
            {
                lblTripAmount.Visible = false;
                lblTripNumber.Visible = false;
                txtTripNumber.Visible = false;
                txtTripNumber.Text = "0";
            }
            BindDropDowns();

            txtCostNow.Focus();
        }
        private void BindDropDowns()
        {
            if (ticket.TicketCostFuture != 0)
            {
                txtCostFuture.Text = ticket.TicketCostFuture.ToString();
                txtCostNow.Text = ticket.TicketCostNow.ToString();
                txtDuration.Text = ticket.DurationValidation.ToString();
                txtTripNumber.Text = ticket.TripNumber.ToString();
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
            if (txtCostNow.Text != String.Empty)
            {
                if (txtCostFuture.Text != String.Empty)
                {
                    if (txtDuration.Text != String.Empty)
                    {
                        if (txtTripNumber.Text != String.Empty)
                        {
                            if (short.Parse(txtDuration.Text) <= 365)
                            {
                                ticket.TicketCostNow = decimal.Parse(txtCostNow.Text);
                                ticket.TicketCostFuture = decimal.Parse(txtCostFuture.Text);
                                ticket.DurationValidation = short.Parse(txtDuration.Text);
                                ticket.TripNumber = short.Parse(txtTripNumber.Text);
                            }
                            else
                            {
                                errorProvider1.Clear();
                                errorProvider1.SetError(txtDuration, "لطفاً تعداد روز اعتبار را درست وارد نمائید");
                                return null;
                            }
                        }
                        else
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(txtTripNumber, "لطفاً تعداد سفر را وارد نمائید");
                            return null;
                        }
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtDuration, "لطفاً تعداد روز اعتبار در سال را وارد نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCostFuture, "لطفاً قیمت آینده را وارد نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCostNow, "لطفاً قیمت فعلی را وارد نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }
    }
}
