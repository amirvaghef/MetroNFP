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
    public partial class RailRoad2Wizard : MetroNFP.Base
    {
        Station station = new Station();
        public RailRoad2Wizard()
        {
            InitializeComponent();

            station = (Station)data[Common.Utility.Constant.NetworkStation];
            ShowRailRoads();
        }
        private void ShowRailRoads()
        {
            if (data[Common.Utility.Constant.NetworkRailRoad] != null)
            {
                List<RailRoad> railRoads = (List<RailRoad>)data[Common.Utility.Constant.NetworkRailRoad];
                int i = 0;
                foreach (RailRoad railRoad in railRoads)
                {
                    Label label1 = new Label();
                    label1.Text = railRoad.Name;
                    label1.Width = 130;
                    label1.Anchor = AnchorStyles.Right & AnchorStyles.Top;
                    label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    tableLayoutPanelRailRoads.Controls.Add(label1, 0, i);

                    TextBox textBox1 = new TextBox();
                    textBox1.Width = 60;
                    textBox1.Height = 20;
                    textBox1.Anchor = AnchorStyles.Right & AnchorStyles.Top;
                    textBox1.Name = railRoad.RailRoadID.ToString();
                    textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    textBox1.Enter += new EventHandler(textBox1_Enter);
                    textBox1.MaxLength = 3;
                    foreach (Station st in railRoad.Stations)
                        if (st.StationID == station.StationID)
                            textBox1.Text = st.Sequence.ToString();
                    tableLayoutPanelRailRoads.Controls.Add(textBox1, 1, i);

                    Label label2 = new Label();
                    label2.Text = "ترتیب ایستگاه: ";
                    label2.Width = 75;
                    label2.Anchor = AnchorStyles.Right & AnchorStyles.Top;
                    label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    tableLayoutPanelRailRoads.Controls.Add(label2, 1, i);

                    tableLayoutPanelRailRoads.RowStyles.Insert(i++, new RowStyle(SizeType.Absolute, 25));
                    tableLayoutPanelRailRoads.RowCount = i + 1;
                }
            }
        }

        void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            List<RailRoad> railRoads = (List<RailRoad>)data[Common.Utility.Constant.NetworkRailRoad];

            foreach(RailRoad railRoad in railRoads)
            {
                if (railRoad.RailRoadID.ToString() == textBox1.Name)
                    dataGridViewStation.DataSource = railRoad.Stations;
            }
        }
        private void RailRoad2Wizard_Load(object sender, EventArgs e)
        {
            EnabledDisableWizard();
        }
        private void EnabledDisableWizard()
        {
            if (Parent != null)
            {
                ((WizardMain)Parent.Parent).EnabledPrevious = true;
                ((WizardMain)Parent.Parent).EnabledFinish = true;
                ((WizardMain)Parent.Parent).EnabledCancel = true;
                ((WizardMain)Parent.Parent).EnabledNext = false;
            }
        }

        public UserControl Next()
        {
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
            try
            {
                if (opKind == Common.Utility.OperationKind.Insert)
                    new NetworkBL().Insert(station, (List<RailRoad>)SubmitRailRoads());
                else
                    if(opKind == Common.Utility.OperationKind.Update)
                        new NetworkBL().Update(station, (List<RailRoad>)SubmitRailRoads());
                return base.Finish();
            }
            catch
            {
                return false;
            }
        }

        private object SubmitRailRoads()
        {
            if (data[Common.Utility.Constant.NetworkRailRoad] == null)
            {
                return null;
            }
            else
            {
                List<RailRoad> railRoads = (List<RailRoad>)data[Common.Utility.Constant.NetworkRailRoad];

                foreach (RailRoad railRoad in railRoads)
                {
                    Station st = new Station();
                    st.StationID = station.StationID;
                    st.Name = station.Name;
                    st.ShortName = station.ShortName;
                    st.Sequence = int.Parse(((TextBox)tableLayoutPanelRailRoads.Controls[railRoad.RailRoadID.ToString()]).Text);
                    railRoad.Stations.Clear();
                    railRoad.Stations.Add(st);
                }
                return railRoads;
            }
        }
    }
}
