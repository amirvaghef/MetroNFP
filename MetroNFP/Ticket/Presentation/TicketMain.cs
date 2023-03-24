using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ticket.BussinesLogic;
using System.Data.SqlClient;
using System.Collections;
using MetroNFP;
using Common.Utility;

namespace Ticket.Presentation
{
    public partial class TicketMain : Form
    {
        public TicketMain()
        {
            InitializeComponent();
            dataGridViewTicketList.DataSource = new TicketBL().GetList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Base ticketDefinition = new Base(Common.Utility.OperationKind.Insert);
            ticketDefinition.TicketAssign(0, 0);
            WizardMain wizard = new WizardMain(ticketDefinition.First());
            wizard.ShowDialog();

            dataGridViewTicketList.DataSource = new TicketBL().GetList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicketList.SelectedRows.Count != 0)
            {
                Hashtable data = new Hashtable();

                short ticketID = short.Parse(dataGridViewTicketList.SelectedRows[0].Cells["TicketID"].Value.ToString());
                data.Add(Common.Utility.Constant.TicketInfo, new TicketBL().GetByID(ticketID));

                Base ticketDefinition = new Base(data, Common.Utility.OperationKind.Update);
                ticketDefinition.TicketAssign(0, 0);
                WizardMain wizard = new WizardMain(ticketDefinition.First());
                wizard.ShowDialog();

                dataGridViewTicketList.DataSource = new TicketBL().GetList();
            }
            else
                NFPMessageBox.Show("لطفاً فیلدی را که می خواهید ویرایش شود انتخاب نمائید.", "اخطار", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Warning, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicketList.SelectedRows.Count != 0)
            {
                if (NFPMessageBox.Show("با حذف این بلیت تمامی اطلاعات حذف خواهد گردید.\n آیا از ادامه عملیات مطمئن هستید؟", "توجه", NFPMessageBoxButtons.YesNo, NFPMessageBoxIcon.Information, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                    new TicketBL().DeleteTicket(short.Parse(dataGridViewTicketList.SelectedRows[0].Cells["TicketID"].Value.ToString()));

                dataGridViewTicketList.DataSource = new TicketBL().GetList();
            }
            else
                NFPMessageBox.Show("لطفاً فیلدی را که می خواهید حذف شود انتخاب نمائید.", "اخطار", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Warning, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
        }

        private void dataGridViewTicketList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
