using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class MediaKind
    {
        private short mediaKindID;
        public short MediaKindID
        {
            get
            {
                return mediaKindID;
            }
            set
            {
                mediaKindID = value;
            }
        }

        private string mediaKindName;
        public string MediaKindName
        {
            get
            {
                return mediaKindName;
            }
            set
            {
                mediaKindName = value;
            }
        }
    }
}
