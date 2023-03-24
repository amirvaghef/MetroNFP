using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Ticket.BussinesLogic;
using Common;
using Common.Utility;

namespace Ticket.Presentation
{
    public partial class ProcessingAlgorithmMain : Form
    {
        List<ProcessingAlgorithmProfile> processingAlgorithmProfiles = new List<ProcessingAlgorithmProfile>();
        List<ProcessingAlgorithm> processingAlgorithms = new List<ProcessingAlgorithm>();
        public ProcessingAlgorithmMain()
        {
            InitializeComponent();
            BindProcessingAlgorithmData();
        }
        private void BindProcessingAlgorithmData()
        {
            GridEXValueListItemCollection valueList = gridEXProcessingAlgorithmProfile.Tables[0].Columns["fk_ReaderMessageID"].ValueList;
            GridEXValueListItemCollection valueList1 = gridEXProcessingAlgorithm.Tables[0].Columns["fk_ErrorReaderMessage"].ValueList;
            GridEXValueListItemCollection valueList2 = gridEXProcessingAlgorithm.Tables[0].Columns["fk_EntryReaderMessage"].ValueList;
            List<ReaderMessage> readerMessage = new List<ReaderMessage>();
            readerMessage = new ReaderMessageBL().GetReaderMessageList();
            foreach (ReaderMessage rm in readerMessage)
            {
                valueList.Add(rm.ReaderMessageID, rm.ReaderMessageName);
                valueList1.Add(rm.ReaderMessageID, rm.ReaderMessageName);
                valueList2.Add(rm.ReaderMessageID, rm.ReaderMessageName);
            }
            

            valueList = gridEXProcessingAlgorithm.Tables[0].Columns["fk_ProcessingAlgorithmOperationKindID"].ValueList;
            List<ProcessingAlgorithmOperationKind> processingAlgorithmOperationKind = new List<ProcessingAlgorithmOperationKind>();
            processingAlgorithmOperationKind = new ProcessingAlgorithmOperationKindBL().GetList();
            foreach (ProcessingAlgorithmOperationKind paop in processingAlgorithmOperationKind)
                valueList.Add(paop.ProcessingAlgorithmOperationKindID, paop.ProcessingAlgorithmOperationKindName);

            valueList = gridEXProcessingAlgorithm.Tables[0].Columns["fk_ProcessingID"].ValueList;
            List<Processing> processing = new List<Processing>();
            processing = new ProcessingBL().GetList();
            foreach (Processing p in processing)
                valueList.Add(p.ProcessingID, p.ProcessingName);

            valueList = gridEXProcessingAlgorithm.Tables[0].Columns["fk_RejectCodeID"].ValueList;
            List<RejectCode> rejectCode = new List<RejectCode>();
            rejectCode = new RejectCodeBL().GetRejectCodeList();
            foreach (RejectCode rej in rejectCode)
                valueList.Add(rej.RejectCodeID, rej.RejectCodeName);

            processingAlgorithmProfiles = new ProcessingAlgorithmProfileBL().GetList();
            gridEXProcessingAlgorithmProfile.DataSource = processingAlgorithmProfiles;
        }

