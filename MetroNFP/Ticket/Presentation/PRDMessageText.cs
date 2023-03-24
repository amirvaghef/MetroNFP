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

namespace Ticket.Presentation
{
    public partial class PRDMessageText : Form
    {
        private short ID;
        public PRDMessageText()
        {
            InitializeComponent();

            rbFarsi.Checked = true;

            List<PRDDynamicMessage> dynamicMessages = new PRDMessageBL().GetPRDDynamicMessageList();
            foreach (PRDDynamicMessage dynamicMessage in dynamicMessages)
            {
                lvDynamicMessage.Items.Add(dynamicMessage.PRDDynamicMessageName).SubItems.Add(dynamicMessage.PRDDynamicMessageData);
            }
        }

        public PRDMessageText(short id, string text, bool rtl)
        {
            InitializeComponent();

            List<PRDDynamicMessage> dynamicMessages = new PRDMessageBL().GetPRDDynamicMessageList();
            foreach (PRDDynamicMessage dynamicMessage in dynamicMessages)
            {
                lvDynamicMessage.Items.Add(dynamicMessage.PRDDynamicMessageName).SubItems.Add(dynamicMessage.PRDDynamicMessageData);
            }

            ID = id;

            if (rtl)
            {
                rbFarsi.Checked = true;
                txt1.Text = text[0].ToString();
                txt2.Text = text[1].ToString();
                txt3.Text = text[2].ToString();
                txt4.Text = text[3].ToString();
                txt5.Text = text[4].ToString();
                txt6.Text = text[5].ToString();
                txt7.Text = text[6].ToString();
                txt8.Text = text[7].ToString();
                txt9.Text = text[8].ToString();
                txt10.Text = text[9].ToString();
                txt11.Text = text[10].ToString();
                txt12.Text = text[11].ToString();
                txt13.Text = text[12].ToString();
                txt14.Text = text[13].ToString();
                txt15.Text = text[14].ToString();
                txt16.Text = text[15].ToString();
                txt17.Text = text[16].ToString();
                txt18.Text = text[17].ToString();
                txt19.Text = text[18].ToString();
                txt20.Text = text[19].ToString();
                txt21.Text = text[20].ToString();
                txt22.Text = text[21].ToString();
                txt23.Text = text[22].ToString();
                txt24.Text = text[23].ToString();
                txt25.Text = text[24].ToString();
                txt26.Text = text[25].ToString();
                txt27.Text = text[26].ToString();
                txt28.Text = text[27].ToString();
                txt29.Text = text[28].ToString();
                txt30.Text = text[29].ToString();
                txt31.Text = text[30].ToString();
                txt32.Text = text[31].ToString();
                /*txt33.Text = text[32].ToString();
                txt34.Text = text[33].ToString();
                txt35.Text = text[34].ToString();
                txt36.Text = text[35].ToString();
                txt37.Text = text[36].ToString();
                txt38.Text = text[37].ToString();
                txt39.Text = text[38].ToString();
                txt40.Text = text[39].ToString();*/
            }
            else
            //if(!rtl)
            {
                rbEnglish.Checked = true;

                txt1.Text = text[15].ToString();
                txt2.Text = text[14].ToString();
                txt3.Text = text[13].ToString();
                txt4.Text = text[12].ToString();
                txt5.Text = text[11].ToString();
                txt6.Text = text[10].ToString();
                txt7.Text = text[9].ToString();
                txt8.Text = text[8].ToString();
                txt9.Text = text[7].ToString();
                txt10.Text = text[6].ToString();
                txt11.Text = text[5].ToString();
                txt12.Text = text[4].ToString();
                txt13.Text = text[3].ToString();
                txt14.Text = text[2].ToString();
                txt15.Text = text[1].ToString();
                txt16.Text = text[0].ToString();
                txt17.Text = text[31].ToString();
                txt18.Text = text[30].ToString();
                txt19.Text = text[29].ToString();
                txt20.Text = text[28].ToString();
                txt21.Text = text[27].ToString();
                txt22.Text = text[26].ToString();
                txt23.Text = text[25].ToString();
                txt24.Text = text[24].ToString();
                txt25.Text = text[23].ToString();
                txt26.Text = text[22].ToString();
                txt27.Text = text[21].ToString();
                txt28.Text = text[20].ToString();
                txt29.Text = text[19].ToString();
                txt30.Text = text[18].ToString();
                txt31.Text = text[17].ToString();
                txt32.Text = text[16].ToString();
                /*txt33.Text = text[27].ToString();
                txt34.Text = text[26].ToString();
                txt35.Text = text[25].ToString();
                txt36.Text = text[24].ToString();
                txt37.Text = text[23].ToString();
                txt38.Text = text[22].ToString();
                txt39.Text = text[21].ToString();
                txt40.Text = text[20].ToString();*/
            }
        }

