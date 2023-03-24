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
using Janus.Windows.GridEX.EditControls;

namespace Ticket.Presentation
{
    public enum ButtonType
    {
        None,
        StaticMessage,
        DynamicMessage
    }

    public enum Direction
    {
        ltr,
        rtl
    }

    public partial class PrintingProfileMain : Form
    {
        const int plCard_Width = 432;
        const int plCard_Height = 300;

        private List<PrintingStaticMessage> staticMessages = new System.Collections.Generic.List<PrintingStaticMessage>();
        private List<PrintingProfile> printingProfiles = new System.Collections.Generic.List<PrintingProfile>();
        private List<PrintingDynamicMessage> dynamicMessages = new System.Collections.Generic.List<PrintingDynamicMessage>();

        private PrintingProfile printingProfile = new PrintingProfile();
        private ButtonType buttonType = ButtonType.None;
        Font font;

        public PrintingProfileMain()
        {
            InitializeComponent();

            if (this.RightToLeft == RightToLeft)
                rbRTL.Checked = true;
            else
                rbLTR.Checked = true;

            font = new Font(this.Font.FontFamily, this.Font.Size);
            plCard.Size = new Size(plCard_Width, plCard_Height);

            BindPrintingProfileData();
        }
        public void BindPrintingProfileData()
        {
            GridEXValueListItemCollection valueList = gridEXPrintingProfile.Tables[0].Columns["PrintingProfileOperationKind"].ValueList;
            valueList.Add(0, "صدور");
            valueList.Add(1, "اعتبارسنجی");

            printingProfiles = new PrintingProfileBL().GetList();
            gridEXPrintingProfile.DataSource = printingProfiles;

            tempCombo.DataSource = new PrintingProfileBL().GetVariableList();
            //tempCombo.DisplayMember = "PrintingDynamicVariableName";
            //tempCombo.ValueMember = "PrintingDynamicVariableID";
        }
        public void BindStaticAndDynamicMessages()
        {
            plCard.Controls.Clear();
            foreach (PrintingStaticMessage staticMessage in staticMessages)
            {
                Label label = new Label();
                label.RightToLeft = staticMessage.Direction ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
                font = new System.Drawing.Font(staticMessage.Font, staticMessage.FontSize);
                label.Font = font;
                //label.BackColor = Color.BlueViolet;
                label.Text = staticMessage.PrintingStaticMessageData;
                label.Location = new Point(staticMessage.X, staticMessage.Y);
                plCard.Controls.Add(label);
            }
            foreach (PrintingDynamicMessage dynamicMessage in dynamicMessages)
            {
                Label label = new Label();
                label.RightToLeft = dynamicMessage.Direction ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
                font = new System.Drawing.Font(dynamicMessage.Font, dynamicMessage.FontSize);
                label.Font = font;
                //label.BackColor = Color.BlueViolet;
                label.Text = dynamicMessage.PrintingDynamicVariableData;
                label.Location = new Point(dynamicMessage.X, dynamicMessage.Y);
                plCard.Controls.Add(label);
            }
        }

