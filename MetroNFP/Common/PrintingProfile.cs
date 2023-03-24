using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PrintingProfile
    {
        private short printingProfileID;
        public short PrintingProfileID
        {
            set
            {
                printingProfileID = value;
            }
            get
            {
                return printingProfileID;
            }
        }

        private string printingProfileName;
        public string PrintingProfileName
        {
            set
            {
                printingProfileName = value;
            }
            get
            {
                return printingProfileName;
            }
        }

        private bool printingProfileOperationKind;
        public bool PrintingProfileOperationKind
        {
            set
            {
                printingProfileOperationKind = value;
            }
            get
            {
                return printingProfileOperationKind;
            }
        }

        private List<PrintingDynamicMessage> printingDynamicMessages;
        public List<PrintingDynamicMessage> PrintingDynamicMessages
        {
            set
            {
                printingDynamicMessages = value;
            }
            get
            {
                return printingDynamicMessages;
            }
        }

        private List<PrintingStaticMessage> printingStaticMessages;
        public List<PrintingStaticMessage> PrintingStaticMessages
        {
            set
            {
                printingStaticMessages = value;
            }
            get
            {
                return printingStaticMessages;
            }
        }
    }
}
