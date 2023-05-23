using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// HighDiscountStrategy provides 50% discount.
    /// </summary>
    public class HighDiscountStrategy : IStrategy
    {
        public double GetFinalBill(double BillAmount)
        {
            var ammountAfterDiscount = BillAmount - (BillAmount * 0.5);
            return (double)ammountAfterDiscount;
        }
    }
}
