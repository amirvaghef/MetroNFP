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
    public partial class Ticket3Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket3Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindDropDowns();

            txtAmountValue.Focus();
        }
        private void BindDropDowns()
        {
            cmbSectionFareProfile.DataSource = new SectionFareProfileBL().GetList();
            cmbDiscount.DataSource = new DiscountRefundProfileBL().GetDiscountList();
            cmbRefund.DataSource = new DiscountRefundProfileBL().GetRefundList();

            if (ticket.AmountDefault != 0)
            {
                cmbDiscount.SelectedValue = ticket.fk_DiscountID;
                cmbRefund.SelectedValue = ticket.fk_RefundID;
                cmbSectionFareProfile.SelectedValue = ticket.fk_SectionFareID;
                txtAmountValue.Text = ticket.AmountDefault.ToString();
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
            if (ticket.fk_TicketKindID == 1)
            {
                if (txtAmountValue.Text != String.Empty)
                {
                    if (cmbSectionFareProfile.SelectedIndex != -1)
                    {
                        if (cmbDiscount.SelectedIndex != -1)
                        {
                            if (cmbRefund.SelectedIndex != -1)
                            {
                                ticket.AmountDefault = decimal.Parse(txtAmountValue.Text);
                                ticket.fk_SectionFareID = short.Parse(cmbSectionFareProfile.SelectedValue.ToString());
                                ticket.fk_DiscountID = short.Parse(cmbDiscount.SelectedValue.ToString());
                                ticket.fk_RefundID = short.Parse(cmbRefund.SelectedValue.ToString());
                            }
                            else
                            {
                                errorProvider1.Clear();
                                errorProvider1.SetError(cmbRefund, "لطفاً تعریف استرداد را انتخاب نمائید");
                                return null;
                            }
                        }
                        else
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(cmbDiscount, "لطفاً تعریف تخفیف را انتخاب نمائید");
                            return null;
                        }
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(cmbSectionFareProfile, "لطفاً پروفایل کرایه را انتخاب نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtAmountValue, "لطفاً مبلغ پیش فرض را وارد نمائید");
                    return null;
                }

                data[Common.Utility.Constant.TicketInfo] = ticket;
                return data[Common.Utility.Constant.TicketInfo];
            }
            else
                return null;    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SectionFareMain().ShowDialog();
            cmbSectionFareProfile.DataSource = new SectionFareProfileBL().GetList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DiscountRefundMain().ShowDialog();
            cmbDiscount.DataSource = new DiscountRefundProfileBL().GetDiscountList();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DiscountRefundMain().ShowDialog();
            cmbRefund.DataSource = new DiscountRefundProfileBL().GetRefundList();
        }
    }
}
