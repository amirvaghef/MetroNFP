using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class ProcessingAlgorithmOperationKind
    {
        private short processingAlgorithmOperationKindID;
        public short ProcessingAlgorithmOperationKindID
        {
            set
            {
                processingAlgorithmOperationKindID = value;
            }
            get
            {
                return processingAlgorithmOperationKindID;
            }
        }

        private string processingAlgorithmOperationKindName;
        public string ProcessingAlgorithmOperationKindName
        {
            set
            {
                processingAlgorithmOperationKindName = value;
            }
            get
            {
                return processingAlgorithmOperationKindName;
            }
        }
    }
}
