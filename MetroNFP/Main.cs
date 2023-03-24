using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network.Presentation;
using Ticket.Presentation;
using ConvertDate;

namespace MetroNFP
{
    public partial class Main : Form
    {
        persianDate persiandate = new persianDate();
        Size bt_max_size = new Size(85, 85);
        Size bt_min_size = new Size(60, 60);

        public Main()
        {
            InitializeComponent();
            tsmi_BottomPnl.Image = global::MetroNFP.Properties.Resources.check2;
            tsmi_RightPnl.Image = global::MetroNFP.Properties.Resources.check2;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            lbl_S_Date.Text = persiandate.SD2Day(persiandate.M2S(DateTime.Now)) + "  " + persiandate.M2S(DateTime.Now);
            lbl_S_Month.Text = persiandate.MD2Day(DateTime.Now) + "  " + DateTime.Now.ToShortDateString();
        }

        #region Menu Events
        //*******************************************************************
        private void tsmi_Station_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(StationMain)))
                {
                    f.Activate();
                    return;
                }
            StationMain stationList = new StationMain();
            stationList.MdiParent = this;
            stationList.Show();
        }
        private void tsmi_RailRoad_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(RailRoadMain)))
                {
                    f.Activate();
                    return;
                }
            RailRoadMain railRoadList = new RailRoadMain();
            railRoadList.MdiParent = this;
            railRoadList.Show();
        }
        private void tsmi_OriginDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(ODMain)))
                {
                    f.Activate();
                    return;
                }
            ODMain stationList = new ODMain();
            stationList.MdiParent = this;
            stationList.Show();
        }
        //*******************************************************************

        //*******************************************************************
        private void tsmi_SectionFareProfile_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(SectionFareMain)))
                {
                    f.Activate();
                    return;
                }
            SectionFareMain sectionFare = new SectionFareMain();
            sectionFare.MdiParent = this;
            sectionFare.Show();
        }
        private void tsmi_DiscountRefundProfile_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(DiscountRefundMain)))
                {
                    f.Activate();
                    return;
                }
            DiscountRefundMain discountRefund = new DiscountRefundMain();
            discountRefund.MdiParent = this;
            discountRefund.Show();
        }
        private void tsmi_ReaderMessage_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(ReaderMessageMain)))
                {
                    f.Activate();
                    return;
                }
            ReaderMessageMain readerMessage = new ReaderMessageMain();
            readerMessage.MdiParent = this;
            readerMessage.Show();
        }
        private void tsmi_PRDMessage_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(PRDMessageMain)))
                {
                    f.Activate();
                    return;
                }
            PRDMessageMain prdMessage = new PRDMessageMain();
            prdMessage.MdiParent = this;
            prdMessage.Show();
        }
        private void tsmi_Fine_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(FineMain)))
                {
                    f.Activate();
                    return;
                }
            FineMain fine = new FineMain();
            fine.MdiParent = this;
            fine.Show();
        }
        private void tsmi_TransferProfile_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(TransferProfileMain)))
                {
                    f.Activate();
                    return;
                }
            TransferProfileMain transferProfile = new TransferProfileMain();
            transferProfile.MdiParent = this;
            transferProfile.Show();
        }
        private void tsmi_RejectCode_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(RejectCodeMain)))
                {
                    f.Activate();
                    return;
                }
            RejectCodeMain rejectCodeMain = new RejectCodeMain();
            rejectCodeMain.MdiParent = this;
            rejectCodeMain.Show();
        }
        private void tsmi_ProcessingAlgorithm_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(ProcessingAlgorithmMain)))
                {
                    f.Activate();
                    return;
                }
            ProcessingAlgorithmMain processingAlgorithmMain = new ProcessingAlgorithmMain();
            processingAlgorithmMain.MdiParent = this;
            processingAlgorithmMain.Show();
        }
        private void tsmi_TimeSlotProfile_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(TimeSlotProfileMain)))
                {
                    f.Activate();
                    return;
                }
            TimeSlotProfileMain timeSlotProfileMain = new TimeSlotProfileMain();
            timeSlotProfileMain.MdiParent = this;
            timeSlotProfileMain.Show();
        }
        private void tsmi_TicketDefinition_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(TicketMain)))
                {
                    f.Activate();
                    return;
                }
            TicketMain ticketMain = new TicketMain();
            ticketMain.MdiParent = this;
            ticketMain.Show();
        }
        private void tsmi_PrintingProfile_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(PrintingProfileMain)))
                {
                    f.Activate();
                    return;
                }
            PrintingProfileMain printingProfileMain = new PrintingProfileMain();
            printingProfileMain.MdiParent = this;
            printingProfileMain.Show();
        }
        private void tstmi_Holidays_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType().Equals(typeof(HolidaysMain)))
                {
                    f.Activate();
                    return;
                }
            HolidaysMain holidaysMain = new HolidaysMain();
            holidaysMain.MdiParent = this;
            holidaysMain.Show();
        }
        //*******************************************************************

        //*******************************************************************
        private void tsmi_RightPnl_Click(object sender, EventArgs e)
        {
            if (uiPanelRight.Closed)
            {
                uiPanelRight.Closed = false;
                tsmi_RightPnl.Image = global::MetroNFP.Properties.Resources.check2;
            }
            else
            {
                uiPanelRight.Closed = true;
                tsmi_RightPnl.Image = global::MetroNFP.Properties.Resources.X22;
            }
        }
        private void tsmi_BottomPnl_Click(object sender, EventArgs e)
        {
            if (uiPanelBottom.Closed)
            {
                uiPanelBottom.Closed = false;
                tsmi_BottomPnl.Image = global::MetroNFP.Properties.Resources.check2;
            }
            else
            {
                uiPanelBottom.Closed = true;
                tsmi_BottomPnl.Image = global::MetroNFP.Properties.Resources.X22;
            }
        }
        //*******************************************************************
        #endregion

        #region Dockable Panel Events
        private void bt_NetworkDefinition_Click(object sender, EventArgs e)
        {
            Base networkDefinition = new Base(Common.Utility.OperationKind.Insert);
            networkDefinition.NetworkAssign();
            WizardMain wizard = new WizardMain(networkDefinition.First());
            wizard.ShowDialog();
        }
        private void buttonTicketDefinition_Click(object sender, EventArgs e)
        {
            Base ticketDefinition = new Base(Common.Utility.OperationKind.Insert);
            ticketDefinition.TicketAssign(0, 0);
            WizardMain wizard = new WizardMain(ticketDefinition.First());
            wizard.ShowDialog();
        }
        #endregion

        #region Bottom Panel Events
        private void tmr_Time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_Exit.Visible = false;
            bt_Exit.Size = bt_max_size;
        }

        private void bt_Exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_Exit.Visible = true;
            bt_Exit.Size = bt_min_size;
        }

        private void bt_LogOFF_MouseEnter(object sender, EventArgs e)
        {
            lbl_LogOFF.Visible = false;
            bt_LogOFF.Size = bt_max_size;
        }

        private void bt_LogOFF_MouseLeave(object sender, EventArgs e)
        {
            lbl_LogOFF.Visible = true;
            bt_LogOFF.Size = bt_min_size;
        }
        #endregion
    }
}
