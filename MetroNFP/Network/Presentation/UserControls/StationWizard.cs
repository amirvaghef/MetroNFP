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
using Common.Utility;

namespace MetroNFP.Network.Presentation.UserControls
{
    public partial class StationWizard : MetroNFP.Base
    {
        public StationWizard()
        {
            InitializeComponent();

            if (data[Common.Utility.Constant.NetworkStation] != null)
            {
                Station station = (Station)data[this.GetType().FullName];
                textBoxName.Text = station.Name;
                textBoxShortName.Text = station.ShortName;
            }
        }
        private void StationWizard_Load(object sender, EventArgs e)
        {
            EnabledDisableWizard();
        }
        private void EnabledDisableWizard()
        {
            if (Parent != null)
            {
                ((WizardMain)Parent.Parent).EnabledPrevious = false;
                ((WizardMain)Parent.Parent).EnabledNext = true;
                ((WizardMain)Parent.Parent).EnabledFinish = true;
                ((WizardMain)Parent.Parent).EnabledCancel = true;
            }
        }

        public UserControl Next()
        {
            if (Submit() != null)
                return base.Next(this.GetType().FullName);
            else
                return null;
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
            bool result = false;
            if (opKind == Common.Utility.OperationKind.Insert)
                result = new StationBL().Insert((Station)Submit()) > 0 ? true : false;
            else
                if (opKind == Common.Utility.OperationKind.Update)
                    result = new StationBL().Update((Station)Submit()) > 0 ? true : false;

            if (result)
                return base.Finish();
            else
                return false;
        }

        private object Submit()
        {
            if (data[Common.Utility.Constant.NetworkStation] == null)
            {
                List<Station> stations = new StationBL().GetList();
                if (!Utility.Exist(stations, Utility.RefineText(textBoxName.Text), "Name"))
                {
                    if (!Utility.Exist(stations, Utility.RefineText(textBoxShortName.Text), "ShortName"))
                    {
                        Station station = new Station();
                        station.Name = Utility.RefineText(textBoxName.Text);
                        station.ShortName = Utility.RefineText(textBoxShortName.Text);
                        data.Add(Common.Utility.Constant.NetworkStation, station);
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBoxShortName, "لطفاً نام مختصر ایستگاه را با نامی غیر تکراری پر نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBoxName, "لطفاً نام ایستگاه را با نامی غیر تکراری پر نمائید");
                    return null;
                }
            }
            else
            {
                Station station = (Station)data[Common.Utility.Constant.NetworkStation];
                List<Station> stations = new StationBL().GetList();
                for (int i=0; i<stations.Count; i++)
                    if (stations[i].StationID == station.StationID)
                        stations.RemoveAt(i);

                if (!Utility.Exist(stations, Utility.RefineText(textBoxName.Text), "Name"))
                {
                    if (!Utility.Exist(stations, Utility.RefineText(textBoxShortName.Text), "ShortName"))
                    {
                        station.Name = Utility.RefineText(textBoxName.Text);
                        station.ShortName = Utility.RefineText(textBoxShortName.Text);
                        data[Common.Utility.Constant.NetworkStation] = station;
                    }
                    else
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(textBoxShortName, "لطفاً نام مختصر ایستگاه را با نامی غیر تکراری پر نمائید");
                        return null;
                    }
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBoxName, "لطفاً نام ایستگاه را با نامی غیر تکراری پر نمائید");
                    return null;
                }
            }
            return data[Common.Utility.Constant.NetworkStation];
        }
    }
}
