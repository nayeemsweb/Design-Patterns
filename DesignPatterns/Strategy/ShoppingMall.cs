using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// ShoppingMall is the Context here. This class will be implementing different strategy
    /// algorithms via IStrategy.
    /// </summary>
    public class ShoppingMall
    {
        private readonly IStrategy _strategy;

        public string CustomerName { get; set; }
        public double BillingAmmount { get; set; }

        /// <summary>
        /// Constructor of the ShoppingMall class where object of IStrategy is injected.
        /// </summary>
        /// <param name="strategy"></param>
        public ShoppingMall(IStrategy strategy)
        {
            _strategy = strategy;
        }

        private double? _billingAmmount;

        /// <summary>
        /// GetBillingAmmount public method returns the final ammount after discount is calculated. 
        /// </summary>
        /// <returns></returns>
        public double GetBillingAmmount() 
        {
            _billingAmmount = BillingAmmount;
            var finalAmmount = _strategy.GetFinalBill((double)_billingAmmount);
            return finalAmmount;
        }
    }
}
