using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NoDiscountStrategy : IStrategy
    {
        public double GetFinalBill(double BillAmount)
        {
            var ammountAfterDiscount = BillAmount;
            return (double)ammountAfterDiscount;
        }
    }
}
