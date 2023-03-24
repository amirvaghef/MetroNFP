namespace Ticket.Presentation
{
    partial class TicketMain
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTicketList = new System.Windows.Forms.DataGridView();
            this.TicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_TicketKindID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_MediaKindID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_SectionFareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_DiscountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_RefundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_EntryProcessingAlgorithmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_ExitProcessingAlgorithmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_TransferProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketCostNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketCostFuture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationValidation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BinTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_ValidatingPrintingProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_IssuingPrintingProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_RegularDaysSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_SchoolDaysSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_BankDaysSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_RegularCostSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_SchoolCostSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_BankCostSlotProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadMinTreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadMaxTreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueMaxNumberOfTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleExist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReloadExist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_PRDProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(535, 266);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.buttonDelete);
            this.BottomPanel.Controls.Add(this.buttonEdit);
            this.BottomPanel.Controls.Add(this.buttonInsert);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 212);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(535, 54);
            this.BottomPanel.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(225, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 25);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(328, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 25);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Location = new System.Drawing.Point(431, 19);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(95, 25);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "درج";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.AutoScroll = true;
            this.TopPanel.Controls.Add(this.dataGridViewTicketList);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(535, 212);
            this.TopPanel.TabIndex = 0;
            // 
            // dataGridViewTicketList
            // 
            this.dataGridViewTicketList.AllowUserToAddRows = false;
            this.dataGridViewTicketList.AllowUserToDeleteRows = false;
            this.dataGridViewTicketList.AllowUserToOrderColumns = true;
            this.dataGridViewTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketID,
            this.TicketName,
            this.TicketShortName,
            this.fk_TicketKindID,
            this.fk_MediaKindID,
            this.fk_SectionFareID,
            this.DepositeValue,
            this.AmountDefault,
            this.fk_DiscountID,
            this.fk_RefundID,
            this.fk_EntryProcessingAlgorithmID,
            this.fk_ExitProcessingAlgorithmID,
            this.fk_TransferProfileID,
            this.TicketCostNow,
            this.TicketCostFuture,
            this.TripNumber,
            this.DurationValidation,
            this.StartDate,
            this.EndDate,
            this.BinTicket,
            this.fk_ValidatingPrintingProfileID,
            this.fk_IssuingPrintingProfileID,
            this.fk_RegularDaysSlotProfileID,
            this.fk_SchoolDaysSlotProfileID,
            this.fk_BankDaysSlotProfileID,
            this.fk_RegularCostSlotProfileID,
            this.fk_SchoolCostSlotProfileID,
            this.fk_BankCostSlotProfileID,
            this.ReloadMinTreshold,
            this.ReloadMaxTreshold,
            this.IssueMaxNumberOfTicket,
            this.SaleExist,
            this.ReloadExist,
            this.fk_PRDProfileID});
            this.dataGridViewTicketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTicketList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTicketList.MultiSelect = false;
            this.dataGridViewTicketList.Name = "dataGridViewTicketList";
            this.dataGridViewTicketList.ReadOnly = true;
            this.dataGridViewTicketList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTicketList.Size = new System.Drawing.Size(535, 212);
            this.dataGridViewTicketList.StandardTab = true;
            this.dataGridViewTicketList.TabIndex = 0;
            this.dataGridViewTicketList.VirtualMode = true;
            this.dataGridViewTicketList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicketList_CellContentClick);
            // 
            // TicketID
            // 
            this.TicketID.DataPropertyName = "TicketID";
            this.TicketID.HeaderText = "شماره بلیت";
            this.TicketID.Name = "TicketID";
            this.TicketID.ReadOnly = true;
            // 
            // TicketName
            // 
            this.TicketName.DataPropertyName = "TicketName";
            this.TicketName.HeaderText = "نام بلیت";
            this.TicketName.Name = "TicketName";
            this.TicketName.ReadOnly = true;
            this.TicketName.Width = 200;
            // 
            // TicketShortName
            // 
            this.TicketShortName.DataPropertyName = "TicketShortName";
            this.TicketShortName.HeaderText = "نام مختصر";
            this.TicketShortName.Name = "TicketShortName";
            this.TicketShortName.ReadOnly = true;
            // 
            // fk_TicketKindID
            // 
            this.fk_TicketKindID.DataPropertyName = "fk_TicketKindID";
            this.fk_TicketKindID.HeaderText = "نوع بلیت";
            this.fk_TicketKindID.Name = "fk_TicketKindID";
            this.fk_TicketKindID.ReadOnly = true;
            // 
            // fk_MediaKindID
            // 
            this.fk_MediaKindID.DataPropertyName = "fk_MediaKindID";
            this.fk_MediaKindID.HeaderText = "نوع مدیا";
            this.fk_MediaKindID.Name = "fk_MediaKindID";
            this.fk_MediaKindID.ReadOnly = true;
            // 
            // fk_SectionFareID
            // 
            this.fk_SectionFareID.DataPropertyName = "fk_SectionFareID";
            this.fk_SectionFareID.HeaderText = "کرایه";
            this.fk_SectionFareID.Name = "fk_SectionFareID";
            this.fk_SectionFareID.ReadOnly = true;
            // 
            // DepositeValue
            // 
            this.DepositeValue.DataPropertyName = "DepositeValue";
            this.DepositeValue.HeaderText = "مبلغ ودیعه";
            this.DepositeValue.Name = "DepositeValue";
            this.DepositeValue.ReadOnly = true;
            // 
            // AmountDefault
            // 
            this.AmountDefault.DataPropertyName = "AmountDefault";
            this.AmountDefault.HeaderText = "مبلغ اولیه";
            this.AmountDefault.Name = "AmountDefault";
            this.AmountDefault.ReadOnly = true;
            // 
            // fk_DiscountID
            // 
            this.fk_DiscountID.DataPropertyName = "fk_DiscountID";
            this.fk_DiscountID.HeaderText = "تخفیف";
            this.fk_DiscountID.Name = "fk_DiscountID";
            this.fk_DiscountID.ReadOnly = true;
            // 
            // fk_RefundID
            // 
            this.fk_RefundID.DataPropertyName = "fk_RefundID";
            this.fk_RefundID.HeaderText = "استرداد";
            this.fk_RefundID.Name = "fk_RefundID";
            this.fk_RefundID.ReadOnly = true;
            // 
            // fk_EntryProcessingAlgorithmID
            // 
            this.fk_EntryProcessingAlgorithmID.DataPropertyName = "fk_EntryProcessingAlgorithmID";
            this.fk_EntryProcessingAlgorithmID.HeaderText = "الگوریتم ورود";
            this.fk_EntryProcessingAlgorithmID.Name = "fk_EntryProcessingAlgorithmID";
            this.fk_EntryProcessingAlgorithmID.ReadOnly = true;
            // 
            // fk_ExitProcessingAlgorithmID
            // 
            this.fk_ExitProcessingAlgorithmID.DataPropertyName = "fk_ExitProcessingAlgorithmID";
            this.fk_ExitProcessingAlgorithmID.HeaderText = "الگوریتم خروج";
            this.fk_ExitProcessingAlgorithmID.Name = "fk_ExitProcessingAlgorithmID";
            this.fk_ExitProcessingAlgorithmID.ReadOnly = true;
            // 
            // fk_TransferProfileID
            // 
            this.fk_TransferProfileID.DataPropertyName = "fk_TransferProfileID";
            this.fk_TransferProfileID.HeaderText = "پروفایل انتقال";
            this.fk_TransferProfileID.Name = "fk_TransferProfileID";
            this.fk_TransferProfileID.ReadOnly = true;
            // 
            // TicketCostNow
            // 
            this.TicketCostNow.DataPropertyName = "TicketCostNow";
            this.TicketCostNow.HeaderText = "مبلغ فعلی بلیت";
            this.TicketCostNow.Name = "TicketCostNow";
            this.TicketCostNow.ReadOnly = true;
            this.TicketCostNow.Width = 120;
            // 
            // TicketCostFuture
            // 
            this.TicketCostFuture.DataPropertyName = "TicketCostFuture";
            this.TicketCostFuture.HeaderText = "مبلغ آینده بلیت";
            this.TicketCostFuture.Name = "TicketCostFuture";
            this.TicketCostFuture.ReadOnly = true;
            // 
            // TripNumber
            // 
            this.TripNumber.DataPropertyName = "TripNumber";
            this.TripNumber.HeaderText = "تعداد سفر";
            this.TripNumber.Name = "TripNumber";
            this.TripNumber.ReadOnly = true;
            // 
            // DurationValidation
            // 
            this.DurationValidation.DataPropertyName = "DurationValidation";
            this.DurationValidation.HeaderText = "دوره اعتبار";
            this.DurationValidation.Name = "DurationValidation";
            this.DurationValidation.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "تاریخ شروع";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "تاریخ پایان";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // BinTicket
            // 
            this.BinTicket.DataPropertyName = "BinTicket";
            this.BinTicket.HeaderText = "آشغال؟";
            this.BinTicket.Name = "BinTicket";
            this.BinTicket.ReadOnly = true;
            // 
            // fk_ValidatingPrintingProfileID
            // 
            this.fk_ValidatingPrintingProfileID.DataPropertyName = "fk_ValidatingPrintingProfileID";
            this.fk_ValidatingPrintingProfileID.HeaderText = "پروفایل چاپ اعتبارسنجی";
            this.fk_ValidatingPrintingProfileID.Name = "fk_ValidatingPrintingProfileID";
            this.fk_ValidatingPrintingProfileID.ReadOnly = true;
            this.fk_ValidatingPrintingProfileID.Width = 150;
            // 
            // fk_IssuingPrintingProfileID
            // 
            this.fk_IssuingPrintingProfileID.DataPropertyName = "fk_IssuingPrintingProfileID";
            this.fk_IssuingPrintingProfileID.HeaderText = "پروفایل چاپ صدور";
            this.fk_IssuingPrintingProfileID.Name = "fk_IssuingPrintingProfileID";
            this.fk_IssuingPrintingProfileID.ReadOnly = true;
            this.fk_IssuingPrintingProfileID.Width = 150;
            // 
            // fk_RegularDaysSlotProfileID
            // 
            this.fk_RegularDaysSlotProfileID.DataPropertyName = "fk_RegularDaysSlotProfileID";
            this.fk_RegularDaysSlotProfileID.HeaderText = "پروفایل روزهای معمولی";
            this.fk_RegularDaysSlotProfileID.Name = "fk_RegularDaysSlotProfileID";
            this.fk_RegularDaysSlotProfileID.ReadOnly = true;
            this.fk_RegularDaysSlotProfileID.Width = 150;
            // 
            // fk_SchoolDaysSlotProfileID
            // 
            this.fk_SchoolDaysSlotProfileID.DataPropertyName = "fk_SchoolDaysSlotProfileID";
            this.fk_SchoolDaysSlotProfileID.HeaderText = "پروفایل روزهای مدرسه";
            this.fk_SchoolDaysSlotProfileID.Name = "fk_SchoolDaysSlotProfileID";
            this.fk_SchoolDaysSlotProfileID.ReadOnly = true;
            this.fk_SchoolDaysSlotProfileID.Width = 150;
            // 
            // fk_BankDaysSlotProfileID
            // 
            this.fk_BankDaysSlotProfileID.DataPropertyName = "fk_BankDaysSlotProfileID";
            this.fk_BankDaysSlotProfileID.HeaderText = "پروفایل تعطیلات رسمی";
            this.fk_BankDaysSlotProfileID.Name = "fk_BankDaysSlotProfileID";
            this.fk_BankDaysSlotProfileID.ReadOnly = true;
            this.fk_BankDaysSlotProfileID.Width = 150;
            // 
            // fk_RegularCostSlotProfileID
            // 
            this.fk_RegularCostSlotProfileID.DataPropertyName = "fk_RegularCostSlotProfileID";
            this.fk_RegularCostSlotProfileID.HeaderText = "پروفایل قیمت روزهای معمولی";
            this.fk_RegularCostSlotProfileID.Name = "fk_RegularCostSlotProfileID";
            this.fk_RegularCostSlotProfileID.ReadOnly = true;
            this.fk_RegularCostSlotProfileID.Width = 170;
            // 
            // fk_SchoolCostSlotProfileID
            // 
            this.fk_SchoolCostSlotProfileID.DataPropertyName = "fk_SchoolCostSlotProfileID";
            this.fk_SchoolCostSlotProfileID.HeaderText = "پروفایل قیمت روزهای مدرسه";
            this.fk_SchoolCostSlotProfileID.Name = "fk_SchoolCostSlotProfileID";
            this.fk_SchoolCostSlotProfileID.ReadOnly = true;
            this.fk_SchoolCostSlotProfileID.Width = 170;
            // 
            // fk_BankCostSlotProfileID
            // 
            this.fk_BankCostSlotProfileID.DataPropertyName = "fk_BankCostSlotProfileID";
            this.fk_BankCostSlotProfileID.HeaderText = "پروفایل قیمت تعطیلات رسمی";
            this.fk_BankCostSlotProfileID.Name = "fk_BankCostSlotProfileID";
            this.fk_BankCostSlotProfileID.ReadOnly = true;
            this.fk_BankCostSlotProfileID.Width = 170;
            // 
            // ReloadMinTreshold
            // 
            this.ReloadMinTreshold.DataPropertyName = "ReloadMinTreshold";
            this.ReloadMinTreshold.HeaderText = "حداقل آستانه شارژ مجدد";
            this.ReloadMinTreshold.Name = "ReloadMinTreshold";
            this.ReloadMinTreshold.ReadOnly = true;
            this.ReloadMinTreshold.Width = 150;
            // 
            // ReloadMaxTreshold
            // 
            this.ReloadMaxTreshold.DataPropertyName = "ReloadMaxTreshold";
            this.ReloadMaxTreshold.HeaderText = "حداکثر آستانه شارژ مجدد";
            this.ReloadMaxTreshold.Name = "ReloadMaxTreshold";
            this.ReloadMaxTreshold.ReadOnly = true;
            this.ReloadMaxTreshold.Width = 150;
            // 
            // IssueMaxNumberOfTicket
            // 
            this.IssueMaxNumberOfTicket.DataPropertyName = "IssueMaxNumberOfTicket";
            this.IssueMaxNumberOfTicket.HeaderText = "حداکثر تعداد صدور بلیت";
            this.IssueMaxNumberOfTicket.Name = "IssueMaxNumberOfTicket";
            this.IssueMaxNumberOfTicket.ReadOnly = true;
            this.IssueMaxNumberOfTicket.Width = 150;
            // 
            // SaleExist
            // 
            this.SaleExist.DataPropertyName = "SaleExist";
            this.SaleExist.HeaderText = "وجود در فروش";
            this.SaleExist.Name = "SaleExist";
            this.SaleExist.ReadOnly = true;
            // 
            // ReloadExist
            // 
            this.ReloadExist.DataPropertyName = "ReloadExist";
            this.ReloadExist.HeaderText = "وجود در شارژ";
            this.ReloadExist.Name = "ReloadExist";
            this.ReloadExist.ReadOnly = true;
            // 
            // fk_PRDProfileID
            // 
            this.fk_PRDProfileID.DataPropertyName = "fk_PRDProfileID";
            this.fk_PRDProfileID.HeaderText = "پروفایل PRD";
            this.fk_PRDProfileID.Name = "fk_PRDProfileID";
            this.fk_PRDProfileID.ReadOnly = true;
            // 
            // TicketMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(535, 266);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(543, 300);
            this.Name = "TicketMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بلیت ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewTicketList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_TicketKindID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_MediaKindID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_SectionFareID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_DiscountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_RefundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_EntryProcessingAlgorithmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_ExitProcessingAlgorithmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_TransferProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketCostNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketCostFuture;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationValidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BinTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_ValidatingPrintingProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_IssuingPrintingProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_RegularDaysSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_SchoolDaysSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_BankDaysSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_RegularCostSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_SchoolCostSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_BankCostSlotProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReloadMinTreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReloadMaxTreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueMaxNumberOfTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleExist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReloadExist;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_PRDProfileID;

    }
}