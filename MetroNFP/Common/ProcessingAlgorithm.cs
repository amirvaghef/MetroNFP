using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class ProcessingAlgorithm
    {
        public ProcessingAlgorithm()
        {
            fk_processingAlgorithmOperationKindID = 0;
            //fk_processingAlgorithmProfileID = 0;
            sequence = 0;
            fk_processingID = 0;
            fk_rejectCodeID = 0;
            fk_errorReaderMessage = 0;
            fk_entryReaderMessage = 0;
        }
        public ProcessingAlgorithm(short operationKind/*, short profile*/, short sequenc, short processing, short rejectCode, short errorReader, short entryReader)
        {
            fk_processingAlgorithmOperationKindID = operationKind;
            //fk_processingAlgorithmProfileID = profile;
            sequence = sequenc;
            fk_processingID = processing;
            fk_rejectCodeID = rejectCode;
            fk_errorReaderMessage = errorReader;
            fk_entryReaderMessage = entryReader;
        }

        private short fk_processingAlgorithmOperationKindID;
        public short fk_ProcessingAlgorithmOperationKindID
        {
            get
            {
                return fk_processingAlgorithmOperationKindID;
            }
            set
            {
                fk_processingAlgorithmOperationKindID = value;
            }
        }

        //private short fk_processingAlgorithmProfileID;
        //public short fk_ProcessingAlgorithmProfileID
        //{
        //    get
        //    {
        //        return fk_processingAlgorithmProfileID;
        //    }
        //    set
        //    {
        //        fk_processingAlgorithmProfileID = value;
        //    }
        //}

        private short sequence;
        public short Sequence
        {
            get
            {
                return sequence;
            }
            set
            {
                sequence = value;
            }
        }

        private short fk_processingID;
        public short fk_ProcessingID
        {
            get
            {
                return fk_processingID;
            }
            set
            {
                fk_processingID = value;
            }
        }

        private short fk_rejectCodeID;
        public short fk_RejectCodeID
        {
            get
            {
                return fk_rejectCodeID;
            }
            set
            {
                fk_rejectCodeID = value;
            }
        }

        private short fk_errorReaderMessage;
        public short fk_ErrorReaderMessage
        {
            get
            {
                return fk_errorReaderMessage;
            }
            set
            {
                fk_errorReaderMessage = value;
            }
        }

        private short fk_entryReaderMessage;
        public short fk_EntryReaderMessage
        {
            get
            {
                return fk_entryReaderMessage;
            }
            set
            {
                fk_entryReaderMessage = value;
            }
        }
    }
}
