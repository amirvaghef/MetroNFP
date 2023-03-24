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
    public partial class Ticket4Wizard : MetroNFP.Base
    {
        Common.Ticket ticket = new Common.Ticket();
        public Ticket4Wizard()
        {
            InitializeComponent();

            ticket = (Common.Ticket)data[Common.Utility.Constant.TicketInfo];
            BindDropDowns();

            cmbEnterAlgorithm.Focus();
        }
        private void BindDropDowns()
        {
            cmbEnterAlgorithm.DataSource = new ProcessingAlgorithmProfileBL().GetList();
            cmbExitAlgorithm.DataSource = new ProcessingAlgorithmProfileBL().GetList();
            cmbTransferProfile.DataSource = new TransferProfileBL().GetTransferProfileList();

            if (ticket.fk_EntryProcessingAlgorithmID != 0)
            {
                cmbEnterAlgorithm.SelectedValue = ticket.fk_EntryProcessingAlgorithmID;
                cmbExitAlgorithm.SelectedValue = ticket.fk_ExitProcessingAlgorithmID;
                cmbTransferProfile.SelectedValue = ticket.fk_TransferProfileID;
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
            if (cmbEnterAlgorithm.SelectedIndex != -1)
            {
                if (cmbExitAlgorithm.SelectedIndex != -1)
                {
                    if (cmbTransferProfile.SelectedIndex != -1)
                    {
                        ticket.fk_ExitProcessingAlgorithmID = short.Parse(cmbExitAlgorithm.SelectedValue.ToString());
                        ticket.fk_EntryProcessingAlgorithmID = short.Parse(cmbEnterAlgorithm.SelectedValue.ToString());
                        ticket.fk_TransferProfileID = short.Parse(cmbTransferProfile.SelectedValue.ToString());
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(cmbTransferProfile, "لطفاً قانون تردد را انتخاب نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbExitAlgorithm, "لطفاً الگوریتم خروج را انتخاب نمائید");
                    return null;
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbEnterAlgorithm, "لطفاً الگوریتم ورود را انتخاب نمائید");
                return null;
            }

            data[Common.Utility.Constant.TicketInfo] = ticket;
            return data[Common.Utility.Constant.TicketInfo];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ProcessingAlgorithmMain().ShowDialog();
            cmbEnterAlgorithm.DataSource = new ProcessingAlgorithmProfileBL().GetList();
            cmbExitAlgorithm.DataSource = new ProcessingAlgorithmProfileBL().GetList();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TransferProfileMain().ShowDialog();
            cmbTransferProfile.DataSource = new TransferProfileBL().GetTransferProfileList();
        }
    }
}
