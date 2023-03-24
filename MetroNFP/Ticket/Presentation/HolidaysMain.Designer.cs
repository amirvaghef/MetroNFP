namespace Ticket.Presentation
{
    partial class HolidaysMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXSchoolHoliday_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidaysMain));
            Janus.Windows.GridEX.GridEXLayout gridEXBankHoliday_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEXSchoolHoliday = new Janus.Windows.GridEX.GridEX();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.gridEXBankHoliday = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSchoolHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXBankHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(971, 468);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridEXSchoolHoliday);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(487, 468);
            this.splitContainer2.SplitterDistance = 34;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعطیلات مدرسه";
            // 
            // gridEXSchoolHoliday
            // 
            this.gridEXSchoolHoliday.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSchoolHoliday.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXSchoolHoliday_DesignTimeLayout.LayoutString = resources.GetString("gridEXSchoolHoliday_DesignTimeLayout.LayoutString");
            this.gridEXSchoolHoliday.DesignTimeLayout = gridEXSchoolHoliday_DesignTimeLayout;
            this.gridEXSchoolHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXSchoolHoliday.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXSchoolHoliday.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXSchoolHoliday.Location = new System.Drawing.Point(0, 0);
            this.gridEXSchoolHoliday.Name = "gridEXSchoolHoliday";
            this.gridEXSchoolHoliday.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSchoolHoliday.Size = new System.Drawing.Size(487, 430);
            this.gridEXSchoolHoliday.TabIndex = 2;
            this.gridEXSchoolHoliday.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSchoolHoliday_DeletingRecords);
            this.gridEXSchoolHoliday.RecordAdded += new System.EventHandler(this.gridEXSchoolHoliday_RecordAdded);
            this.gridEXSchoolHoliday.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSchoolHoliday_UpdatingRecord);
            this.gridEXSchoolHoliday.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSchoolHoliday_AddingRecord);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gridEXBankHoliday);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(480, 468);
            this.splitContainer3.SplitterDistance = 34;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعطیلات رسمی";
            // 
            // gridEXBankHoliday
            // 
            this.gridEXBankHoliday.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXBankHoliday.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXBankHoliday_DesignTimeLayout.LayoutString = resources.GetString("gridEXBankHoliday_DesignTimeLayout.LayoutString");
            this.gridEXBankHoliday.DesignTimeLayout = gridEXBankHoliday_DesignTimeLayout;
            this.gridEXBankHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXBankHoliday.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXBankHoliday.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXBankHoliday.Location = new System.Drawing.Point(0, 0);
            this.gridEXBankHoliday.Name = "gridEXBankHoliday";
            this.gridEXBankHoliday.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXBankHoliday.Size = new System.Drawing.Size(480, 430);
            this.gridEXBankHoliday.TabIndex = 2;
            this.gridEXBankHoliday.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXBankHoliday_DeletingRecords);
            this.gridEXBankHoliday.RecordAdded += new System.EventHandler(this.gridEXBankHoliday_RecordAdded);
            this.gridEXBankHoliday.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXBankHoliday_UpdatingRecord);
            this.gridEXBankHoliday.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXBankHoliday_AddingRecord);
            // 
            // HolidaysMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "HolidaysMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعریف تعطیلات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSchoolHoliday)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXBankHoliday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.GridEX gridEXSchoolHoliday;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.GridEX gridEXBankHoliday;
    }
}