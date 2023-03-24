namespace Ticket.Presentation
{
    partial class RejectCodeMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXRejectCode_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejectCodeMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXRejectCode = new Janus.Windows.GridEX.GridEX();
            this.llFine = new System.Windows.Forms.LinkLabel();
            this.llPRDMessage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRejectCode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridEXRejectCode);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.llFine);
            this.splitContainer1.Panel2.Controls.Add(this.llPRDMessage);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(971, 468);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridEXRejectCode
            // 
            this.gridEXRejectCode.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXRejectCode.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXRejectCode_DesignTimeLayout.LayoutString = resources.GetString("gridEXRejectCode_DesignTimeLayout.LayoutString");
            this.gridEXRejectCode.DesignTimeLayout = gridEXRejectCode_DesignTimeLayout;
            this.gridEXRejectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXRejectCode.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXRejectCode.Location = new System.Drawing.Point(0, 0);
            this.gridEXRejectCode.Name = "gridEXRejectCode";
            this.gridEXRejectCode.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXRejectCode.Size = new System.Drawing.Size(971, 423);
            this.gridEXRejectCode.TabIndex = 1;
            // 
            // llFine
            // 
            this.llFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llFine.AutoSize = true;
            this.llFine.Location = new System.Drawing.Point(822, 15);
            this.llFine.Name = "llFine";
            this.llFine.Size = new System.Drawing.Size(51, 13);
            this.llFine.TabIndex = 1;
            this.llFine.TabStop = true;
            this.llFine.Text = "جریمه PR";
            this.llFine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFine_LinkClicked);
            // 
            // llPRDMessage
            // 
            this.llPRDMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llPRDMessage.AutoSize = true;
            this.llPRDMessage.Location = new System.Drawing.Point(887, 14);
            this.llPRDMessage.Name = "llPRDMessage";
            this.llPRDMessage.Size = new System.Drawing.Size(79, 13);
            this.llPRDMessage.TabIndex = 0;
            this.llPRDMessage.TabStop = true;
            this.llPRDMessage.Text = "پیغام نمایش PR";
            this.llPRDMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPRDMessage_LinkClicked);
            // 
            // RejectCodeMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RejectCodeMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کدهای رد پردازش";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRejectCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.GridEX.GridEX gridEXRejectCode;
        private System.Windows.Forms.LinkLabel llFine;
        private System.Windows.Forms.LinkLabel llPRDMessage;

    }
}