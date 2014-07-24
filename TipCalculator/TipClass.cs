using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class TipClass
    {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }

        public TipClass()
        {
            this.BillAmount = String.Empty;
            this.TipAmount = String.Empty;
            this.TotalAmount = String.Empty;
        }

        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            double dBillAmount = 0.0;
            double dTipAmount = 0.0;
            double dTotalAmount = 0.0;

            if (double.TryParse(originalAmount.Replace('€', ' '), out dBillAmount))
            {
                dTipAmount = dBillAmount*tipPercentage;
                dTotalAmount = dBillAmount + dTipAmount;
            }

            this.BillAmount = String.Format("{0:C}", dBillAmount);
            this.TipAmount = String.Format("{0:C}", dTipAmount);
            this.TotalAmount = String.Format("{0:C}", dTotalAmount);
        }
    }
}
