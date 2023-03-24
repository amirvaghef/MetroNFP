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
    public partial class Ticket1Wizard : MetroNFP.Base
    {
        public Ticket1Wizard()
        {
            InitializeComponent();

            if (data[Common.Utility.Constant.TicketInfo] != null)
            {
                Common.Ticket ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
                textBoxName.Text = ticket.TicketName;
                textBoxShortName.Text = ticket.TicketShortName;
            }
            textBoxName.Focus();
        }
        private void Common1Wizard_Load(object sender, EventArgs e)
        {
            EnabledDisableWizard();
        }
        private void EnabledDisableWizard()
        {
            if (Parent != null)
            {
                ((WizardMain)Parent.Parent).EnabledPrevious = false;
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
            if (data[Common.Utility.Constant.TicketInfo] == null)
            {
                List<Common.Ticket> tickets = new TicketBL().GetList();
                if (!Utility.Exist(tickets, Utility.RefineText(textBoxName.Text), "TicketName"))
                {
                    if (!Utility.Exist(tickets, Utility.RefineText(textBoxShortName.Text), "TicketShortName"))
                    {
                        Common.Ticket ticket = new Common.Ticket();
                        ticket.TicketName = Utility.RefineText(textBoxName.Text);
                        ticket.TicketShortName = Utility.RefineText(textBoxShortName.Text);
                        data.Add(Common.Utility.Constant.TicketInfo, ticket);
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBoxShortName, "لطفاً نام مختصر بلیت را با نامی غیر تکراری پر نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBoxName, "لطفاً نام بلیت را با نامی غیر تکراری پر نمائید");
                    return null;
                }
            }
            else
            {
                Common.Ticket ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
                List<Common.Ticket> tickets = new TicketBL().GetList();
                for (int i = 0; i < tickets.Count; i++)
                    if (tickets[i].TicketID == ticket.TicketID)
                        tickets.RemoveAt(i);

                if (!Utility.Exist(tickets, Utility.RefineText(textBoxName.Text), "TicketName"))
                {
                    if (!Utility.Exist(tickets, Utility.RefineText(textBoxShortName.Text), "TicketShortName"))
                    {
                        ticket.TicketName = Utility.RefineText(textBoxName.Text);
                        ticket.TicketShortName = Utility.RefineText(textBoxShortName.Text);
                        data[Common.Utility.Constant.TicketInfo] = ticket;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBoxShortName, "لطفاً نام مختصر بلیت را با نامی غیر تکراری پر نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBoxName, "لطفاً نام بلیت را با نامی غیر تکراری پر نمائید");
                    return null;
                }
            }
            return data[Common.Utility.Constant.TicketInfo];
        }
    }
}
