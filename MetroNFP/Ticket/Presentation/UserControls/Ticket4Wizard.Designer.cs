namespace MetroNFP.Ticket.Presentation.UserControls
{
    partial class Ticket4Wizard
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbTransferProfile = new System.Windows.Forms.ComboBox();
            this.cmbExitAlgorithm = new System.Windows.Forms.ComboBox();
            this.cmbEnterAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblDepositValue = new System.Windows.Forms.Label();
            this.labelShortname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(67, 107);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(30, 13);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ایجاد";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(67, 70);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ایجاد";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(67, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ایجاد";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbTransferProfile
            // 
            this.cmbTransferProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTransferProfile.DisplayMember = "TransferProfileName";
            this.cmbTransferProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransferProfile.FormattingEnabled = true;
            this.cmbTransferProfile.Location = new System.Drawing.Point(103, 104);
            this.cmbTransferProfile.Name = "cmbTransferProfile";
            this.cmbTransferProfile.Size = new System.Drawing.Size(204, 21);
            this.cmbTransferProfile.TabIndex = 2;
            this.cmbTransferProfile.ValueMember = "TransferProfileID";
            // 
            // cmbExitAlgorithm
            // 
            this.cmbExitAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExitAlgorithm.DisplayMember = "ProcessingAlgorithmProfileName";
            this.cmbExitAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExitAlgorithm.Location = new System.Drawing.Point(103, 67);
            this.cmbExitAlgorithm.Name = "cmbExitAlgorithm";
            this.cmbExitAlgorithm.Size = new System.Drawing.Size(204, 21);
            this.cmbExitAlgorithm.TabIndex = 1;
            this.cmbExitAlgorithm.ValueMember = "ProcessingAlgorithmProfileID";
            // 
            // cmbEnterAlgorithm
            // 
            this.cmbEnterAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEnterAlgorithm.DisplayMember = "ProcessingAlgorithmProfileName";
            this.cmbEnterAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnterAlgorithm.Location = new System.Drawing.Point(103, 31);
            this.cmbEnterAlgorithm.Name = "cmbEnterAlgorithm";
            this.cmbEnterAlgorithm.Size = new System.Drawing.Size(204, 21);
            this.cmbEnterAlgorithm.TabIndex = 0;
            this.cmbEnterAlgorithm.ValueMember = "ProcessingAlgorithmProfileID";
            // 
            // lblDepositValue
            // 
            this.lblDepositValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepositValue.AutoSize = true;
            this.lblDepositValue.Location = new System.Drawing.Point(313, 107);
            this.lblDepositValue.Name = "lblDepositValue";
            this.lblDepositValue.Size = new System.Drawing.Size(62, 13);
            this.lblDepositValue.TabIndex = 2;
            this.lblDepositValue.Text = "قانون تردد: ";
            // 
            // labelShortname
            // 
            this.labelShortname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(313, 70);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(79, 13);
            this.labelShortname.TabIndex = 1;
            this.labelShortname.Text = "الگوریتم خروج: ";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(313, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "الگوریتم ورود: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Ticket4Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbTransferProfile);
            this.Controls.Add(this.cmbExitAlgorithm);
            this.Controls.Add(this.cmbEnterAlgorithm);
            this.Controls.Add(this.lblDepositValue);
            this.Controls.Add(this.labelShortname);
            this.Controls.Add(this.labelName);
            this.Name = "Ticket4Wizard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(393, 225);
            this.Load += new System.EventHandler(this.Common2Wizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShortname;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbExitAlgorithm;
        private System.Windows.Forms.ComboBox cmbEnterAlgorithm;
        private System.Windows.Forms.Label lblDepositValue;
        private System.Windows.Forms.ComboBox cmbTransferProfile;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
