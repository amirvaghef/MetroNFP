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
    public partial class Ticket10Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket10Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindData();

            txtMinimum.Focus();
        }
        private void BindData()
        {
            if (ticket.ReloadMaxTreshold != 0)
            {
                txtMinimum.Text = ticket.ReloadMinTreshold.ToString();
                txtMaximum.Text = ticket.ReloadMaxTreshold.ToString();
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
            if (txtMinimum.Text != String.Empty)
            {
                if (txtMaximum.Text != String.Empty)
                {
                    ticket.ReloadMinTreshold = decimal.Parse(txtMinimum.Text);
                    ticket.ReloadMaxTreshold = decimal.Parse(txtMaximum.Text);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtMaximum, "لطفاً حداکثر شارژ را انتخاب نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMinimum, "لطفاً حداقل شارژ را انتخاب نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }
    }
}