        #region DiscountRefundProfile Grid
        private void gridEXSectionFareProfile_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEXPrintingProfile.Row >= 0)
            {
                if (!String.IsNullOrWhiteSpace(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text))
                {
                    short PrintingProfileID = short.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text);
                    foreach (PrintingProfile printingProfileTemp in printingProfiles)
                        if (printingProfileTemp.PrintingProfileID == PrintingProfileID)
                        {
                            printingProfile.PrintingProfileID = printingProfileTemp.PrintingProfileID;
                            printingProfile.PrintingProfileName = printingProfileTemp.PrintingProfileName;
                            printingProfile.PrintingProfileOperationKind = printingProfileTemp.PrintingProfileOperationKind;

                            dynamicMessages = printingProfileTemp.PrintingDynamicMessages;
                            staticMessages = printingProfileTemp.PrintingStaticMessages;
                            BindStaticAndDynamicMessages();
                            break;
                        }
                }
            }
        }

        private void gridEXSectionFareProfile_AddingRecord(object sender, CancelEventArgs e)
        {
            if (!Utility.Exist(printingProfiles, Utility.RefineText(gridEXPrintingProfile.GetRow().Cells["PrintingProfileName"].Text), "PrintingProfileName"))
            {
                printingProfile = new PrintingProfile();
                printingProfile.PrintingProfileName = Utility.RefineText(gridEXPrintingProfile.GetRow().Cells["PrintingProfileName"].Text);
                printingProfile.PrintingProfileOperationKind = bool.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileOperationKind"].Value.ToString());

                new PrintingProfileBL().Insert(printingProfile, true);
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_RecordAdded(object sender, EventArgs e)
        {
            BindPrintingProfileData();
        }

        private void gridEXSectionFareProfile_UpdatingRecord(object sender, CancelEventArgs e)
        {
            List<PrintingProfile> printingProfilesTemp = printingProfiles.GetRange(0, printingProfiles.Count);
            for (int i = 0; i < printingProfilesTemp.Count; i++)
                if (printingProfilesTemp[i].PrintingProfileID == int.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text))
                    printingProfilesTemp.RemoveAt(i);

            if (!Utility.Exist(printingProfilesTemp, Utility.RefineText(gridEXPrintingProfile.GetRow().Cells["PrintingProfileName"].Text), "PrintingProfileName"))
            {
                printingProfile = new PrintingProfile();
                printingProfile.PrintingProfileID = short.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text);
                printingProfile.PrintingProfileName = Utility.RefineText(gridEXPrintingProfile.GetRow().Cells["PrintingProfileName"].Text);
                printingProfile.PrintingProfileOperationKind = bool.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileOperationKind"].Value.ToString());

                PrintingProfileBL printingProfileBL = new PrintingProfileBL();
                printingProfileBL.Update(printingProfile);
                printingProfiles = printingProfileBL.GetList();
            }
            else
            {
                NFPMessageBox.Show("لطفاً نام پروفایل را با نامی غیر تکراری پر نمائید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
                e.Cancel = true;
            }
        }

        private void gridEXSectionFareProfile_DeletingRecords(object sender, CancelEventArgs e)
        {
            PrintingProfileBL printingProfileBL = new PrintingProfileBL();

            printingProfileBL.Delete(short.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text));
            printingProfiles = printingProfileBL.GetList();
        }
        #endregion

        private void btFontMessage_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                foreach (Control ctrl in plCard.Controls)
                    if (ctrl.GetType() == new TextBox().GetType())
                    {
                        ctrl.Font = font;
                        break;
                    }
            }
        }

        private void btStaticMessage_Click(object sender, EventArgs e)
        {
            buttonType = ButtonType.StaticMessage;
        }

        private void btDynamicMessage_Click(object sender, EventArgs e)
        {
            buttonType = ButtonType.DynamicMessage;
        }

        private void plCard_MouseEnter(object sender, EventArgs e)
        {
            if (buttonType == ButtonType.DynamicMessage || buttonType == ButtonType.StaticMessage)
                plCard.Cursor = Cursors.Cross;
        }

        private void plCard_MouseClick(object sender, MouseEventArgs e)
        {
            if (buttonType == ButtonType.StaticMessage)
            {
                PrintingStaticMessage tempStatic = new PrintingStaticMessage();

                foreach (PrintingStaticMessage stmsg in staticMessages)
                    if (String.IsNullOrEmpty(stmsg.PrintingStaticMessageData))
                    {
                        staticMessages.Remove(stmsg);
                        break;
                    }

                TextBox tempText = new TextBox();
                foreach (Control ctrl in plCard.Controls)
                    if (ctrl.GetType() == new TextBox().GetType())
                    {
                        tempText = (TextBox)ctrl;
                        break;
                    }

                if (font != null)
                    tempText.Font = font;

                if (rbLTR.Checked)
                {

                    tempStatic.X = e.X;
                    if (e.X + tempText.Size.Width >= plCard_Width) tempStatic.X = plCard_Width - tempText.Size.Width;
                    tempStatic.Y = e.Y;
                    tempStatic.Direction = false;
                    tempText.RightToLeft = RightToLeft.No;
                }
                else
                {
                    tempStatic.X = e.X - tempText.Size.Width;
                    if (tempStatic.X < 0) tempStatic.X = 0;
                    tempStatic.Y = e.Y;
                    tempStatic.Direction = true;
                    tempText.RightToLeft = RightToLeft.Yes;
                }

                if (tempStatic.Y + tempText.Size.Height >= plCard.Size.Height) tempStatic.Y = plCard.Size.Height - tempText.Size.Height;

                tempText.Location = new Point(tempStatic.X, tempStatic.Y);

                tempText.KeyDown += new KeyEventHandler(tempText_KeyDown);
                plCard.Controls.Add(tempText);
                staticMessages.Add(tempStatic);
                tempText.Focus();
            }

            if (buttonType == ButtonType.DynamicMessage)
            {
                PrintingDynamicMessage tempDynamic = new PrintingDynamicMessage();

                foreach (PrintingDynamicMessage dymsg in dynamicMessages)
                    if (String.IsNullOrEmpty(dymsg.PrintingDynamicVariableData))
                    {
                        dynamicMessages.Remove(dymsg);
                        break;
                    }

                if (font != null)
                    tempCombo.Font = font;

                if (rbLTR.Checked)
                {
                    tempDynamic.X = e.X;
                    if (e.X + tempCombo.Size.Width >= plCard_Width) tempDynamic.X = plCard_Width - tempCombo.Size.Width;
                    tempDynamic.Y = e.Y;
                    tempDynamic.Direction = false;
                    tempCombo.RightToLeft = RightToLeft.No;
                }
                else
                {
                    tempDynamic.X = e.X - tempCombo.Size.Width;
                    if (tempDynamic.X < 0) tempDynamic.X = 0;
                    tempDynamic.Y = e.Y;
                    tempDynamic.Direction = true;
                    tempCombo.RightToLeft = RightToLeft.Yes;
                }

                if (tempDynamic.Y + tempCombo.Size.Height >= plCard.Size.Height) tempDynamic.Y = plCard.Size.Height - tempCombo.Size.Height;

                tempCombo.Location = new Point(tempDynamic.X, tempDynamic.Y);

                tempCombo.Visible = true;
                plCard.Controls.Add(tempCombo);
                dynamicMessages.Add(tempDynamic);
                tempCombo.Focus();
            }
        }

        void tempCombo_ValueChanged(object sender, EventArgs e)
        {
            PrintingDynamicMessage tmpDYMSG = new PrintingDynamicMessage();
            foreach (PrintingDynamicMessage dymsg in dynamicMessages)
                if (String.IsNullOrEmpty(dymsg.PrintingDynamicVariableData))
                {
                    tmpDYMSG = dymsg;
                    dynamicMessages.Remove(dymsg);
                    break;
                }

            tmpDYMSG.fk_PrintingProfileID = short.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text);
            tmpDYMSG.PrintingDynamicVariableID = short.Parse(tempCombo.DropDownList.GetRow().Cells["PrintingDynamicVariableID"].Text);
            tmpDYMSG.Font = tempCombo.Font.Name;
            tmpDYMSG.FontSize = tempCombo.Font.Size;

            tempCombo.Visible = false;
            panel1.Controls.Add(tempCombo);

            Label label = new Label();
            label.RightToLeft = tempCombo.RightToLeft;
            label.Font = tempCombo.Font;
            label.Text = tempCombo.DropDownList.GetRow().Cells["PrintingDynamicVariableData"].Text;
            label.Location = new Point(tmpDYMSG.X, tmpDYMSG.Y);
            if (!(String.IsNullOrEmpty(label.Text)))
            {
                plCard.Controls.Add(label);
                dynamicMessages.Add(tmpDYMSG);
                if (printingProfile.PrintingDynamicMessages == null)
                    printingProfile.PrintingDynamicMessages = new List<PrintingDynamicMessage>();
                printingProfile.PrintingDynamicMessages.Add(tmpDYMSG);
            }
        }
        private void tempCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tempCombo.Visible = false;
                panel1.Controls.Add(tempCombo);
            }
        }

        private void tempText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ((TextBox)sender).Dispose();

            if (e.KeyCode == Keys.Enter)
            {
                PrintingStaticMessage tmpSTMSG = new PrintingStaticMessage();
                foreach (PrintingStaticMessage stmsg in staticMessages)
                    if (String.IsNullOrEmpty(stmsg.PrintingStaticMessageData))
                    {
                        tmpSTMSG = stmsg;
                        staticMessages.Remove(stmsg);
                        break;
                    }

                tmpSTMSG.fk_PrintingProfileID = short.Parse(gridEXPrintingProfile.GetRow().Cells["PrintingProfileID"].Text);
                tmpSTMSG.PrintingStaticMessageData = ((TextBox)sender).Text;
                tmpSTMSG.Font = ((TextBox)sender).Font.Name;
                tmpSTMSG.FontSize = ((TextBox)sender).Font.Size;
                ((TextBox)sender).Dispose();

                Label label = new Label();
                label.RightToLeft = ((TextBox)sender).RightToLeft;
                label.Font = ((TextBox)sender).Font;
                label.Text = tmpSTMSG.PrintingStaticMessageData;
                label.Location = new Point(tmpSTMSG.X, tmpSTMSG.Y);
                if (!(String.IsNullOrEmpty(label.Text)))
                {
                    plCard.Controls.Add(label);
                    staticMessages.Add(tmpSTMSG);
                    if (printingProfile.PrintingStaticMessages == null)
                        printingProfile.PrintingStaticMessages = new List<PrintingStaticMessage>();
                    printingProfile.PrintingStaticMessages.Add(tmpSTMSG);
                }
            }
        }

        private void rbLTR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLTR.Checked)
            {
                foreach (Control ctrl in plCard.Controls)
                    if (ctrl.GetType() == new TextBox().GetType())
                    {
                        ctrl.RightToLeft = RightToLeft.No;
                        break;
                    }
            }

            if (rbRTL.Checked)
            {
                foreach (Control ctrl in plCard.Controls)
                    if (ctrl.GetType() == new TextBox().GetType())
                    {
                        ctrl.RightToLeft = RightToLeft.Yes;
                        break;
                    }
            }

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if ((printingProfile.PrintingStaticMessages != null) || (printingProfile.PrintingDynamicMessages != null))
            {
                new PrintingProfileBL().Insert(printingProfile, false);
                if (printingProfile.PrintingDynamicMessages != null)
                    printingProfile.PrintingDynamicMessages.Clear();
                if (printingProfile.PrintingStaticMessages != null)
                    printingProfile.PrintingStaticMessages.Clear();

                NFPMessageBox.Show("عملیات با موفقیت انجام شد", "پیام", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Information, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
            }
            else
                NFPMessageBox.Show("شما داده ای برای ذخیره کردن ندارید", "خطا", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            plCard.Controls.Clear();
            staticMessages.Clear();
            dynamicMessages.Clear();
            if (printingProfile.PrintingDynamicMessages != null)
                printingProfile.PrintingDynamicMessages.Clear();
            if (printingProfile.PrintingStaticMessages != null)
                printingProfile.PrintingStaticMessages.Clear();
        }



    }
}
