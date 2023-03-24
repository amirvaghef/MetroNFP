namespace Ticket.Presentation
{
    partial class DiscountRefundMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXDiscountRefundProfile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountRefundMain));
            Janus.Windows.GridEX.GridEXLayout gridEXDiscountRefund_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXDiscountRefundProfile = new Janus.Windows.GridEX.GridEX();
            this.gridEXDiscountRefund = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDiscountRefundProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDiscountRefund)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridEXDiscountRefundProfile);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridEXDiscountRefund);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(913, 432);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridEXDiscountRefundProfile
            // 
            this.gridEXDiscountRefundProfile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXDiscountRefundProfile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXDiscountRefundProfile_DesignTimeLayout.LayoutString = resources.GetString("gridEXDiscountRefundProfile_DesignTimeLayout.LayoutString");
            this.gridEXDiscountRefundProfile.DesignTimeLayout = gridEXDiscountRefundProfile_DesignTimeLayout;
            this.gridEXDiscountRefundProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXDiscountRefundProfile.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXDiscountRefundProfile.Location = new System.Drawing.Point(0, 0);
            this.gridEXDiscountRefundProfile.Name = "gridEXDiscountRefundProfile";
            this.gridEXDiscountRefundProfile.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXDiscountRefundProfile.Size = new System.Drawing.Size(458, 432);
            this.gridEXDiscountRefundProfile.TabIndex = 0;
            this.gridEXDiscountRefundProfile.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_DeletingRecords);
            this.gridEXDiscountRefundProfile.RecordAdded += new System.EventHandler(this.gridEXSectionFareProfile_RecordAdded);
            this.gridEXDiscountRefundProfile.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_UpdatingRecord);
            this.gridEXDiscountRefundProfile.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_AddingRecord);
            this.gridEXDiscountRefundProfile.SelectionChanged += new System.EventHandler(this.gridEXSectionFareProfile_SelectionChanged);
            // 
            // gridEXDiscountRefund
            // 
            this.gridEXDiscountRefund.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXDiscountRefund.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXDiscountRefund_DesignTimeLayout.LayoutString = resources.GetString("gridEXDiscountRefund_DesignTimeLayout.LayoutString");
            this.gridEXDiscountRefund.DesignTimeLayout = gridEXDiscountRefund_DesignTimeLayout;
            this.gridEXDiscountRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXDiscountRefund.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXDiscountRefund.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridEXDiscountRefund.Location = new System.Drawing.Point(0, 0);
            this.gridEXDiscountRefund.Name = "gridEXDiscountRefund";
            this.gridEXDiscountRefund.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXDiscountRefund.Size = new System.Drawing.Size(451, 432);
            this.gridEXDiscountRefund.TabIndex = 0;
            this.gridEXDiscountRefund.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_DeletingRecords);
            this.gridEXDiscountRefund.RecordAdded += new System.EventHandler(this.gridEXSectionFare_RecordAdded);
            this.gridEXDiscountRefund.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_UpdatingRecord);
            this.gridEXDiscountRefund.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFare_AddingRecord);
            // 
            // DiscountRefundMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "DiscountRefundMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پروفایل تخفیف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDiscountRefundProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXDiscountRefund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX gridEXDiscountRefundProfile;
        private Janus.Windows.GridEX.GridEX gridEXDiscountRefund;
    }
}