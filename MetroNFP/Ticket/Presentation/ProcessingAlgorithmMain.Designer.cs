namespace Ticket.Presentation
{
    partial class ProcessingAlgorithmMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXProcessingAlgorithmProfile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessingAlgorithmMain));
            Janus.Windows.GridEX.GridEXLayout gridEXProcessingAlgorithm_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridEXProcessingAlgorithmProfile = new Janus.Windows.GridEX.GridEX();
            this.llPRDMessage = new System.Windows.Forms.LinkLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gridEXProcessingAlgorithm = new Janus.Windows.GridEX.GridEX();
            this.llbEnterMessage = new System.Windows.Forms.LinkLabel();
            this.llbErrorMessage = new System.Windows.Forms.LinkLabel();
            this.llbRejectCode = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXProcessingAlgorithmProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXProcessingAlgorithm)).BeginInit();
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
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridEXProcessingAlgorithmProfile);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.llPRDMessage);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(487, 468);
            this.splitContainer2.SplitterDistance = 423;
            this.splitContainer2.TabIndex = 0;
            // 
            // gridEXProcessingAlgorithmProfile
            // 
            this.gridEXProcessingAlgorithmProfile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXProcessingAlgorithmProfile_DesignTimeLayout.LayoutString = resources.GetString("gridEXProcessingAlgorithmProfile_DesignTimeLayout.LayoutString");
            this.gridEXProcessingAlgorithmProfile.DesignTimeLayout = gridEXProcessingAlgorithmProfile_DesignTimeLayout;
            this.gridEXProcessingAlgorithmProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXProcessingAlgorithmProfile.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXProcessingAlgorithmProfile.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXProcessingAlgorithmProfile.Location = new System.Drawing.Point(0, 0);
            this.gridEXProcessingAlgorithmProfile.Name = "gridEXProcessingAlgorithmProfile";
            this.gridEXProcessingAlgorithmProfile.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXProcessingAlgorithmProfile.Size = new System.Drawing.Size(487, 423);
            this.gridEXProcessingAlgorithmProfile.TabIndex = 1;
            this.gridEXProcessingAlgorithmProfile.RecordAdded += new System.EventHandler(this.gridEXProcessingAlgorithmProfile_RecordAdded);
            this.gridEXProcessingAlgorithmProfile.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXProcessingAlgorithmProfile_UpdatingRecord);
            this.gridEXProcessingAlgorithmProfile.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXProcessingAlgorithmProfile_AddingRecord);
            this.gridEXProcessingAlgorithmProfile.SelectionChanged += new System.EventHandler(this.gridEXProcessingAlgorithmProfile_SelectionChanged);
            // 
            // llPRDMessage
            // 
            this.llPRDMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llPRDMessage.AutoSize = true;
            this.llPRDMessage.Location = new System.Drawing.Point(396, 15);
            this.llPRDMessage.Name = "llPRDMessage";
            this.llPRDMessage.Size = new System.Drawing.Size(87, 13);
            this.llPRDMessage.TabIndex = 1;
            this.llPRDMessage.TabStop = true;
            this.llPRDMessage.Text = "ایجاد پیغام پذیرش";
            this.llPRDMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPRDMessage_LinkClicked);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gridEXProcessingAlgorithm);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.llbEnterMessage);
            this.splitContainer3.Panel2.Controls.Add(this.llbErrorMessage);
            this.splitContainer3.Panel2.Controls.Add(this.llbRejectCode);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(480, 468);
            this.splitContainer3.SplitterDistance = 423;
            this.splitContainer3.TabIndex = 0;
            // 
            // gridEXProcessingAlgorithm
            // 
            this.gridEXProcessingAlgorithm.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXProcessingAlgorithm.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXProcessingAlgorithm_DesignTimeLayout.LayoutString = resources.GetString("gridEXProcessingAlgorithm_DesignTimeLayout.LayoutString");
            this.gridEXProcessingAlgorithm.DesignTimeLayout = gridEXProcessingAlgorithm_DesignTimeLayout;
            this.gridEXProcessingAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXProcessingAlgorithm.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXProcessingAlgorithm.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEXProcessingAlgorithm.Location = new System.Drawing.Point(0, 0);
            this.gridEXProcessingAlgorithm.Name = "gridEXProcessingAlgorithm";
            this.gridEXProcessingAlgorithm.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXProcessingAlgorithm.Size = new System.Drawing.Size(480, 423);
            this.gridEXProcessingAlgorithm.TabIndex = 1;
            this.gridEXProcessingAlgorithm.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXProcessingAlgorithm_DeletingRecords);
            this.gridEXProcessingAlgorithm.RecordAdded += new System.EventHandler(this.gridEXProcessingAlgorithm_RecordAdded);
            this.gridEXProcessingAlgorithm.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXProcessingAlgorithm_UpdatingRecord);
            this.gridEXProcessingAlgorithm.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXProcessingAlgorithm_AddingRecord);
            // 
            // llbEnterMessage
            // 
            this.llbEnterMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbEnterMessage.AutoSize = true;
            this.llbEnterMessage.Location = new System.Drawing.Point(268, 15);
            this.llbEnterMessage.Name = "llbEnterMessage";
            this.llbEnterMessage.Size = new System.Drawing.Size(52, 13);
            this.llbEnterMessage.TabIndex = 4;
            this.llbEnterMessage.TabStop = true;
            this.llbEnterMessage.Text = "پیغام ورود";
            this.llbEnterMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEnterMessage_LinkClicked);
            // 
            // llbErrorMessage
            // 
            this.llbErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbErrorMessage.AutoSize = true;
            this.llbErrorMessage.Location = new System.Drawing.Point(330, 15);
            this.llbErrorMessage.Name = "llbErrorMessage";
            this.llbErrorMessage.Size = new System.Drawing.Size(51, 13);
            this.llbErrorMessage.TabIndex = 3;
            this.llbErrorMessage.TabStop = true;
            this.llbErrorMessage.Text = "پیغام خطا";
            this.llbErrorMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbErrorMessage_LinkClicked);
            // 
            // llbRejectCode
            // 
            this.llbRejectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbRejectCode.AutoSize = true;
            this.llbRejectCode.Location = new System.Drawing.Point(389, 15);
            this.llbRejectCode.Name = "llbRejectCode";
            this.llbRejectCode.Size = new System.Drawing.Size(66, 13);
            this.llbRejectCode.TabIndex = 2;
            this.llbRejectCode.TabStop = true;
            this.llbRejectCode.Text = "کد رد پردازش";
            this.llbRejectCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRejectCode_LinkClicked);
            // 
            // ProcessingAlgorithmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 468);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "ProcessingAlgorithmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الگوریتم های ورود/خروج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXProcessingAlgorithmProfile)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXProcessingAlgorithm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Janus.Windows.GridEX.GridEX gridEXProcessingAlgorithmProfile;
        private System.Windows.Forms.LinkLabel llPRDMessage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Janus.Windows.GridEX.GridEX gridEXProcessingAlgorithm;
        private System.Windows.Forms.LinkLabel llbErrorMessage;
        private System.Windows.Forms.LinkLabel llbRejectCode;
        private System.Windows.Forms.LinkLabel llbEnterMessage;
    }
}