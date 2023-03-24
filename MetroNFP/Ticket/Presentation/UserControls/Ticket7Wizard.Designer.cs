namespace MetroNFP.Ticket.Presentation.UserControls
{
    partial class Ticket7Wizard
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
            this.chkBin = new System.Windows.Forms.CheckBox();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.cmbValidation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBin
            // 
            this.chkBin.AutoSize = true;
            this.chkBin.Location = new System.Drawing.Point(140, 130);
            this.chkBin.Name = "chkBin";
            this.chkBin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBin.Size = new System.Drawing.Size(215, 17);
            this.chkBin.TabIndex = 2;
            this.chkBin.Text = "استفاده از سطل آشغال پس از پایان اعتبار";
            this.chkBin.UseVisualStyleBackColor = true;
            // 
            // cmbIssue
            // 
            this.cmbIssue.DisplayMember = "PrintingProfileName";
            this.cmbIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Location = new System.Drawing.Point(66, 89);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(168, 21);
            this.cmbIssue.TabIndex = 1;
            this.cmbIssue.ValueMember = "PrintingProfileID";
            // 
            // cmbValidation
            // 
            this.cmbValidation.DisplayMember = "PrintingProfileName";
            this.cmbValidation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValidation.FormattingEnabled = true;
            this.cmbValidation.Location = new System.Drawing.Point(66, 54);
            this.cmbValidation.Name = "cmbValidation";
            this.cmbValidation.Size = new System.Drawing.Size(168, 21);
            this.cmbValidation.TabIndex = 0;
            this.cmbValidation.ValueMember = "PrintingProfileID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پروفایل پرینت در صدور: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "پروفایل پرینت در اعتبارسنجی: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Ticket7Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBin);
            this.Controls.Add(this.cmbIssue);
            this.Controls.Add(this.cmbValidation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ticket7Wizard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(393, 225);
            this.Load += new System.EventHandler(this.Common2Wizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBin;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.ComboBox cmbValidation;
    }
}
