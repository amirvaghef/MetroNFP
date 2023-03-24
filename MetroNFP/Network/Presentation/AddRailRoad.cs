using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network.BusinnesLogic;
using Common;
using Common.Utility;

namespace MetroNFP.Network.Presentation
{
    public partial class AddRailRoad : Form
    {
        public AddRailRoad()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RailRoad railRoad = new RailRoad();
            railRoad.Name = Utility.RefineText(textBoxName.Text);
            railRoad.ShortName = Utility.RefineText(textBoxShortName.Text);

            List<RailRoad> railRoads = new RailRoadBL().GetList();
            if (!Utility.Exist(railRoads, Utility.RefineText(textBoxName.Text), "Name"))
            {
                if (!Utility.Exist(railRoads, Utility.RefineText(textBoxShortName.Text), "ShortName"))
                {
                    if (new RailRoadBL().InsertRailRoad(railRoad) <= 0)
                    {
                        if (NFPMessageBox.Show("عملیات با خطا مواجه شده است. آیا می خواهید دوباره تلاش نمائید؟", "خطا", NFPMessageBoxButtons.YesNo, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.No)
                            this.Close();
                    }
                    else
                        this.Close();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textBoxShortName, "لطفاً نام مختصر مسیر را با نامی غیر تکراری پر نمائید");
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxName, "لطفاً نام مسیر را با نامی غیر تکراری پر نمائید");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
