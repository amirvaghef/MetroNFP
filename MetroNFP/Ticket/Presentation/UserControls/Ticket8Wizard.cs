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
    public partial class Ticket8Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket8Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindDropDowns();

            cbRegularDays.Focus();
        }
        private void BindDropDowns()
        {
            cbBankHoliday.DataSource = new TimeSlotProfileBL().GetList();
            cbRegularDays.DataSource = new TimeSlotProfileBL().GetList();
            cbSchoolHoliday.DataSource = new TimeSlotProfileBL().GetList();

            if (ticket.fk_BankDaysSlotProfileID != 0)
            {
                cbBankHoliday.SelectedValue = ticket.fk_BankDaysSlotProfileID;
                cbRegularDays.SelectedValue = ticket.fk_RegularDaysSlotProfileID;
                cbSchoolHoliday.SelectedValue = ticket.fk_SchoolDaysSlotProfileID;
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
            if (cbRegularDays.SelectedIndex != -1)
            {
                if (cbSchoolHoliday.SelectedIndex != -1)
                {
                    if (cbBankHoliday.SelectedIndex != -1)
                    {
                        ticket.fk_BankDaysSlotProfileID = short.Parse(cbBankHoliday.SelectedValue.ToString());
                        ticket.fk_RegularDaysSlotProfileID = short.Parse(cbRegularDays.SelectedValue.ToString());
                        ticket.fk_SchoolDaysSlotProfileID = short.Parse(cbSchoolHoliday.SelectedValue.ToString());
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(cbBankHoliday, "لطفاً پروفایل تعطیلات بانکی را انتخاب نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbSchoolHoliday, "لطفاً پروفایل تعطیلات مدرسه را انتخاب نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbRegularDays, "لطفاً پروفایل روزهای عادی را انتخاب نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TimeSlotProfileMain().ShowDialog();
            cbBankHoliday.DataSource = new TimeSlotProfileBL().GetList();
            cbRegularDays.DataSource = new TimeSlotProfileBL().GetList();
            cbSchoolHoliday.DataSource = new TimeSlotProfileBL().GetList();
        }
    }
}
