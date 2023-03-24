using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PrintingDynamicVariable
    {
        private short printingDynamicVariableID;
        public short PrintingDynamicVariableID
        {
            set
            {
                printingDynamicVariableID = value;
            }
            get
            {
                return printingDynamicVariableID;
            }
        }

        private string printingDynamicVariableName;
        public string PrintingDynamicVariableName
        {
            set
            {
                printingDynamicVariableName = value;
            }
            get
            {
                return printingDynamicVariableName;
            }
        }

        private string printingDynamicVariableData;
        public string PrintingDynamicVariableData
        {
            set
            {
                printingDynamicVariableData = value;
            }
            get
            {
                return printingDynamicVariableData;
            }
        }
    }
}
