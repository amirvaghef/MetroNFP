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
    public partial class Ticket6Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket6Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];            
            BindDropDowns();

            dtpStart.Focus();
        }
        private void BindDropDowns()
        {
            if (ticket.StartDate != null)
            {
                string[] date = ticket.StartDate.Split('/');
                dtpStart.SetSelectedDate(new BehComponents.PersianDateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])));
                date = ticket.EndDate.Split('/');
                dtpFinish.SetSelectedDate(new BehComponents.PersianDateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])));
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
            if (dtpStart.SelectedDate != String.Empty)
            {
                if (dtpFinish.SelectedDate != String.Empty)
                {
                    ticket.StartDate = dtpStart.GetSelectedDateInPersianDateTime().ToShortDateString();
                    ticket.EndDate = dtpFinish.GetSelectedDateInPersianDateTime().ToShortDateString();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(dtpFinish, "لطفاً تاریخ پایان را وارد نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dtpStart, "لطفاً تاریخ شروع را وارد نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }
    }
}
