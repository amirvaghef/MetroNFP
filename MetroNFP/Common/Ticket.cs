using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class Ticket
    {
        private short ticketID;
        public short TicketID
        {
            set
            {
                ticketID = value;
            }
            get
            {
                return ticketID;
            }
        }

        private string ticketName;
        public string TicketName
        {
            set
            {
                ticketName = value;
            }
            get
            {
                return ticketName;
            }
        }

        private string ticketShortName;
        public string TicketShortName
        {
            set
            {
                ticketShortName = value;
            }
            get
            {
                return ticketShortName;
            }
        }

        private short fk_ticketKindID;
        public short fk_TicketKindID
        {
            set
            {
                fk_ticketKindID = value;
            }
            get
            {
                return fk_ticketKindID;
            }
        }

        private short fk_mediaKindID;
        public short fk_MediaKindID
        {
            set
            {
                fk_mediaKindID = value;
            }
            get
            {
                return fk_mediaKindID;
            }
        }

        private short fk_sectionFareID;
        public short fk_SectionFareID
        {
            set
            {
                fk_sectionFareID = value;
            }
            get
            {
                return fk_sectionFareID;
            }
        }

        private decimal depositeValue;
        public decimal DepositeValue
        {
            set
            {
                depositeValue = value;
            }
            get
            {
                return depositeValue;
            }
        }

        private decimal amountDefault;
        public decimal AmountDefault
        {
            set
            {
                amountDefault = value;
            }
            get
            {
                return amountDefault;
            }
        }

        private short fk_discountID;
        public short fk_DiscountID
        {
            set
            {
                fk_discountID = value;
            }
            get
            {
                return fk_discountID;
            }
        }

        private short fk_refundID;
        public short fk_RefundID
        {
            set
            {
                fk_refundID = value;
            }
            get
            {
                return fk_refundID;
            }
        }

        private short fk_entryProcessingAlgorithmID;
        public short fk_EntryProcessingAlgorithmID
        {
            set
            {
                fk_entryProcessingAlgorithmID = value;
            }
            get
            {
                return fk_entryProcessingAlgorithmID;
            }
        }

        private short fk_exitProcessingAlgorithmID;
        public short fk_ExitProcessingAlgorithmID
        {
            set
            {
                fk_exitProcessingAlgorithmID = value;
            }
            get
            {
                return fk_exitProcessingAlgorithmID;
            }
        }

        private short fk_transferProfileID;
        public short fk_TransferProfileID
        {
            set
            {
                fk_transferProfileID = value;
            }
            get
            {
                return fk_transferProfileID;
            }
        }

        private decimal ticketCostNow;
        public decimal TicketCostNow
        {
            set
            {
                ticketCostNow = value;
            }
            get
            {
                return ticketCostNow;
            }
        }

        private decimal ticketCostFuture;
        public decimal TicketCostFuture
        {
            set
            {
                ticketCostFuture = value;
            }
            get
            {
                return ticketCostFuture;
            }
        }

        private short tripNumber;
        public short TripNumber
        {
            set
            {
                tripNumber = value;
            }
            get
            {
                return tripNumber;
            }
        }

        private short durationValidation;
        public short DurationValidation
        {
            set
            {
                durationValidation = value;
            }
            get
            {
                return durationValidation;
            }
        }

        private string startDate;
        public string StartDate
        {
            set
            {
                startDate = value;
            }
            get
            {
                return startDate;
            }
        }

        private string endDate;
        public string EndDate
        {
            set
            {
                endDate = value;
            }
            get
            {
                return endDate;
            }
        }

        private bool binTicket;
        public bool BinTicket
        {
            set
            {
                binTicket = value;
            }
            get
            {
                return binTicket;
            }
        }

        private short fk_validatingPrintingProfileID;
        public short fk_ValidatingPrintingProfileID
        {
            set
            {
                fk_validatingPrintingProfileID = value;
            }
            get
            {
                return fk_validatingPrintingProfileID;
            }
        }

        private short fk_issuingPrintingProfileID;
        public short fk_IssuingPrintingProfileID
        {
            set
            {
                fk_issuingPrintingProfileID = value;
            }
            get
            {
                return fk_issuingPrintingProfileID;
            }
        }

        private short fk_regularDaysSlotProfileID;
        public short fk_RegularDaysSlotProfileID
        {
            set
            {
                fk_regularDaysSlotProfileID = value;
            }
            get
            {
                return fk_regularDaysSlotProfileID;
            }
        }

        private short fk_schoolDaysSlotProfileID;
        public short fk_SchoolDaysSlotProfileID
        {
            set
            {
                fk_schoolDaysSlotProfileID = value;
            }
            get
            {
                return fk_schoolDaysSlotProfileID;
            }
        }

        private short fk_bankDaysSlotProfileID;
        public short fk_BankDaysSlotProfileID
        {
            set
            {
                fk_bankDaysSlotProfileID = value;
            }
            get
            {
                return fk_bankDaysSlotProfileID;
            }
        }

        private short fk_regularCostSlotProfileID;
        public short fk_RegularCostSlotProfileID
        {
            set
            {
                fk_regularCostSlotProfileID = value;
            }
            get
            {
                return fk_regularCostSlotProfileID;
            }
        }

        private short fk_schoolCostSlotProfileID;
        public short fk_SchoolCostSlotProfileID
        {
            set
            {
                fk_schoolCostSlotProfileID = value;
            }
            get
            {
                return fk_schoolCostSlotProfileID;
            }
        }

        private short fk_bankCostSlotProfileID;
        public short fk_BankCostSlotProfileID
        {
            set
            {
                fk_bankCostSlotProfileID = value;
            }
            get
            {
                return fk_bankCostSlotProfileID;
            }
        }

        private decimal reloadMinTreshold;
        public decimal ReloadMinTreshold
        {
            set
            {
                reloadMinTreshold = value;
            }
            get
            {
                return reloadMinTreshold;
            }
        }

        private decimal reloadMaxTreshold;
        public decimal ReloadMaxTreshold
        {
            set
            {
                reloadMaxTreshold = value;
            }
            get
            {
                return reloadMaxTreshold;
            }
        }

        private int issueMaxNumberOfTicket;
        public int IssueMaxNumberOfTicket
        {
            set
            {
                issueMaxNumberOfTicket = value;
            }
            get
            {
                return issueMaxNumberOfTicket;
            }
        }

        private bool saleExist;
        public bool SaleExist
        {
            set
            {
                saleExist = value;
            }
            get
            {
                return saleExist;
            }
        }

        private bool reloadExist;
        public bool ReloadExist
        {
            set
            {
                reloadExist = value;
            }
            get
            {
                return reloadExist;
            }
        }

        private short fk_prdProfileID;
        public short fk_PRDProfileID
        {
            set
            {
                fk_prdProfileID = value;
            }
            get
            {
                return fk_prdProfileID;
            }
        }
    }
}
