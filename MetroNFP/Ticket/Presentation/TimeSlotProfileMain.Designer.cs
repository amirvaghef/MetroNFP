namespace Ticket.Presentation
{
    partial class TimeSlotProfileMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout gridEXTimeSlot_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSlotProfileMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbTimeSlotProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimeSlotProfileName = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridEXTimeSlot = new Janus.Windows.GridEX.GridEX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTimeSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.cbTimeSlotProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 35);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(596, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "حذف";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbTimeSlotProfile
            // 
            this.cbTimeSlotProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimeSlotProfile.DisplayMember = "TimeSlotProfileName";
            this.cbTimeSlotProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSlotProfile.FormattingEnabled = true;
            this.cbTimeSlotProfile.Location = new System.Drawing.Point(632, 8);
            this.cbTimeSlotProfile.Name = "cbTimeSlotProfile";
            this.cbTimeSlotProfile.Size = new System.Drawing.Size(232, 21);
            this.cbTimeSlotProfile.TabIndex = 1;
            this.cbTimeSlotProfile.ValueMember = "TimeSlotProfileID";
            this.cbTimeSlotProfile.SelectedIndexChanged += new System.EventHandler(this.cbTimeSlotProfile_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "پروفایل بازه زمانی: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimeSlotProfileName);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 35);
            this.panel2.TabIndex = 1;
            // 
            // txtTimeSlotProfileName
            // 
            this.txtTimeSlotProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeSlotProfileName.Location = new System.Drawing.Point(596, 7);
            this.txtTimeSlotProfileName.Name = "txtTimeSlotProfileName";
            this.txtTimeSlotProfileName.Size = new System.Drawing.Size(239, 21);
            this.txtTimeSlotProfileName.TabIndex = 3;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(566, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(24, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ثبت";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(841, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ایجاد پروفایل بازه زمانی: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridEXTimeSlot);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 398);
            this.panel3.TabIndex = 2;
            // 
            // gridEXTimeSlot
            // 
            this.gridEXTimeSlot.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXTimeSlot_DesignTimeLayout.LayoutString = resources.GetString("gridEXTimeSlot_DesignTimeLayout.LayoutString");
            this.gridEXTimeSlot.DesignTimeLayout = gridEXTimeSlot_DesignTimeLayout;
            this.gridEXTimeSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXTimeSlot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridEXTimeSlot.Location = new System.Drawing.Point(0, 0);
            this.gridEXTimeSlot.Name = "gridEXTimeSlot";
            this.gridEXTimeSlot.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXTimeSlot.Size = new System.Drawing.Size(971, 398);
            this.gridEXTimeSlot.TabIndex = 2;
            this.gridEXTimeSlot.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEXTimeSlot_CellUpdated);
            this.gridEXTimeSlot.RecordAdded += new System.EventHandler(this.gridEXTransferProfile_RecordAdded);
            this.gridEXTimeSlot.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXTransferProfile_UpdatingRecord);
            this.gridEXTimeSlot.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXTransferProfile_AddingRecord);
            // 
            // TimeSlotProfileMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "TimeSlotProfileMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بازه های زمانی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeSlotProfileMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTimeSlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Janus.Windows.GridEX.GridEX gridEXTimeSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimeSlotProfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtTimeSlotProfileName;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;

    }
}