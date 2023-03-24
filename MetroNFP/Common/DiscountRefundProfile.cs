using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DiscountRefundProfile
    {
        public DiscountRefundProfile()
        {
            discountRefundProfileID = 0;
            discountRefundProfileName = String.Empty;
            operationKind = 0;
            discountRefunds = new List<DiscountRefund>();
        }

        public DiscountRefundProfile(short ldiscountRefundProfileID, string ldiscountRefundProfileName, byte loperationKind, List<DiscountRefund> ldiscountRefunds)
        {
            discountRefundProfileID = ldiscountRefundProfileID;
            discountRefundProfileName = ldiscountRefundProfileName;
            operationKind = loperationKind;
            discountRefunds = ldiscountRefunds;
        }

        private short discountRefundProfileID;
        public short DiscountRefundProfileID
        {
            get
            {
                return discountRefundProfileID;
            }
            set
            {
                discountRefundProfileID = value;
            }
        }

        private string discountRefundProfileName;
        public string DiscountRefundProfileName
        {
            get
            {
                return discountRefundProfileName;
            }
            set
            {
                discountRefundProfileName = value;
            }
        }

        private byte operationKind;
        public byte OperationKind
        {
            get
            {
                return operationKind;
            }
            set
            {
                operationKind = value;
            }
        }

        private List<DiscountRefund> discountRefunds;
        public List<DiscountRefund> DiscountRefunds
        {
            get
            {
                return discountRefunds;
            }
            set
            {
                discountRefunds = value;
            }
        }
    }
}
