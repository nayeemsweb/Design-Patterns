using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// LowDiscountStrategy provides 10% discount. 
    /// </summary>
    public class LowDiscountStrategy : IStrategy
    {
        public double GetFinalBill(double BillAmount)
        {
            var ammountAfterDiscount = BillAmount - (BillAmount * 0.1);
            return (double)ammountAfterDiscount;
        }
    }
}
