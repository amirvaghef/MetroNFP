namespace Ticket.Presentation
{
    partial class SectionFareMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXSectionFareProfile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionFareMain));
            Janus.Windows.GridEX.GridEXLayout gridEXSectionFare_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXSectionFareProfile = new Janus.Windows.GridEX.GridEX();
            this.gridEXSectionFare = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSectionFareProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSectionFare)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridEXSectionFareProfile);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridEXSectionFare);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(913, 432);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridEXSectionFareProfile
            // 
            this.gridEXSectionFareProfile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSectionFareProfile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXSectionFareProfile_DesignTimeLayout.LayoutString = resources.GetString("gridEXSectionFareProfile_DesignTimeLayout.LayoutString");
            this.gridEXSectionFareProfile.DesignTimeLayout = gridEXSectionFareProfile_DesignTimeLayout;
            this.gridEXSectionFareProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXSectionFareProfile.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXSectionFareProfile.Location = new System.Drawing.Point(0, 0);
            this.gridEXSectionFareProfile.Name = "gridEXSectionFareProfile";
            this.gridEXSectionFareProfile.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSectionFareProfile.Size = new System.Drawing.Size(458, 432);
            this.gridEXSectionFareProfile.TabIndex = 0;
            this.gridEXSectionFareProfile.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_DeletingRecords);
            this.gridEXSectionFareProfile.RecordAdded += new System.EventHandler(this.gridEXSectionFareProfile_RecordAdded);
            this.gridEXSectionFareProfile.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_UpdatingRecord);
            this.gridEXSectionFareProfile.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_AddingRecord);
            this.gridEXSectionFareProfile.SelectionChanged += new System.EventHandler(this.gridEXSectionFareProfile_SelectionChanged);
            // 
            // gridEXSectionFare
            // 
            this.gridEXSectionFare.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSectionFare.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXSectionFare_DesignTimeLayout.LayoutString = resources.GetString("gridEXSectionFare_DesignTimeLayout.LayoutString");
            this.gridEXSectionFare.DesignTimeLayout = gridEXSectionFare_DesignTimeLayout;
            this.gridEXSectionFare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXSectionFare.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXSectionFare.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridEXSectionFare.Location = new System.Drawing.Point(0, 0);
            this.gridEXSectionFare.Name = "gridEXSectionFare";
            this.gridEXSectionFare.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXSectionFare.Size = new System.Drawing.Size(451, 432);
            this.gridEXSectionFare.TabIndex = 0;
            this.gridEXSectionFare.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_DeletingRecords);
            this.gridEXSectionFare.RecordAdded += new System.EventHandler(this.gridEXSectionFare_RecordAdded);
            this.gridEXSectionFare.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_UpdatingRecord);
            this.gridEXSectionFare.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_AddingRecord);
            // 
            // SectionFareMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "SectionFareMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پروفایل کرایه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSectionFareProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXSectionFare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX gridEXSectionFareProfile;
        private Janus.Windows.GridEX.GridEX gridEXSectionFare;
    }
}