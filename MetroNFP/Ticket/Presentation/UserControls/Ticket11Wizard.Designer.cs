namespace MetroNFP.Ticket.Presentation.UserControls
{
    partial class Ticket11Wizard
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
            this.chbReloadExist = new System.Windows.Forms.CheckBox();
            this.chbIssueExist = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaxIssue = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbReloadExist
            // 
            this.chbReloadExist.AutoSize = true;
            this.chbReloadExist.Location = new System.Drawing.Point(249, 132);
            this.chbReloadExist.Name = "chbReloadExist";
            this.chbReloadExist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbReloadExist.Size = new System.Drawing.Size(114, 17);
            this.chbReloadExist.TabIndex = 2;
            this.chbReloadExist.Text = "وجود در شارژ مجدد";
            this.chbReloadExist.UseVisualStyleBackColor = true;
            // 
            // chbIssueExist
            // 
            this.chbIssueExist.AutoSize = true;
            this.chbIssueExist.Location = new System.Drawing.Point(271, 97);
            this.chbIssueExist.Name = "chbIssueExist";
            this.chbIssueExist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbIssueExist.Size = new System.Drawing.Size(92, 17);
            this.chbIssueExist.TabIndex = 1;
            this.chbIssueExist.Text = "وجود در فروش";
            this.chbIssueExist.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "عدد";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "حداکثر تعداد صدور: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // txtMaxIssue
            // 
            this.txtMaxIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxIssue.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtMaxIssue.Location = new System.Drawing.Point(231, 59);
            this.txtMaxIssue.Mask = "00000";
            this.txtMaxIssue.Name = "txtMaxIssue";
            this.txtMaxIssue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaxIssue.Size = new System.Drawing.Size(41, 20);
            this.txtMaxIssue.TabIndex = 0;
            this.txtMaxIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ticket11Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaxIssue);
            this.Controls.Add(this.chbReloadExist);
            this.Controls.Add(this.chbIssueExist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Ticket11Wizard";
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
        private System.Windows.Forms.CheckBox chbReloadExist;
        private System.Windows.Forms.CheckBox chbIssueExist;
        private System.Windows.Forms.MaskedTextBox txtMaxIssue;
    }
}