        #region ProcessingAlgorithmProfile Grid
        private void gridEXProcessingAlgorithmProfile_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXProcessingAlgorithmProfile.Row >= 0)
            {
                if (!String.IsNullOrWhiteSpace(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text))
                {
                    int ProcessingAlgorithmProfileID = int.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text);
                    foreach (ProcessingAlgorithmProfile processingAlgorithmProfile in processingAlgorithmProfiles)
                        if (processingAlgorithmProfile.ProcessingAlgorithmProfileID == ProcessingAlgorithmProfileID)
                        {
                            processingAlgorithms = processingAlgorithmProfile.ProcessingAlgorithms;
                            gridEXProcessingAlgorithm.DataSource = processingAlgorithms;
                            break;
                        }
                }
            }
        }

        private void gridEXProcessingAlgorithmProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(processingAlgorithmProfiles, Utility.RefineText(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text), "ProcessingAlgorithmProfileName"))
            {
                ProcessingAlgorithmProfile processingAlgorithmProfile = new ProcessingAlgorithmProfile(0, Utility.RefineText(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text), short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["fk_ReaderMessageID"].Value.ToString()), null);
                ProcessingAlgorithmProfileBL processingAlgorithmProfileBL = new ProcessingAlgorithmProfileBL();
                processingAlgorithmProfileBL.InsertProcessingAlgorithmProfile(processingAlgorithmProfile);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXProcessingAlgorithmProfile_RecordAdded(object sender, EventArgs e)
        {
            BindProcessingAlgorithmData();
        }

        private void gridEXProcessingAlgorithmProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<ProcessingAlgorithmProfile> processingAlgorithmProfilesTemp = processingAlgorithmProfiles.GetRange(0, processingAlgorithmProfiles.Count);
            for (int i = 0; i < processingAlgorithmProfilesTemp.Count; i++)
                if (processingAlgorithmProfilesTemp[i].ProcessingAlgorithmProfileID == int.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text))
                    processingAlgorithmProfilesTemp.RemoveAt(i);

            if (!Utility.Exist(processingAlgorithmProfilesTemp, Utility.RefineText(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text), "ProcessingAlgorithmProfileName"))
            {
                ProcessingAlgorithmProfile processingAlgorithmProfile = new ProcessingAlgorithmProfile(short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text), Utility.RefineText(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text), short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["fk_ReaderMessageID"].Value.ToString()), null);
                ProcessingAlgorithmProfileBL processingAlgorithmProfileBL = new ProcessingAlgorithmProfileBL();
                processingAlgorithmProfileBL.UpdateProcessingAlgorithmProfile(processingAlgorithmProfile);

                processingAlgorithmProfiles = processingAlgorithmProfileBL.GetList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        //private void gridEXProcessingAlgorithmProfile_DeletingRecords(object sender, CancelEventArgs e)
        //{
        //    ProcessingAlgorithmProfileBL processingAlgorithmProfileBL = new ProcessingAlgorithmProfileBL();

        //    processingAlgorithmProfileBL.DeleteProcessingAlgorithmProfile(int.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text));
        //    processingAlgorithmProfiles = processingAlgorithmProfileBL.GetList();
        //}
        #endregion

        #region ProcessingAlgorithm Grid
        private void gridEXProcessingAlgorithm_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(processingAlgorithms, gridEXProcessingAlgorithm.GetRow().Cells["Sequence"].Text, "Sequence") &&
                !Utility.Exist(processingAlgorithms, gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingAlgorithmOperationKindID"].Value.ToString(), "fk_ProcessingAlgorithmOperationKindID"))
            {
                List<ProcessingAlgorithm> procAlgorithms = new List<ProcessingAlgorithm>();
                procAlgorithms.Add(new ProcessingAlgorithm(short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingAlgorithmOperationKindID"].Value.ToString()), 
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["Sequence"].Text), short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingID"].Value.ToString()), 
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_RejectCodeID"].Value.ToString()), short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ErrorReaderMessage"].Value.ToString()), 
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_EntryReaderMessage"].Value.ToString())));

                List<ProcessingAlgorithmProfile> processingAlgorithmProfileList = new List<ProcessingAlgorithmProfile>();
                processingAlgorithmProfileList.Add(new ProcessingAlgorithmProfile(short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text), 
                    gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text, 
                    short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["fk_ReaderMessageID"].Value.ToString()), procAlgorithms));
                new ProcessingAlgorithmProfileBL().InsertProcessingAlgorithm(processingAlgorithmProfileList);
            }
            else
            {
                NFPMessageBox.Show("لطفاً شماره توالی و نوع عملیات را با عددی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXProcessingAlgorithm_RecordAdded(object sender, EventArgs e)
        {
            ProcessingAlgorithmProfileBL processingAlgorithmProfileBL = new ProcessingAlgorithmProfileBL();

            processingAlgorithmProfiles = processingAlgorithmProfileBL.GetList();
            foreach (ProcessingAlgorithmProfile processingAlgorithmProfile in processingAlgorithmProfiles)
                if (processingAlgorithmProfile.ProcessingAlgorithmProfileID == int.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text))
                {
                    processingAlgorithms = processingAlgorithmProfile.ProcessingAlgorithms;
                    gridEXProcessingAlgorithm.DataSource = processingAlgorithmProfile.ProcessingAlgorithms;
                    break;
                }
        }

        private void gridEXProcessingAlgorithm_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<ProcessingAlgorithm> processingAlgorithmsTemp = processingAlgorithms.GetRange(0, processingAlgorithms.Count);
            for (int i = 0; i < processingAlgorithmsTemp.Count; i++)
                if (processingAlgorithmsTemp[i].Sequence == int.Parse(gridEXProcessingAlgorithm.GetRow().Cells["OldSequence"].Text) &&
                    processingAlgorithmsTemp[i].fk_ProcessingAlgorithmOperationKindID == short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["Oldfk_ProcessingAlgorithmOperationKindID"].Value.ToString()))
                    processingAlgorithmsTemp.RemoveAt(i);

            if (!Utility.Exist(processingAlgorithmsTemp, gridEXProcessingAlgorithm.GetRow().Cells["Sequence"].Value.ToString(), "Sequence") &&
                !Utility.Exist(processingAlgorithmsTemp, gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingAlgorithmOperationKindID"].Value.ToString(), "fk_ProcessingAlgorithmOperationKindID"))
            {
                List<ProcessingAlgorithm> processingAlgorithm = new List<ProcessingAlgorithm>();
                processingAlgorithm.Add(new ProcessingAlgorithm(short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingAlgorithmOperationKindID"].Value.ToString()),
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["Sequence"].Text), short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ProcessingID"].Value.ToString()),
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_RejectCodeID"].Value.ToString()), short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_ErrorReaderMessage"].Value.ToString()),
                    short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["fk_EntryReaderMessage"].Value.ToString())));

                ProcessingAlgorithmProfile processingAlgorithmProfile = new ProcessingAlgorithmProfile(short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text),
                    gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileName"].Text,
                    short.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["fk_ReaderMessageID"].Value.ToString()), processingAlgorithm);
                new ProcessingAlgorithmProfileBL().UpdateProcessingAlgorithm(processingAlgorithmProfile, short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["Oldfk_ProcessingAlgorithmOperationKindID"].Value.ToString()), short.Parse(gridEXProcessingAlgorithm.GetRow().Cells["OldSequence"].Text));

                processingAlgorithmProfiles = new ProcessingAlgorithmProfileBL().GetList();

                foreach (ProcessingAlgorithmProfile processingAlgorithmProfileTemp in processingAlgorithmProfiles)
                    if (processingAlgorithmProfileTemp.ProcessingAlgorithmProfileID == int.Parse(gridEXProcessingAlgorithmProfile.GetRow().Cells["ProcessingAlgorithmProfileID"].Text))
                    {
                        processingAlgorithms = processingAlgorithmProfileTemp.ProcessingAlgorithms;
                        break;
                    }
            }
            else
            {
                NFPMessageBox.Show("لطفاً شماره توالی و نوع عملیات را با عددی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXProcessingAlgorithm_DeletingRecords(object sender, CancelEventArgs e)
        {
            ProcessingAlgorithmProfileBL processingAlgorithmProfileBL = new ProcessingAlgorithmProfileBL();

            processingAlgorithmProfileBL.DeleteProcessingAlgorithm(
                short.Parse(gridEXProcessingAlgorithm.GetRow(gridEXProcessingAlgorithm.Row).Cells["Oldfk_ProcessingAlgorithmOperationKindID"].Text), 
                short.Parse(gridEXProcessingAlgorithmProfile.GetRow(gridEXProcessingAlgorithmProfile.Row).Cells["ProcessingAlgorithmProfileID"].Text), 
                short.Parse(gridEXProcessingAlgorithm.GetRow(gridEXProcessingAlgorithm.Row).Cells["OldSequence"].Text));
            processingAlgorithmProfiles = processingAlgorithmProfileBL.GetList();
        }
        #endregion

        #region LinksClicked
        private void llPRDMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(ReaderMessageMain)))
                {
                    f.Activate();
                    return;
                }
            ReaderMessageMain readerMessage = new ReaderMessageMain();
            readerMessage.MdiParent = MdiParent;
            readerMessage.Show();
        }

        private void llbRejectCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(RejectCodeMain)))
                {
                    f.Activate();
                    return;
                }
            RejectCodeMain rejectCode = new RejectCodeMain();
            rejectCode.MdiParent = MdiParent;
            rejectCode.Show();
        }

        private void llbErrorMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(ReaderMessageMain)))
                {
                    f.Activate();
                    return;
                }
            ReaderMessageMain readerMessage = new ReaderMessageMain();
            readerMessage.MdiParent = MdiParent;
            readerMessage.Show();
        }

        private void llbEnterMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                if (f.GetType().Equals(typeof(ReaderMessageMain)))
                {
                    f.Activate();
                    return;
                }
            ReaderMessageMain readerMessage = new ReaderMessageMain();
            readerMessage.MdiParent = MdiParent;
            readerMessage.Show();
        } 
        #endregion
    }
}
