using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// This IStrategy interface will help to implement all the possible strategy (in our case - Discount) algorithms.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Gets the Final Bill.
        /// </summary>
        /// <param name="BillAmount"></param>
        /// <returns></returns>
        public double GetFinalBill(double BillAmount);
    }
}
