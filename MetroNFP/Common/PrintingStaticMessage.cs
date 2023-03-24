using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class PrintingStaticMessage
    {
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

        private string printingStaticMessageData;
        public string PrintingStaticMessageData
        {
            set
            {
                printingStaticMessageData = value;
            }
            get
            {
                return printingStaticMessageData;
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
