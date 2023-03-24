using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class ProcessingAlgorithmProfile
    {
        public ProcessingAlgorithmProfile()
        {
            processingAlgorithmProfileID = 0;
            processingAlgorithmProfileName = "";
            fk_readerMessageID = 0;
            processingAlgorithms = null;
        }
        public ProcessingAlgorithmProfile(short id, string name, short readerMessage, List<ProcessingAlgorithm> algorithms)
        {
            processingAlgorithmProfileID = id;
            processingAlgorithmProfileName = name;
            fk_readerMessageID = readerMessage;
            processingAlgorithms = algorithms;
        }

        private short processingAlgorithmProfileID;
        public short ProcessingAlgorithmProfileID
        {
            get
            {
                return processingAlgorithmProfileID;
            }
            set
            {
                processingAlgorithmProfileID = value;
            }
        }

        private string processingAlgorithmProfileName;
        public string ProcessingAlgorithmProfileName
        {
            get
            {
                return processingAlgorithmProfileName;
            }
            set
            {
                processingAlgorithmProfileName = value;
            }
        }

        private short fk_readerMessageID;
        public short fk_ReaderMessageID
        {
            get
            {
                return fk_readerMessageID;
            }
            set
            {
                fk_readerMessageID = value;
            }

        }

        private List<ProcessingAlgorithm> processingAlgorithms;
        public List<ProcessingAlgorithm> ProcessingAlgorithms
        {
            get
            {
                return processingAlgorithms;
            }
            set
            {
                processingAlgorithms = value;
            }
        }
    }
}
