namespace Ticket.Presentation
{
    partial class FineMain
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
            Janus.Windows.GridEX.GridEXLayout gridEXFine_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineMain));
            this.gridEXFine = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXFine)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEXFine
            // 
            this.gridEXFine.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXFine.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            gridEXFine_DesignTimeLayout.LayoutString = resources.GetString("gridEXFine_DesignTimeLayout.LayoutString");
            this.gridEXFine.DesignTimeLayout = gridEXFine_DesignTimeLayout;
            this.gridEXFine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEXFine.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridEXFine.Location = new System.Drawing.Point(0, 0);
            this.gridEXFine.Name = "gridEXFine";
            this.gridEXFine.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXFine.Size = new System.Drawing.Size(676, 407);
            this.gridEXFine.TabIndex = 0;
            this.gridEXFine.DeletingRecords += new System.ComponentModel.CancelEventHandler(this.gridEXFine_DeletingRecords);
            this.gridEXFine.RecordAdded += new System.EventHandler(this.gridEXFine_RecordAdded);
            this.gridEXFine.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXFine_UpdatingRecord);
            this.gridEXFine.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridEXFine_AddingRecord);
            // 
            // FineMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(676, 407);
            this.Controls.Add(this.gridEXFine);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FineMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جریمه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridEXFine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEXFine;
    }
}