using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ticket.BussinesLogic;
using Common;
using Common.Utility;
using Janus.Windows.GridEX;

namespace Ticket.Presentation
{
    public partial class PRDMessageMain : Form
    {
        private List<PRDMessage> prdMessages = new List<PRDMessage>();
        private string messageText;
        private bool messageRTL;

        public PRDMessageMain()
        {
            InitializeComponent();
            BindPRDMessageData();
        }

        private void BindPRDMessageData()
        {
            prdMessages = new PRDMessageBL().GetPRDMessageList();
            gridEXPRDMessage.DataSource = prdMessages;
        }

        private void gridEXPRDMessage_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(prdMessages, Utility.RefineText(gridEXPRDMessage.GetRow().Cells["PRDMessageName"].Text), "PRDMessageName"))
            {
                PRDMessage prdMessage = new PRDMessage(0, Utility.RefineText(gridEXPRDMessage.GetRow().Cells["PRDMessageName"].Text), messageText, messageRTL);
                PRDMessageBL prdMessageBL = new PRDMessageBL();
                prdMessageBL.InsertPRDMessage(prdMessage);

                messageText = string.Empty;
                messageRTL = true;
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پیغام را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXPRDMessage_RecordAdded(object sender, EventArgs e)
        {
            BindPRDMessageData();
        }

        private void gridEXPRDMessage_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<PRDMessage> prdMessageTemp = prdMessages.GetRange(0, prdMessages.Count);
            for (int i = 0; i < prdMessageTemp.Count; i++)
                if (prdMessageTemp[i].PRDMessageID == int.Parse(gridEXPRDMessage.GetRow().Cells["PRDMessageID"].Text))
                    prdMessageTemp.RemoveAt(i);

            if (!Utility.Exist(prdMessageTemp, Utility.RefineText(gridEXPRDMessage.GetRow().Cells["PRDMessageName"].Text), "PRDMessageName"))
            {
                short id = short.Parse(gridEXPRDMessage.GetRow().Cells["PRDMessageID"].Text);
                string text = String.Empty;
                bool rtl = true;
                foreach (PRDMessage rm in prdMessages)
                    if (rm.PRDMessageID == id)
                    {
                        text = Utility.RefineText(rm.PRDMeesageText);
                        rtl = rm.PRDMessageRTL;
                    }

                PRDMessage prdMessage = new PRDMessage(id, Utility.RefineText(gridEXPRDMessage.GetRow().Cells["PRDMessageName"].Text), text, rtl);
                PRDMessageBL prdMessageBL = new PRDMessageBL();
                prdMessageBL.UpdatePRDMessage(prdMessage);

                prdMessages = prdMessageBL.GetPRDMessageList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پیغام را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXPRDMessage_DeletingRecords(object sender, CancelEventArgs e)
        {
            PRDMessageBL prdMessageBL = new PRDMessageBL();

            prdMessageBL.DeletePRDMessage(int.Parse(gridEXPRDMessage.GetRow().Cells["PRDMessageID"].Text));
            prdMessages = prdMessageBL.GetPRDMessageList();
        }

        private void gridEXPRDMessage_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            short id = 0;
            string text = String.Empty;
            bool rtl = true;
            if(!String.IsNullOrWhiteSpace(gridEXPRDMessage.GetRow().Cells["PRDMessageID"].Text))
                id = short.Parse(gridEXPRDMessage.GetRow().Cells["PRDMessageID"].Text);
            
            if (id != 0)
                foreach (PRDMessage prdMessage in prdMessages)
                    if (prdMessage.PRDMessageID == id)
                    {
                        text = Utility.RefineText(prdMessage.PRDMeesageText);
                        rtl = prdMessage.PRDMessageRTL;
                    }
            int size = text.Length;
            for (int i = size; i <= 32; i++)
                text = text + " ";


            PRDMessageText prdDialog = new PRDMessageText(id, text, rtl);
            prdDialog.Owner = this;
            prdDialog.ShowDialog();
        }

        public void SetPRDMessageText(short id, string text, bool rtl)
        {
            if (id != 0)
            {
                int NO = -1;
                for (int i = 0; i < prdMessages.Count; i++)
                    if (prdMessages[i].PRDMessageID == id)
                        NO = i;

                prdMessages[NO].PRDMeesageText = text;
                prdMessages[NO].PRDMessageRTL = rtl;
                string name = prdMessages[NO].PRDMessageName;

                PRDMessage prdMessage = new PRDMessage(id, name, text, rtl);
                PRDMessageBL prdMessageBL = new PRDMessageBL();
                prdMessageBL.UpdatePRDMessage(prdMessage);
            }
            else
            {
                messageText = text;
                messageRTL = rtl;
            }

        }
    }
}