        private void rbFarsi_CheckedChanged(object sender, EventArgs e)
        {
            txt1.TabIndex = 1;
            txt2.TabIndex = 2;
            txt3.TabIndex = 3;
            txt4.TabIndex = 4;
            txt5.TabIndex = 5;
            txt6.TabIndex = 6;
            txt7.TabIndex = 7;
            txt8.TabIndex = 8;
            txt9.TabIndex = 9;
            txt10.TabIndex = 10;
            txt11.TabIndex = 11;
            txt12.TabIndex = 12;
            txt13.TabIndex = 13;
            txt14.TabIndex = 14;
            txt15.TabIndex = 15;
            txt16.TabIndex = 16;
            txt17.TabIndex = 17;
            txt18.TabIndex = 18;
            txt19.TabIndex = 19;
            txt20.TabIndex = 20;
            txt21.TabIndex = 21;
            txt22.TabIndex = 22;
            txt23.TabIndex = 23;
            txt24.TabIndex = 24;
            txt25.TabIndex = 25;
            txt26.TabIndex = 26;
            txt27.TabIndex = 27;
            txt28.TabIndex = 28;
            txt29.TabIndex = 29;
            txt30.TabIndex = 30;
            txt31.TabIndex = 31;
            txt32.TabIndex = 32;
            /*txt33.TabIndex = 33;
            txt34.TabIndex = 34;
            txt35.TabIndex = 35;
            txt36.TabIndex = 36;
            txt37.TabIndex = 37;
            txt38.TabIndex = 38;
            txt39.TabIndex = 39;
            txt40.TabIndex = 40;*/
            txt1.Focus();
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            txt1.TabIndex = 26;
            txt2.TabIndex = 15;
            txt3.TabIndex = 14;
            txt4.TabIndex = 13;
            txt5.TabIndex = 12;
            txt6.TabIndex = 11;
            txt7.TabIndex = 10;
            txt8.TabIndex = 9;
            txt9.TabIndex = 8;
            txt10.TabIndex = 7;
            txt11.TabIndex = 6;
            txt12.TabIndex = 5;
            txt13.TabIndex = 4;
            txt14.TabIndex = 3;
            txt15.TabIndex = 2;
            txt16.TabIndex = 1;
            txt17.TabIndex = 32;
            txt18.TabIndex = 31;
            txt19.TabIndex = 30;
            txt20.TabIndex = 29;
            txt21.TabIndex = 28;
            txt22.TabIndex = 27;
            txt23.TabIndex = 26;
            txt24.TabIndex = 25;
            txt25.TabIndex = 24;
            txt26.TabIndex = 23;
            txt27.TabIndex = 22;
            txt28.TabIndex = 21;
            txt29.TabIndex = 20;
            txt30.TabIndex = 19;
            txt31.TabIndex = 18;
            txt32.TabIndex = 17;
            //txt33.TabIndex = 28;
            //txt34.TabIndex = 27;
            //txt35.TabIndex = 26;
            //txt36.TabIndex = 25;
            //txt37.TabIndex = 24;
            //txt38.TabIndex = 23;
            //txt39.TabIndex = 22;
            //txt40.TabIndex = 21;
            txt16.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string text = String.Empty;
            if (rbFarsi.Checked)
                text = txt1.Text +
                       txt2.Text +
                       txt3.Text +
                       txt4.Text +
                       txt5.Text +
                       txt6.Text +
                       txt7.Text +
                       txt8.Text +
                       txt9.Text +
                       txt10.Text +
                       txt11.Text +
                       txt12.Text +
                       txt13.Text +
                       txt14.Text +
                       txt15.Text +
                       txt16.Text +
                       txt17.Text +
                       txt18.Text +
                       txt19.Text +
                       txt20.Text +
                       txt21.Text +
                       txt22.Text +
                       txt23.Text +
                       txt24.Text +
                       txt25.Text +
                       txt26.Text +
                       txt27.Text +
                       txt28.Text +
                       txt29.Text +
                       txt30.Text +
                       txt31.Text +
                       txt32.Text;
            //txt33.Text +
            //txt34.Text +
            //txt35.Text +
            //txt36.Text +
            //txt37.Text +
            //txt38.Text +
            //txt39.Text +
            //txt40.Text;
            else
                text = txt16.Text +
                       txt15.Text +
                       txt14.Text +
                       txt13.Text +
                       txt12.Text +
                       txt11.Text +
                       txt10.Text +
                       txt9.Text +
                       txt8.Text +
                       txt7.Text +
                       txt6.Text +
                       txt5.Text +
                       txt4.Text +
                       txt3.Text +
                       txt2.Text +
                       txt1.Text +
                       //txt40.Text +
                       //txt39.Text +
                       //txt38.Text +
                       //txt37.Text +
                       //txt36.Text +
                       //txt35.Text +
                       //txt34.Text +
                       //txt33.Text +
                       txt32.Text +
                       txt31.Text +
                       txt30.Text +
                       txt29.Text +
                       txt28.Text +
                       txt27.Text +
                       txt26.Text +
                       txt25.Text +
                       txt24.Text +
                       txt23.Text +
                       txt22.Text +
                       txt21.Text +
                       txt20.Text +
                       txt19.Text +
                       txt18.Text +
                       txt17.Text ;

            ((PRDMessageMain) Owner).SetPRDMessageText(ID, text, rbFarsi.Checked);
            this.Close();
        }
    }
}
