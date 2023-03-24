using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network.BusinnesLogic;
using Common;

namespace MetroNFP.Network.Presentation.UserControls
{
    public partial class RailRoad1Wizard : MetroNFP.Base
    {
        public RailRoad1Wizard()
        {
            InitializeComponent();

            listBoxRailRoad.DataSource = new RailRoadBL().GetList();
            listBoxRailRoad.SelectedIndex = -1;

            if (data[Common.Utility.Constant.NetworkRailRoad] != null)
            {
                List<RailRoad> railRoads = (List<RailRoad>)data[Common.Utility.Constant.NetworkRailRoad];
                foreach (RailRoad railRoad in railRoads)
                    listBoxRailRoad.SelectedValue = railRoad.RailRoadID;
            }
        }
        private void RailRoad1Wizard_Load(object sender, EventArgs e)
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
            Submit();
            return base.Next(this.GetType().FullName);
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
            if (data[Common.Utility.Constant.NetworkRailRoad] == null)
            {
                List<RailRoad> railRoads = new List<RailRoad>();

                for (int i = 0; i < listBoxRailRoad.Items.Count; i++ )
                    if (listBoxRailRoad.GetSelected(i) == true)
                    {
                        railRoads.Add((RailRoad)listBoxRailRoad.Items[i]);
                    }
                data.Add(Common.Utility.Constant.NetworkRailRoad, railRoads);
            }
            else
            {
                List<RailRoad> railRoads = (List<RailRoad>)data[Common.Utility.Constant.NetworkRailRoad];
                railRoads.Clear();

                for (int i = 0; i < listBoxRailRoad.Items.Count; i++)
                    if (listBoxRailRoad.GetSelected(i) == true)
                    {
                        railRoads.Add((RailRoad)listBoxRailRoad.Items[i]);
                    }
                data[Common.Utility.Constant.NetworkRailRoad] = railRoads;
            }
            return data[Common.Utility.Constant.NetworkRailRoad];
        }

        private void buttonRailRoadDefinition_Click(object sender, EventArgs e)
        {
            new AddRailRoad().ShowDialog();

            listBoxRailRoad.DataSource = new RailRoadBL().GetList();
            listBoxRailRoad.SelectedIndex = -1;
        }
    }
}
