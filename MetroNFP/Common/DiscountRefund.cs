using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DiscountRefund
    {
        public DiscountRefund()
        {
            discountRefundID = 0;
            startCost = 0;
            finishCost = 0;
            percent = 0;
        }

        public DiscountRefund(int ldiscountRefundID, double lstartCost, double lfinishCost, Int16 lpercent)
        {
            discountRefundID = ldiscountRefundID;
            startCost = lstartCost;
            finishCost = lfinishCost;
            percent = lpercent;
        }

        private int discountRefundID;
        public int DiscountRefundID
        {
            get
            {
                return discountRefundID;
            }
            set
            {
                discountRefundID = value;
            }
        }

        private double startCost;
        public double StartCost
        {
            get
            {
                return startCost;
            }
            set
            {
                startCost = value;
            }
        }

        private double finishCost;
        public double FinishCost
        {
            get
            {
                return finishCost;
            }
            set
            {
                finishCost = value;
            }
        }

        private Int16 percent;
        public Int16 Percent
        {
            get
            {
                return percent;
            }
            set
            {
                percent = value;
            }
        }
    }
}
