namespace Network.Presentation
{
    partial class RailRoadMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXRailRoad_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RailRoadMain));
            Janus.Windows.GridEX.GridEXLayout gridEXStation_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXRailRoad = new Janus.Windows.GridEX.GridEX();
            this.gridEXStation = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRailRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXStation)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridEXRailRoad);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridEXStation);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(913, 432);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridEXRailRoad
            // 
            this.gridEXRailRoad.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXRailRoad.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXRailRoad.AutoEdit = true;
            gridEXRailRoad_DesignTimeLayout.LayoutString = resources.GetString("gridEXRailRoad_DesignTimeLayout.LayoutString");
            this.gridEXRailRoad.DesignTimeLayout = gridEXRailRoad_DesignTimeLayout;
            this.gridEXRailRoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXRailRoad.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXRailRoad.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXRailRoad.Location = new System.Drawing.Point(0, 0);
            this.gridEXRailRoad.Name = "gridEXRailRoad";
            this.gridEXRailRoad.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXRailRoad.Size = new System.Drawing.Size(441, 432);
            this.gridEXRailRoad.TabIndex = 0;
            this.gridEXRailRoad.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXRailRoad_DeletingRecords);
            this.gridEXRailRoad.RecordAdded += new System.EventHandler(this.gridEXRailRoad_RecordAdded);
            this.gridEXRailRoad.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEX1_UpdatingRecord);
            this.gridEXRailRoad.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEX1_AddingRecord);
            this.gridEXRailRoad.SelectionChanged += new System.EventHandler(this.gridEX1_SelectionChanged);
            // 
            // gridEXStation
            // 
            this.gridEXStation.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXStation.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXStation.AutoEdit = true;
            gridEXStation_DesignTimeLayout.LayoutString = resources.GetString("gridEXStation_DesignTimeLayout.LayoutString");
            this.gridEXStation.DesignTimeLayout = gridEXStation_DesignTimeLayout;
            this.gridEXStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXStation.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXStation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridEXStation.Location = new System.Drawing.Point(0, 0);
            this.gridEXStation.Name = "gridEXStation";
            this.gridEXStation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXStation.Size = new System.Drawing.Size(468, 432);
            this.gridEXStation.TabIndex = 3;
            this.gridEXStation.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXStation_DeletingRecords);
            this.gridEXStation.RecordAdded += new System.EventHandler(this.gridEXStation_RecordAdded);
            this.gridEXStation.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXStation_UpdatingRecord);
            this.gridEXStation.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXStation_AddingRecord);
            // 
            // RailRoadMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "RailRoadMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مسیرها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRailRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX gridEXRailRoad;
        private Janus.Windows.GridEX.GridEX gridEXStation;

    }
}