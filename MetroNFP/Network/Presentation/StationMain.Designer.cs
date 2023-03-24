namespace Network.Presentation
{
    partial class StationMain
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dataGridViewStationList = new System.Windows.Forms.DataGridView();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationList)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(535, 266);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.buttonDelete);
            this.BottomPanel.Controls.Add(this.buttonEdit);
            this.BottomPanel.Controls.Add(this.buttonInsert);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 212);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(535, 54);
            this.BottomPanel.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(225, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 25);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(328, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 25);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Location = new System.Drawing.Point(431, 19);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(95, 25);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "درج";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.AutoScroll = true;
            this.TopPanel.Controls.Add(this.dataGridViewStationList);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(535, 212);
            this.TopPanel.TabIndex = 0;
            // 
            // dataGridViewStationList
            // 
            this.dataGridViewStationList.AllowUserToAddRows = false;
            this.dataGridViewStationList.AllowUserToDeleteRows = false;
            this.dataGridViewStationList.AllowUserToOrderColumns = true;
            this.dataGridViewStationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationID,
            this.SectionNumber,
            this.StationName,
            this.StationShortName,
            this.Sequence});
            this.dataGridViewStationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStationList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStationList.MultiSelect = false;
            this.dataGridViewStationList.Name = "dataGridViewStationList";
            this.dataGridViewStationList.ReadOnly = true;
            this.dataGridViewStationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStationList.Size = new System.Drawing.Size(535, 212);
            this.dataGridViewStationList.StandardTab = true;
            this.dataGridViewStationList.TabIndex = 0;
            this.dataGridViewStationList.VirtualMode = true;
            // 
            // StationID
            // 
            this.StationID.DataPropertyName = "StationID";
            this.StationID.HeaderText = "شماره ایستگاه";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            // 
            // SectionNumber
            // 
            this.SectionNumber.DataPropertyName = "SectionNumber";
            this.SectionNumber.HeaderText = "شماره بخش";
            this.SectionNumber.Name = "SectionNumber";
            this.SectionNumber.ReadOnly = true;
            this.SectionNumber.Visible = false;
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "Name";
            this.StationName.HeaderText = "نام ایستگاه";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            this.StationName.Width = 200;
            // 
            // StationShortName
            // 
            this.StationShortName.DataPropertyName = "ShortName";
            this.StationShortName.HeaderText = "نام مختصر";
            this.StationShortName.Name = "StationShortName";
            this.StationShortName.ReadOnly = true;
            // 
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "توالی ایستگاه ها";
            this.Sequence.Name = "Sequence";
            this.Sequence.ReadOnly = true;
            this.Sequence.Visible = false;
            // 
            // StationMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(535, 266);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "StationMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ایستگاه ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewStationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;

    }
}