namespace Ticket.Presentation
{
    partial class TransferProfileMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXTransferProfile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferProfileMain));
            this.gridEXTransferProfile = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTransferProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEXTransferProfile
            // 
            this.gridEXTransferProfile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXTransferProfile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXTransferProfile_DesignTimeLayout.LayoutString = resources.GetString("gridEXTransferProfile_DesignTimeLayout.LayoutString");
            this.gridEXTransferProfile.DesignTimeLayout = gridEXTransferProfile_DesignTimeLayout;
            this.gridEXTransferProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXTransferProfile.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXTransferProfile.Location = new System.Drawing.Point(0, 0);
            this.gridEXTransferProfile.Name = "gridEXTransferProfile";
            this.gridEXTransferProfile.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXTransferProfile.Size = new System.Drawing.Size(971, 468);
            this.gridEXTransferProfile.TabIndex = 0;
            this.gridEXTransferProfile.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXTransferProfile_DeletingRecords);
            this.gridEXTransferProfile.RecordAdded += new System.EventHandler(this.gridEXTransferProfile_RecordAdded);
            this.gridEXTransferProfile.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXTransferProfile_UpdatingRecord);
            this.gridEXTransferProfile.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXTransferProfile_AddingRecord);
            // 
            // TransferProfileMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.gridEXTransferProfile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "TransferProfileMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قوانین تردد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTransferProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEXTransferProfile;
    }
}