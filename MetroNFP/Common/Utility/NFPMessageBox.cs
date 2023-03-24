using System;
using System.Collections.Generic;
using BehComponents;
using System.Text;
using System.Windows.Forms;


namespace Common.Utility
{
    public class NFPMessageBox
    {
        //public static DialogResult Show(MessageBoxFarsiStyle style)
        //{
        //    return MessageBoxFarsi.Show(style);
        //}
        public static DialogResult Show(string text)
        {
            return MessageBoxFarsi.Show(text);
        }
        public static DialogResult Show(string text, string caption)
        {
            return MessageBoxFarsi.Show(text, caption);
        }
        public static DialogResult Show(string text, string caption, NFPMessageBoxButtons buttons)
        {
            MessageBoxFarsiButtons farsiButtons = AssignButtons(buttons);
            
            return MessageBoxFarsi.Show(text, caption, farsiButtons);
        }
        public static DialogResult Show(string text, string caption, NFPMessageBoxButtons buttons, NFPMessageBoxIcon icon)
        {
            MessageBoxFarsiButtons farsiButtons = AssignButtons(buttons);
            MessageBoxFarsiIcon farsiIcon = AssignIcons(icon);

            return MessageBoxFarsi.Show(text, caption, farsiButtons, farsiIcon);
        }
        public static DialogResult Show(string text, string caption, NFPMessageBoxButtons buttons, NFPMessageBoxIcon icon, NFPMessageBoxDefaultButton defaultButton)
        {
            MessageBoxFarsiButtons farsiButtons = AssignButtons(buttons);
            MessageBoxFarsiIcon farsiIcon = AssignIcons(icon);
            MessageBoxFarsiDefaultButton farsiDefaultButton = AssignDefaultButton(defaultButton);

            return MessageBoxFarsi.Show(text, caption, farsiButtons, farsiIcon, farsiDefaultButton);
        }
        public static DialogResult Show(string text, string caption, NFPMessageBoxButtons buttons, NFPMessageBoxIcon icon, NFPMessageBoxDefaultButton defaultButton, NFPMessageBoxOptions rightToLeftMessage)
        {
            MessageBoxFarsiButtons farsiButtons = AssignButtons(buttons);
            MessageBoxFarsiIcon farsiIcon = AssignIcons(icon);
            MessageBoxFarsiDefaultButton farsiDefaultButton = AssignDefaultButton(defaultButton);
            bool messageAlign = AssignMessageAlign(rightToLeftMessage);

            return MessageBoxFarsi.Show(text, caption, farsiButtons, farsiIcon, farsiDefaultButton, messageAlign);
        }
        public static DialogResult Show(string text, string caption, NFPMessageBoxButtons buttons, NFPMessageBoxIcon icon, NFPMessageBoxDefaultButton defaultButton, NFPMessageBoxOptions rightToLeftMessage, NFPMessageBoxOptions rightToLeftLayout)
        {
            MessageBoxFarsiButtons farsiButtons = AssignButtons(buttons);
            MessageBoxFarsiIcon farsiIcon = AssignIcons(icon);
            MessageBoxFarsiDefaultButton farsiDefaultButton = AssignDefaultButton(defaultButton);
            bool messageAlign = AssignMessageAlign(rightToLeftMessage);
            bool layoutAlign = AssignMessageAlign(rightToLeftLayout);

            return MessageBoxFarsi.Show(text, caption, farsiButtons, farsiIcon, farsiDefaultButton, messageAlign, layoutAlign);
        }

        private static bool AssignMessageAlign(NFPMessageBoxOptions align)
        {
            switch (align)
            {
                case NFPMessageBoxOptions.LtrReading:
                    return false;
                case NFPMessageBoxOptions.RtlReading:
                    return true;
            }
            return true;
        }
        private static MessageBoxFarsiDefaultButton AssignDefaultButton(NFPMessageBoxDefaultButton defaultb)
        {
            switch (defaultb)
            {
                case NFPMessageBoxDefaultButton.Button1:
                    return MessageBoxFarsiDefaultButton.Button1;
                case NFPMessageBoxDefaultButton.Button2:
                    return MessageBoxFarsiDefaultButton.Button2;
                case NFPMessageBoxDefaultButton.Button3:
                    return MessageBoxFarsiDefaultButton.Button3;
            }
            return MessageBoxFarsiDefaultButton.Button1;
        }
        private static MessageBoxFarsiIcon AssignIcons(NFPMessageBoxIcon icons)
        {
            switch (icons)
            {
                case NFPMessageBoxIcon.Delete:
                    return MessageBoxFarsiIcon.Delete;
                case NFPMessageBoxIcon.Error:
                    return MessageBoxFarsiIcon.Error;
                case NFPMessageBoxIcon.Help:
                    return MessageBoxFarsiIcon.Help;
                case NFPMessageBoxIcon.Information:
                    return MessageBoxFarsiIcon.Information;
                case NFPMessageBoxIcon.None:
                    return MessageBoxFarsiIcon.None;
                case NFPMessageBoxIcon.Preference:
                    return MessageBoxFarsiIcon.Preference;
                case NFPMessageBoxIcon.Question:
                    return MessageBoxFarsiIcon.Question;
                case NFPMessageBoxIcon.Stop:
                    return MessageBoxFarsiIcon.Stop;
                case NFPMessageBoxIcon.Warning:
                    return MessageBoxFarsiIcon.Warning;
            }
            return MessageBoxFarsiIcon.None;
        }
        private static MessageBoxFarsiButtons AssignButtons(NFPMessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case NFPMessageBoxButtons.AbortRetryIgnore:
                    return MessageBoxFarsiButtons.AbortRetryIgnore;

                case NFPMessageBoxButtons.OK:
                    return MessageBoxFarsiButtons.OK;

                case NFPMessageBoxButtons.OkCancel:
                    return MessageBoxFarsiButtons.OkCancel;

                case NFPMessageBoxButtons.RetryCancel:
                    return MessageBoxFarsiButtons.RetryCancel;

                case NFPMessageBoxButtons.YesNo:
                    return MessageBoxFarsiButtons.YesNo;

                case NFPMessageBoxButtons.YesNoCancel:
                    return MessageBoxFarsiButtons.YesNoCancel;
            }
            return MessageBoxFarsiButtons.OK;
        }
    }
}
