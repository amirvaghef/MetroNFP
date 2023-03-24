using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Utility;

namespace MetroNFP
{
    public partial class WizardMain : Form
    {
        public bool EnabledPrevious
        {
            set
            {
                buttonPrevious.Enabled = value;
            }
            get
            {
                return buttonPrevious.Enabled;
            }
        }
        public bool EnabledNext
        {
            set
            {
                buttonNext.Enabled = value;
            }
            get
            {
                return buttonNext.Enabled;
            }
        }
        public bool EnabledFinish
        {
            set
            {
                buttonFinish.Enabled = value;
            }
            get
            {
                return buttonFinish.Enabled;
            }
        }
        public bool EnabledCancel
        {
            set
            {
                buttonCancel.Enabled = value;
            }
            get
            {
                return buttonCancel.Enabled;
            }
        }

        public WizardMain()
        {
            InitializeComponent();
        }

        public WizardMain(UserControl uc)
        {
            InitializeComponent();
            TopPanel.Controls.Clear();
            TopPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        public void SubmitControl(UserControl uc)
        {
            if (uc != null)
            {
                TopPanel.Controls.Clear();
                TopPanel.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(TopPanel.Controls[0].GetType().FullName);
            Object obj = (Base)TopPanel.Controls[0]; // = t.InvokeMember(null, System.Reflection.BindingFlags.CreateInstance, null, null, new object[0]);

            UserControl uc = (UserControl)t.InvokeMember("Previous", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[0]);
            if (uc != null)
            {
                TopPanel.Controls.Clear();
                TopPanel.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(TopPanel.Controls[0].GetType().FullName);
            Object obj = (Base)TopPanel.Controls[0]; // = t.InvokeMember(null, System.Reflection.BindingFlags.Instance, null, null, new object[0]);

            UserControl uc = (UserControl)t.InvokeMember("Next", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[0]);
            if (uc != null)
            {
                TopPanel.Controls.Clear();
                TopPanel.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(TopPanel.Controls[0].GetType().FullName);
            Object obj = (Base)TopPanel.Controls[0]; // = t.InvokeMember(null, System.Reflection.BindingFlags.CreateInstance, null, null, new object[0]);

            bool result = (bool)t.InvokeMember("Finish", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[0]);

            if (result)
                this.Close();
            else
            {
                if (NFPMessageBox.Show("عملیات با خطا مواجه شده است. آیا می خواهید دوباره تلاش نمائید؟", "خطا", NFPMessageBoxButtons.YesNo, NFPMessageBoxIcon.Error, NFPMessageBoxDefaultButton.Button1, NFPMessageBoxOptions.RtlReading, NFPMessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.No)
                    this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(TopPanel.Controls[0].GetType().FullName);
            Object obj = (Base)TopPanel.Controls[0]; // = t.InvokeMember(null, System.Reflection.BindingFlags.CreateInstance, null, null, new object[0]);

            t.InvokeMember("Cancel", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[0]);
            this.Close();
        }

        private void buttonNext_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonNext.Enabled)
                this.AcceptButton = buttonNext;
            else
                this.AcceptButton = buttonFinish;
        }
    }
}
