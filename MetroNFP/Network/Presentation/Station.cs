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

namespace Network.Presentation
{
    public partial class Station : Form
    {
        public Station()
        {
            InitializeComponent();
            //try
            //{
            //    SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
            //    perm.Demand();
            //}
            //catch
            //{
            //    throw new ApplicationException("No permission");
            //}
            //new StationBL().OnNewStationBL += new StationBL.NewStationBL(OnNewStationBL);
            BindData();
        }
        //void OnNewStationBL()
        //{
        //    ISynchronizeInvoke i = (ISynchronizeInvoke)this;

        //    // Check if the event was generated from another
        //    // thread and needs invoke instead
        //    if (i.InvokeRequired)
        //    {
        //        StationBL.NewStationBL tempDelegate = new StationBL.NewStationBL(OnNewStationBL);
        //        i.BeginInvoke(tempDelegate, null);
        //        return;
        //    }

        //    // If not coming from a seperate thread
        //    // we can access the Windows form controls
        //    BindData();
        //}
        private void BindData()
        {
            dataGridViewStationList.DataSource = new StationBL().GetList();
        }
    }
}
