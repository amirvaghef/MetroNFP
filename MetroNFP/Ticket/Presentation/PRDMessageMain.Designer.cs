namespace Ticket.Presentation
{
    partial class PRDMessageMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXPRDMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRDMessageMain));
            this.gridEXPRDMessage = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXPRDMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEXPRDMessage
            // 
            this.gridEXPRDMessage.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXPRDMessage.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXPRDMessage_DesignTimeLayout.LayoutString = resources.GetString("gridEXPRDMessage_DesignTimeLayout.LayoutString");
            this.gridEXPRDMessage.DesignTimeLayout = gridEXPRDMessage_DesignTimeLayout;
            this.gridEXPRDMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXPRDMessage.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXPRDMessage.Location = new System.Drawing.Point(0, 0);
            this.gridEXPRDMessage.Name = "gridEXPRDMessage";
            this.gridEXPRDMessage.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXPRDMessage.Size = new System.Drawing.Size(676, 407);
            this.gridEXPRDMessage.TabIndex = 0;
            this.gridEXPRDMessage.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXPRDMessage_DeletingRecords);
            this.gridEXPRDMessage.RecordAdded += new System.EventHandler(this.gridEXPRDMessage_RecordAdded);
            this.gridEXPRDMessage.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXPRDMessage_UpdatingRecord);
            this.gridEXPRDMessage.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXPRDMessage_AddingRecord);
            this.gridEXPRDMessage.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEXPRDMessage_ColumnButtonClick);
            // 
            // PRDMessageMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(676, 407);
            this.Controls.Add(this.gridEXPRDMessage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PRDMessageMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پیغام های PRD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridEXPRDMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEXPRDMessage;
    }
}