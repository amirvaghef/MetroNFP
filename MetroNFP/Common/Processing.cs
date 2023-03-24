using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class Processing
    {
        private short processingID;
        public short ProcessingID
        {
            set
            {
                processingID = value;
            }
            get
            {
                return processingID;
            }
        }

        private string processingName;
        public string ProcessingName
        {
            set
            {
                processingName = value;
            }
            get
            {
                return processingName;
            }
        }
    }
}
