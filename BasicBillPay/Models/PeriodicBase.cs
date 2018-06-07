using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBillPay.Models
{
    /// <summary>
    /// Base Class for Periodic Transactions
    /// </summary>
    public class PeriodicBase
    {
        /// <summary>
        /// How often you are paid
        /// Direct Set
        /// </summary>
        public TransactionPeriod PayPeriod { get; set; } = TransactionPeriod.Biweekly; // Default to Every two Weeeks
        /// <summary>
        /// 
        public PeriodicBase()
        {

        }
        public PeriodicBase(TransactionPeriod payPeriod)
        {
            PayPeriod = payPeriod;
        }
        #region Pay Calculations

        public float GetAmount(float amount, TransactionPeriod period)
        {
            float retVal = 0f;
            switch (period)
            {
                case TransactionPeriod.Hourly:
                    retVal = GetHourlyAmount(amount);
                    break;
                case TransactionPeriod.Daily:
                    retVal = GetDailyAmount(amount);
                    break;
                case TransactionPeriod.Weekly:
                    retVal = GetWeeklyAmount(amount);
                    break;
                case TransactionPeriod.Biweekly:
                    retVal = GetBiweeklyAmount(amount);
                    break;
                case TransactionPeriod.Monthly:
                    retVal = GetMonthlyAmount(amount);
                    break;
                case TransactionPeriod.Yearly:
                    retVal = GetYearlyAmount(amount);
                    break;
                default:
                    break;
            }
            return retVal;
        }

        /// <summary>
        /// Use for Yearly Gross Pay, Yearly Net Pay, Yearly Taxes, etc.
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetYearlyAmount(float amountPerPayPeriod)
        {
            return ((amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Monthly) * (int)TransactionPeriod.Monthly;
        }

        /// <summary>
        /// User for Monthly Gross Pay, Monthly Net, Taxes etc.
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetMonthlyAmount(float amountPerPayPeriod)
        {
            return (amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Monthly;

        }
        /// <summary>
        /// Use for BiWeekly amount per pay period
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetBiweeklyAmount(float amountPerPayPeriod)
        {
            return (amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Biweekly;

        }
        /// <summary>
        /// Weekly amount based on amount per pay period
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetWeeklyAmount(float amountPerPayPeriod)
        {
            return (amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Weekly;

        }
        /// <summary>
        /// Hourly is based on 40 hour week
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetHourlyAmount(float amountPerPayPeriod)
        {
            return (amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Hourly;

        }
        /// <summary>
        /// Daily.. hmmm..
        /// </summary>
        /// <param name="amountPerPayPeriod"></param>
        /// <returns></returns>
        public float GetDailyAmount(float amountPerPayPeriod)
        {
            return (amountPerPayPeriod * (int)PayPeriod) / (float)TransactionPeriod.Daily;

        }
        #endregion Pay Calculations

    }
}
