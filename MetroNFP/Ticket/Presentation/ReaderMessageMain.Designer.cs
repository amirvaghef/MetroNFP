namespace Ticket.Presentation
{
    partial class ReaderMessageMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXReaderMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderMessageMain));
            this.gridEXReaderMessage = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXReaderMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEXReaderMessage
            // 
            this.gridEXReaderMessage.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXReaderMessage.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXReaderMessage_DesignTimeLayout.LayoutString = resources.GetString("gridEXReaderMessage_DesignTimeLayout.LayoutString");
            this.gridEXReaderMessage.DesignTimeLayout = gridEXReaderMessage_DesignTimeLayout;
            this.gridEXReaderMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXReaderMessage.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXReaderMessage.Location = new System.Drawing.Point(0, 0);
            this.gridEXReaderMessage.Name = "gridEXReaderMessage";
            this.gridEXReaderMessage.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXReaderMessage.Size = new System.Drawing.Size(676, 407);
            this.gridEXReaderMessage.TabIndex = 0;
            this.gridEXReaderMessage.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXReaderMessage_DeletingRecords);
            this.gridEXReaderMessage.RecordAdded += new System.EventHandler(this.gridEXReaderMessage_RecordAdded);
            this.gridEXReaderMessage.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXReaderMessage_UpdatingRecord);
            this.gridEXReaderMessage.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXReaderMessage_AddingRecord);
            this.gridEXReaderMessage.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridEXReaderMessage_ColumnButtonClick);
            // 
            // ReaderMessageMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(676, 407);
            this.Controls.Add(this.gridEXReaderMessage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReaderMessageMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پیغام های Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridEXReaderMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEXReaderMessage;
    }
}