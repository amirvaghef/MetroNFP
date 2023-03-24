namespace Ticket.Presentation
{
    partial class PrintingProfileMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXPrintingProfile_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintingProfileMain));
            Janus.Windows.GridEX.GridEXLayout tempCombo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridEXPrintingProfile = new Janus.Windows.GridEX.GridEX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plCard = new System.Windows.Forms.Panel();
            this.tempCombo = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRTL = new System.Windows.Forms.RadioButton();
            this.btFontMessage = new System.Windows.Forms.Button();
            this.rbLTR = new System.Windows.Forms.RadioButton();
            this.btDynamicMessage = new System.Windows.Forms.Button();
            this.btStaticMessage = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXPrintingProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempCombo)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridEXPrintingProfile);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(931, 439);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridEXPrintingProfile
            // 
            this.gridEXPrintingProfile.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXPrintingProfile.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXPrintingProfile_DesignTimeLayout.LayoutString = resources.GetString("gridEXPrintingProfile_DesignTimeLayout.LayoutString");
            this.gridEXPrintingProfile.DesignTimeLayout = gridEXPrintingProfile_DesignTimeLayout;
            this.gridEXPrintingProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXPrintingProfile.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXPrintingProfile.Location = new System.Drawing.Point(0, 0);
            this.gridEXPrintingProfile.Name = "gridEXPrintingProfile";
            this.gridEXPrintingProfile.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXPrintingProfile.Size = new System.Drawing.Size(477, 439);
            this.gridEXPrintingProfile.TabIndex = 1;
            this.gridEXPrintingProfile.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_DeletingRecords);
            this.gridEXPrintingProfile.RecordAdded += new System.EventHandler(this.gridEXSectionFareProfile_RecordAdded);
            this.gridEXPrintingProfile.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_UpdatingRecord);
            this.gridEXPrintingProfile.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXSectionFareProfile_AddingRecord);
            this.gridEXPrintingProfile.SelectionChanged += new System.EventHandler(this.gridEXSectionFareProfile_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btReset);
            this.splitContainer2.Panel2.Controls.Add(this.btSubmit);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(450, 439);
            this.splitContainer2.SplitterDistance = 386;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tempCombo);
            this.panel1.Controls.Add(this.plCard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 386);
            this.panel1.TabIndex = 3;
            // 
            // plCard
            // 
            this.plCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plCard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.plCard.Location = new System.Drawing.Point(12, 52);
            this.plCard.Name = "plCard";
            this.plCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.plCard.Size = new System.Drawing.Size(431, 234);
            this.plCard.TabIndex = 1;
            this.plCard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plCard_MouseClick);
            this.plCard.MouseEnter += new System.EventHandler(this.plCard_MouseEnter);
            // 
            // tempCombo
            // 
            tempCombo_DesignTimeLayout.LayoutString = resources.GetString("tempCombo_DesignTimeLayout.LayoutString");
            this.tempCombo.DesignTimeLayout = tempCombo_DesignTimeLayout;
            this.tempCombo.DisplayMember = "PrintingDynamicVariableName";
            this.tempCombo.HasText = false;
            this.tempCombo.Location = new System.Drawing.Point(73, 314);
            this.tempCombo.Name = "tempCombo";
            this.tempCombo.SelectedIndex = -1;
            this.tempCombo.SelectedItem = null;
            this.tempCombo.Size = new System.Drawing.Size(111, 20);
            this.tempCombo.TabIndex = 2;
            this.tempCombo.ValueMember = "PrintingDynamicVariableID";
            this.tempCombo.Visible = false;
            this.tempCombo.ValueChanged += new System.EventHandler(this.tempCombo_ValueChanged);
            this.tempCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tempCombo_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRTL);
            this.panel2.Controls.Add(this.btFontMessage);
            this.panel2.Controls.Add(this.rbLTR);
            this.panel2.Controls.Add(this.btDynamicMessage);
            this.panel2.Controls.Add(this.btStaticMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 46);
            this.panel2.TabIndex = 0;
            // 
            // rbRTL
            // 
            this.rbRTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRTL.AutoSize = true;
            this.rbRTL.Location = new System.Drawing.Point(197, 26);
            this.rbRTL.Name = "rbRTL";
            this.rbRTL.Size = new System.Drawing.Size(85, 17);
            this.rbRTL.TabIndex = 1;
            this.rbRTL.TabStop = true;
            this.rbRTL.Text = "راست به چپ";
            this.rbRTL.UseVisualStyleBackColor = true;
            this.rbRTL.CheckedChanged += new System.EventHandler(this.rbLTR_CheckedChanged);
            // 
            // btFontMessage
            // 
            this.btFontMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFontMessage.Location = new System.Drawing.Point(288, 3);
            this.btFontMessage.Name = "btFontMessage";
            this.btFontMessage.Size = new System.Drawing.Size(48, 40);
            this.btFontMessage.TabIndex = 0;
            this.btFontMessage.Text = "فونت";
            this.btFontMessage.UseVisualStyleBackColor = true;
            this.btFontMessage.Click += new System.EventHandler(this.btFontMessage_Click);
            // 
            // rbLTR
            // 
            this.rbLTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLTR.AutoSize = true;
            this.rbLTR.Location = new System.Drawing.Point(197, 3);
            this.rbLTR.Name = "rbLTR";
            this.rbLTR.Size = new System.Drawing.Size(85, 17);
            this.rbLTR.TabIndex = 1;
            this.rbLTR.TabStop = true;
            this.rbLTR.Text = "چپ به راست";
            this.rbLTR.UseVisualStyleBackColor = true;
            this.rbLTR.CheckedChanged += new System.EventHandler(this.rbLTR_CheckedChanged);
            // 
            // btDynamicMessage
            // 
            this.btDynamicMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDynamicMessage.Location = new System.Drawing.Point(342, 3);
            this.btDynamicMessage.Name = "btDynamicMessage";
            this.btDynamicMessage.Size = new System.Drawing.Size(48, 40);
            this.btDynamicMessage.TabIndex = 0;
            this.btDynamicMessage.Text = "پیام متغیر";
            this.btDynamicMessage.UseVisualStyleBackColor = true;
            this.btDynamicMessage.Click += new System.EventHandler(this.btDynamicMessage_Click);
            // 
            // btStaticMessage
            // 
            this.btStaticMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStaticMessage.Location = new System.Drawing.Point(395, 3);
            this.btStaticMessage.Name = "btStaticMessage";
            this.btStaticMessage.Size = new System.Drawing.Size(48, 40);
            this.btStaticMessage.TabIndex = 0;
            this.btStaticMessage.Text = "پیام ثابت";
            this.btStaticMessage.UseVisualStyleBackColor = true;
            this.btStaticMessage.Click += new System.EventHandler(this.btStaticMessage_Click);
            // 
            // btReset
            // 
            this.btReset.AutoSize = true;
            this.btReset.Location = new System.Drawing.Point(56, 14);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(93, 23);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "لغو";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubmit.AutoSize = true;
            this.btSubmit.Location = new System.Drawing.Point(297, 14);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(93, 23);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "ذخیره";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // PrintingProfileMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(931, 439);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "PrintingProfileMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "PrintingProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXPrintingProfile)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempCombo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private Janus.Windows.GridEX.GridEX gridEXPrintingProfile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRTL;
        private System.Windows.Forms.Button btFontMessage;
        private System.Windows.Forms.RadioButton rbLTR;
        private System.Windows.Forms.Button btDynamicMessage;
        private System.Windows.Forms.Button btStaticMessage;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSubmit;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo tempCombo;
    }
}