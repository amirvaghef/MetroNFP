using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PrintingDynamicMessage
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

        private short fk_printingProfileID;
        public short fk_PrintingProfileID
        {
            set
            {
                fk_printingProfileID = value;
            }
            get
            {
                return fk_printingProfileID;
            }
        }

        private int x;
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }

        private int y;
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }

        private float fontSize;
        public float FontSize
        {
            set
            {
                fontSize = value;
            }
            get
            {
                return fontSize;
            }
        }

        private bool direction;
        public bool Direction
        {
            set
            {
                direction = value;
            }
            get
            {
                return direction;
            }
        }

        private string font;
        public string Font
        {
            set
            {
                font = value;
            }
            get
            {
                return font;
            }
        }
    }
}
