using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public enum NFPMessageBoxButtons
    {
        OK = 0,
        OkCancel = 1,
        AbortRetryIgnore = 2,
        RetryCancel = 3,
        YesNo = 4,
        YesNoCancel = 5,
    }

    public enum NFPMessageBoxIcon
    {
        None = 0,
        Warning = 1,
        Question = 2,
        Preference = 3,
        Information = 4,
        Help = 5,
        Error = 6,
        Delete = 7,
        Stop = 8,
    }

    public enum NFPMessageBoxDefaultButton
    {
        Button1 = 0,
        Button2 = 1,
        Button3 = 2,
    }

    public enum NFPMessageBoxOptions
    {
        LtrReading = 0,
        RtlReading = 1,
    }
}
