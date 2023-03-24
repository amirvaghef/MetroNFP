namespace MetroNFP.Ticket.Presentation.UserControls
{
    partial class Ticket2Wizard
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbTicketKind = new System.Windows.Forms.ComboBox();
            this.cmbMediaKind = new System.Windows.Forms.ComboBox();
            this.lblDepositValue = new System.Windows.Forms.Label();
            this.labelShortname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDepositValue = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(70, 107);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(27, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "ریال";
            this.lblAmount.Visible = false;
            // 
            // cmbTicketKind
            // 
            this.cmbTicketKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTicketKind.DisplayMember = "TicketKindName";
            this.cmbTicketKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketKind.FormattingEnabled = true;
            this.cmbTicketKind.Location = new System.Drawing.Point(103, 67);
            this.cmbTicketKind.Name = "cmbTicketKind";
            this.cmbTicketKind.Size = new System.Drawing.Size(204, 21);
            this.cmbTicketKind.TabIndex = 1;
            this.cmbTicketKind.ValueMember = "TicketKindID";
            // 
            // cmbMediaKind
            // 
            this.cmbMediaKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMediaKind.DisplayMember = "MediaKindName";
            this.cmbMediaKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaKind.FormattingEnabled = true;
            this.cmbMediaKind.Location = new System.Drawing.Point(103, 31);
            this.cmbMediaKind.Name = "cmbMediaKind";
            this.cmbMediaKind.Size = new System.Drawing.Size(204, 21);
            this.cmbMediaKind.TabIndex = 0;
            this.cmbMediaKind.ValueMember = "MediaKindID";
            this.cmbMediaKind.SelectedIndexChanged += new System.EventHandler(this.cmbMediaKind_SelectedIndexChanged);
            // 
            // lblDepositValue
            // 
            this.lblDepositValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepositValue.AutoSize = true;
            this.lblDepositValue.Location = new System.Drawing.Point(313, 107);
            this.lblDepositValue.Name = "lblDepositValue";
            this.lblDepositValue.Size = new System.Drawing.Size(61, 13);
            this.lblDepositValue.TabIndex = 2;
            this.lblDepositValue.Text = "مبلغ ودیعه: ";
            this.lblDepositValue.Visible = false;
            // 
            // labelShortname
            // 
            this.labelShortname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(313, 70);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(52, 13);
            this.labelShortname.TabIndex = 1;
            this.labelShortname.Text = "نوع بلیت: ";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(313, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "نوع مدیا: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // txtDepositValue
            // 
            this.txtDepositValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepositValue.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtDepositValue.FormatString = "#,###,###,###";
            this.txtDepositValue.Location = new System.Drawing.Point(103, 104);
            this.txtDepositValue.Name = "txtDepositValue";
            this.txtDepositValue.Size = new System.Drawing.Size(204, 20);
            this.txtDepositValue.TabIndex = 2;
            this.txtDepositValue.UseCompatibleTextRendering = true;
            this.txtDepositValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Ticket2Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDepositValue);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbTicketKind);
            this.Controls.Add(this.cmbMediaKind);
            this.Controls.Add(this.lblDepositValue);
            this.Controls.Add(this.labelShortname);
            this.Controls.Add(this.labelName);
            this.Name = "Ticket2Wizard";
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
        private System.Windows.Forms.ComboBox cmbTicketKind;
        private System.Windows.Forms.ComboBox cmbMediaKind;
        private System.Windows.Forms.Label lblDepositValue;
        private System.Windows.Forms.Label lblAmount;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtDepositValue;
    }
}
