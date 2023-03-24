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
    public partial class ReaderMessageMain : Form
    {
        private List<ReaderMessage> readerMessages = new List<ReaderMessage>();
        private string messageText;
        private bool messageRTL;

        public ReaderMessageMain()
        {
            InitializeComponent();
            BindReaderMessageData();
        }

        private void BindReaderMessageData()
        {
            readerMessages = new ReaderMessageBL().GetReaderMessageList();
            gridEXReaderMessage.DataSource = readerMessages;
        }

        private void gridEXReaderMessage_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(readerMessages, Utility.RefineText(gridEXReaderMessage.GetRow().Cells["ReaderMessageName"].Text), "ReaderMessageName"))
            {
                ReaderMessage readerMessage = new ReaderMessage(0, Utility.RefineText(gridEXReaderMessage.GetRow().Cells["ReaderMessageName"].Text), messageText, messageRTL);
                ReaderMessageBL readerMessageBL = new ReaderMessageBL();
                readerMessageBL.InsertReaderMessage(readerMessage);

                messageText = string.Empty;
                messageRTL = true;
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پیغام را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading , NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXReaderMessage_RecordAdded(object sender, EventArgs e)
        {
            BindReaderMessageData();
        }

        private void gridEXReaderMessage_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<ReaderMessage> readerMessageTemp = readerMessages.GetRange(0, readerMessages.Count);
            for (int i = 0; i < readerMessageTemp.Count; i++)
                if (readerMessageTemp[i].ReaderMessageID == int.Parse(gridEXReaderMessage.GetRow().Cells["ReaderMessageID"].Text))
                    readerMessageTemp.RemoveAt(i);

            if (!Utility.Exist(readerMessageTemp, Utility.RefineText(gridEXReaderMessage.GetRow().Cells["ReaderMessageName"].Text), "ReaderMessageName"))
            {
                short id = short.Parse(gridEXReaderMessage.GetRow().Cells["ReaderMessageID"].Text);
                string text = String.Empty;
                bool rtl = true;
                foreach (ReaderMessage rm in readerMessages)
                    if (rm.ReaderMessageID == id)
                    {
                        text = Utility.RefineText(rm.ReaderMeesageText);
                        rtl = rm.ReaderMessageRTL;
                    }

                ReaderMessage readerMessage = new ReaderMessage(id, Utility.RefineText(gridEXReaderMessage.GetRow().Cells["ReaderMessageName"].Text), text, rtl);
                ReaderMessageBL readerMessageBL = new ReaderMessageBL();
                readerMessageBL.UpdateReaderMessage(readerMessage);

                readerMessages = readerMessageBL.GetReaderMessageList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پیغام را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXReaderMessage_DeletingRecords(object sender, CancelEventArgs e)
        {
            ReaderMessageBL readerMessageBL = new ReaderMessageBL();

            readerMessageBL.DeleteReaderMessage(int.Parse(gridEXReaderMessage.GetRow().Cells["ReaderMessageID"].Text));
            readerMessages = readerMessageBL.GetReaderMessageList();
        }

        private void gridEXReaderMessage_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            short id = 0;
            string text = String.Empty;
            bool rtl = true;
            if(!String.IsNullOrWhiteSpace(gridEXReaderMessage.GetRow().Cells["ReaderMessageID"].Text))
                id = short.Parse(gridEXReaderMessage.GetRow().Cells["ReaderMessageID"].Text);
            
            if (id != 0)
                foreach (ReaderMessage readerMessage in readerMessages)
                    if (readerMessage.ReaderMessageID == id)
                    {
                        text = Utility.RefineText(readerMessage.ReaderMeesageText);
                        rtl = readerMessage.ReaderMessageRTL;
                    }
            int size = text.Length;
            for (int i = size; i <= 40; i++)
                text = text + " ";


            ReaderMessageText readerDialog = new ReaderMessageText(id, text, rtl);
            readerDialog.Owner = this;
            readerDialog.ShowDialog();
        }

        public void SetReaderMessageText(short id, string text, bool rtl)
        {
            if (id != 0)
            {
                int NO = -1;
                for (int i = 0; i < readerMessages.Count; i++)
                    if (readerMessages[i].ReaderMessageID == id)
                        NO = i;

                readerMessages[NO].ReaderMeesageText = text;
                readerMessages[NO].ReaderMessageRTL = rtl;
                string name = readerMessages[NO].ReaderMessageName;

                ReaderMessage readerMessage = new ReaderMessage(id, name, text, rtl);
                ReaderMessageBL readerMessageBL = new ReaderMessageBL();
                readerMessageBL.UpdateReaderMessage(readerMessage);
            }
            else
            {
                messageText = text;
                messageRTL = rtl;
            }

        }
    }
}
