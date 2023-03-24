namespace Network.Presentation
{
    partial class ODMain
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridEXOriginStations_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ODMain));
            Janus.Windows.GridEX.GridEXLayout gridEXDestinationStations_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXOriginStations = new Janus.Windows.GridEX.GridEX();
            this.gridEXDestinationStations = new Janus.Windows.GridEX.GridEX();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXOriginStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDestinationStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridEXOriginStations);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridEXDestinationStations);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1048, 413);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridEXOriginStations
            // 
            gridEXOriginStations_DesignTimeLayout.LayoutString = resources.GetString("gridEXOriginStations_DesignTimeLayout.LayoutString");
            this.gridEXOriginStations.DesignTimeLayout = gridEXOriginStations_DesignTimeLayout;
            this.gridEXOriginStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXOriginStations.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXOriginStations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXOriginStations.Location = new System.Drawing.Point(0, 0);
            this.gridEXOriginStations.Name = "gridEXOriginStations";
            this.gridEXOriginStations.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXOriginStations.Size = new System.Drawing.Size(519, 413);
            this.gridEXOriginStations.TabIndex = 0;
            this.gridEXOriginStations.SelectionChanged += new System.EventHandler(this.gridEXOriginStations_SelectionChanged);
            // 
            // gridEXDestinationStations
            // 
            gridEXDestinationStations_DesignTimeLayout.LayoutString = resources.GetString("gridEXDestinationStations_DesignTimeLayout.LayoutString");
            this.gridEXDestinationStations.DesignTimeLayout = gridEXDestinationStations_DesignTimeLayout;
            this.gridEXDestinationStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXDestinationStations.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXDestinationStations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXDestinationStations.Location = new System.Drawing.Point(0, 0);
            this.gridEXDestinationStations.Name = "gridEXDestinationStations";
            this.gridEXDestinationStations.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXDestinationStations.Size = new System.Drawing.Size(525, 413);
            this.gridEXDestinationStations.TabIndex = 1;
            this.gridEXDestinationStations.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXDestinationStations_UpdatingRecord);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(Common.Section);
            // 
            // ODMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1048, 413);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ODMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مبدآ / مقصد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXOriginStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDestinationStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX gridEXOriginStations;
        private Janus.Windows.GridEX.GridEX gridEXDestinationStations;

    }
}