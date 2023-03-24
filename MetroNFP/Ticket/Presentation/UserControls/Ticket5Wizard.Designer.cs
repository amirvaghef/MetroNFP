namespace MetroNFP.Ticket.Presentation.UserControls
{
    partial class Ticket5Wizard
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
            this.txtTripNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtDuration = new System.Windows.Forms.MaskedTextBox();
            this.lblTripAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTripNumber = new System.Windows.Forms.Label();
            this.lblDepositValue = new System.Windows.Forms.Label();
            this.labelShortname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCostNow = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtCostFuture = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTripNumber
            // 
            this.txtTripNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTripNumber.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtTripNumber.Location = new System.Drawing.Point(225, 138);
            this.txtTripNumber.Mask = "0000";
            this.txtTripNumber.Name = "txtTripNumber";
            this.txtTripNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTripNumber.Size = new System.Drawing.Size(41, 20);
            this.txtTripNumber.TabIndex = 3;
            this.txtTripNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDuration.Location = new System.Drawing.Point(225, 102);
            this.txtDuration.Mask = "000";
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDuration.Size = new System.Drawing.Size(41, 20);
            this.txtDuration.TabIndex = 2;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTripAmount
            // 
            this.lblTripAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTripAmount.AutoSize = true;
            this.lblTripAmount.Location = new System.Drawing.Point(196, 141);
            this.lblTripAmount.Name = "lblTripAmount";
            this.lblTripAmount.Size = new System.Drawing.Size(26, 13);
            this.lblTripAmount.TabIndex = 20;
            this.lblTripAmount.Text = "سفر";
            this.lblTripAmount.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "روز";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ریال";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ریال";
            // 
            // lblTripNumber
            // 
            this.lblTripNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTripNumber.AutoSize = true;
            this.lblTripNumber.Location = new System.Drawing.Point(269, 141);
            this.lblTripNumber.Name = "lblTripNumber";
            this.lblTripNumber.Size = new System.Drawing.Size(58, 13);
            this.lblTripNumber.TabIndex = 12;
            this.lblTripNumber.Text = "تعداد سفر: ";
            this.lblTripNumber.Visible = false;
            // 
            // lblDepositValue
            // 
            this.lblDepositValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepositValue.AutoSize = true;
            this.lblDepositValue.Location = new System.Drawing.Point(269, 105);
            this.lblDepositValue.Name = "lblDepositValue";
            this.lblDepositValue.Size = new System.Drawing.Size(121, 13);
            this.lblDepositValue.TabIndex = 2;
            this.lblDepositValue.Text = "تعداد روز اعتبار در سال: ";
            // 
            // labelShortname
            // 
            this.labelShortname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShortname.AutoSize = true;
            this.labelShortname.Location = new System.Drawing.Point(269, 70);
            this.labelShortname.Name = "labelShortname";
            this.labelShortname.Size = new System.Drawing.Size(57, 13);
            this.labelShortname.TabIndex = 1;
            this.labelShortname.Text = "قیمت آتی: ";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(269, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "قیمت فعلی: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // txtCostNow
            // 
            this.txtCostNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostNow.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtCostNow.FormatString = "#,###,###,###";
            this.txtCostNow.Location = new System.Drawing.Point(62, 33);
            this.txtCostNow.Name = "txtCostNow";
            this.txtCostNow.Size = new System.Drawing.Size(204, 20);
            this.txtCostNow.TabIndex = 0;
            this.txtCostNow.UseCompatibleTextRendering = true;
            this.txtCostNow.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtCostFuture
            // 
            this.txtCostFuture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostFuture.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
            this.txtCostFuture.FormatString = "#,###,###,###";
            this.txtCostFuture.Location = new System.Drawing.Point(62, 67);
            this.txtCostFuture.Name = "txtCostFuture";
            this.txtCostFuture.Size = new System.Drawing.Size(204, 20);
            this.txtCostFuture.TabIndex = 1;
            this.txtCostFuture.UseCompatibleTextRendering = true;
            this.txtCostFuture.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Ticket5Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCostFuture);
            this.Controls.Add(this.txtCostNow);
            this.Controls.Add(this.txtTripNumber);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblTripAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTripNumber);
            this.Controls.Add(this.lblDepositValue);
            this.Controls.Add(this.labelShortname);
            this.Controls.Add(this.labelName);
            this.Name = "Ticket5Wizard";
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
        private System.Windows.Forms.Label lblDepositValue;
        private System.Windows.Forms.Label lblTripAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTripNumber;
        private System.Windows.Forms.MaskedTextBox txtDuration;
        private System.Windows.Forms.MaskedTextBox txtTripNumber;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtCostFuture;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtCostNow;
    }
}
