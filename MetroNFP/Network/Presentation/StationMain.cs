using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network.BusinnesLogic;
using System.Data.SqlClient;
using System.Collections;
using MetroNFP;
using Common.Utility;

namespace Network.Presentation
{
    public partial class StationMain : Form
    {
        public StationMain()
        {
            InitializeComponent();
            dataGridViewStationList.DataSource = new StationBL().GetList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Base networkDefinition = new Base(Common.Utility.OperationKind.Insert);
            networkDefinition.NetworkAssign();
            WizardMain wizard = new WizardMain(networkDefinition.First());
            wizard.ShowDialog();

            dataGridViewStationList.DataSource = new StationBL().GetList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStationList.SelectedRows.Count != 0)
            {
                Hashtable data = new Hashtable();

                int stID = int.Parse(dataGridViewStationList.SelectedRows[0].Cells["StationID"].Value.ToString());
                data.Add(Common.Utility.Constant.NetworkStation, new StationBL().GetByID(stID));
                data.Add(Common.Utility.Constant.NetworkRailRoad, new RailRoadBL().GetByID(stID));

                Base networkDefinition = new Base(data, Common.Utility.OperationKind.Update);
                networkDefinition.NetworkAssign();
                WizardMain wizard = new WizardMain(networkDefinition.First());
                wizard.ShowDialog();

                dataGridViewStationList.DataSource = new StationBL().GetList();
            }
            else
                NFPMessageBox.Show("لطفاً فیلدی را که می خواهید ویرایش شود انتخاب نمائید.", "اخطار", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Warning, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStationList.SelectedRows.Count != 0)
            {
                if (NFPMessageBox.Show("با حذف این ایستگاه تمامی اطلاعات آن از لیست مسیرها و جدول مبدأ/مقصد حذف خواهد گردید.\n آیا از ادامه عملیات مطمئن هستید؟", "توجه", NFPMessageBoxButtons.YesNo, NFPMessageBoxIcon.Information, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                    new StationBL().Delete(int.Parse(dataGridViewStationList.SelectedRows[0].Cells["StationID"].Value.ToString()));

                dataGridViewStationList.DataSource = new StationBL().GetList();
            }
            else
                NFPMessageBox.Show("لطفاً فیلدی را که می خواهید حذف شود انتخاب نمائید.", "اخطار", NFPMessageBoxButtons.OK, NFPMessageBoxIcon.Warning, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading);
        }
    }
}
