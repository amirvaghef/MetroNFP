namespace MetroNFP.Network.Presentation.UserControls
{
    partial class RailRoad1Wizard
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
            this.components = new System.ComponentModel.Container();
            this.labelRailRoad = new System.Windows.Forms.Label();
            this.buttonRailRoadDefinition = new System.Windows.Forms.Button();
            this.railRoadBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxRailRoad = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.railRoadBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRailRoad
            // 
            this.labelRailRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRailRoad.AutoSize = true;
            this.labelRailRoad.Location = new System.Drawing.Point(343, 16);
            this.labelRailRoad.Name = "labelRailRoad";
            this.labelRailRoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRailRoad.Size = new System.Drawing.Size(52, 13);
            this.labelRailRoad.TabIndex = 1;
            this.labelRailRoad.Text = "مسیرها: ";
            // 
            // buttonRailRoadDefinition
            // 
            this.buttonRailRoadDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRailRoadDefinition.Location = new System.Drawing.Point(75, 16);
            this.buttonRailRoadDefinition.Name = "buttonRailRoadDefinition";
            this.buttonRailRoadDefinition.Size = new System.Drawing.Size(95, 25);
            this.buttonRailRoadDefinition.TabIndex = 2;
            this.buttonRailRoadDefinition.Text = "تعریف مسیر";
            this.buttonRailRoadDefinition.UseVisualStyleBackColor = true;
            this.buttonRailRoadDefinition.Click += new System.EventHandler(this.buttonRailRoadDefinition_Click);
            // 
            // railRoadBLBindingSource
            // 
            this.railRoadBLBindingSource.DataSource = typeof(Common.RailRoad);
            // 
            // listBoxRailRoad
            // 
            this.listBoxRailRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRailRoad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.railRoadBLBindingSource, "RailRoadID", true));
            this.listBoxRailRoad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.railRoadBLBindingSource, "Name", true));
            this.listBoxRailRoad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.railRoadBLBindingSource, "RailRoadID", true));
            this.listBoxRailRoad.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.railRoadBLBindingSource, "ShortName", true));
            this.listBoxRailRoad.DataSource = this.railRoadBLBindingSource;
            this.listBoxRailRoad.DisplayMember = "Name";
            this.listBoxRailRoad.FormattingEnabled = true;
            this.listBoxRailRoad.HorizontalScrollbar = true;
            this.listBoxRailRoad.Location = new System.Drawing.Point(180, 16);
            this.listBoxRailRoad.Name = "listBoxRailRoad";
            this.listBoxRailRoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRailRoad.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRailRoad.Size = new System.Drawing.Size(161, 173);
            this.listBoxRailRoad.TabIndex = 0;
            this.listBoxRailRoad.ValueMember = "RailRoadID";
            // 
            // RailRoad1Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxRailRoad);
            this.Controls.Add(this.buttonRailRoadDefinition);
            this.Controls.Add(this.labelRailRoad);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RailRoad1Wizard";
            this.Size = new System.Drawing.Size(404, 215);
            this.Load += new System.EventHandler(this.RailRoad1Wizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.railRoadBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRailRoad;
        private System.Windows.Forms.Button buttonRailRoadDefinition;
        private System.Windows.Forms.BindingSource railRoadBLBindingSource;
        private System.Windows.Forms.ListBox listBoxRailRoad;
    }
}
