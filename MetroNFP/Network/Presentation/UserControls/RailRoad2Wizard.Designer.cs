namespace MetroNFP.Network.Presentation.UserControls
{
    partial class RailRoad2Wizard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelRailRoads = new System.Windows.Forms.TableLayoutPanel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewStation = new System.Windows.Forms.DataGridView();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRailRoads
            // 
            this.tableLayoutPanelRailRoads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRailRoads.ColumnCount = 3;
            this.tableLayoutPanelRailRoads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRailRoads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRailRoads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRailRoads.Location = new System.Drawing.Point(191, 0);
            this.tableLayoutPanelRailRoads.Name = "tableLayoutPanelRailRoads";
            this.tableLayoutPanelRailRoads.RowCount = 1;
            this.tableLayoutPanelRailRoads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRailRoads.Size = new System.Drawing.Size(281, 241);
            this.tableLayoutPanelRailRoads.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewStation);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelGrid.Size = new System.Drawing.Size(192, 241);
            this.panelGrid.TabIndex = 1;
            // 
            // dataGridViewStation
            // 
            this.dataGridViewStation.AllowUserToAddRows = false;
            this.dataGridViewStation.AllowUserToDeleteRows = false;
            this.dataGridViewStation.AllowUserToOrderColumns = true;
            this.dataGridViewStation.AllowUserToResizeColumns = false;
            this.dataGridViewStation.AllowUserToResizeRows = false;
            this.dataGridViewStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationID,
            this.StationName,
            this.StationShortName,
            this.Sequence});
            this.dataGridViewStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStation.Name = "dataGridViewStation";
            this.dataGridViewStation.ReadOnly = true;
            this.dataGridViewStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewStation.RowHeadersVisible = false;
            this.dataGridViewStation.Size = new System.Drawing.Size(192, 241);
            this.dataGridViewStation.TabIndex = 0;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "StationID";
            this.StationID.FillWeight = 45F;
            this.StationID.Frozen = true;
            this.StationID.HeaderText = "شماره";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            this.StationID.Visible = false;
            this.StationID.Width = 45;
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "Name";
            this.StationName.FillWeight = 150F;
            this.StationName.Frozen = true;
            this.StationName.HeaderText = "نام ایستگاه";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            this.StationName.Width = 150;
            // 
            // StationShortName
            // 
            this.StationShortName.DataPropertyName = "ShortName";
            this.StationShortName.FillWeight = 80F;
            this.StationShortName.Frozen = true;
            this.StationShortName.HeaderText = "نام مختصر";
            this.StationShortName.Name = "StationShortName";
            this.StationShortName.ReadOnly = true;
            this.StationShortName.Visible = false;
            this.StationShortName.Width = 80;
            // 
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.FillWeight = 50F;
            this.Sequence.Frozen = true;
            this.Sequence.HeaderText = "ترتیب";
            this.Sequence.Name = "Sequence";
            this.Sequence.ReadOnly = true;
            this.Sequence.Width = 50;
            // 
            // RailRoad2Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.tableLayoutPanelRailRoads);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RailRoad2Wizard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(472, 241);
            this.Load += new System.EventHandler(this.RailRoad2Wizard_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRailRoads;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;

    }
}
