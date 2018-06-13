using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBillPay.Models
{
    /// <summary>
    /// Base Class for Periodic Transactions
    /// </summary>
    public class PeriodicBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
            private TransactionPeriod payPeriod = TransactionPeriod.Monthly;
        /// <summary>
        /// How often you are paid
        /// Direct Set
        /// </summary>
        public TransactionPeriod PayPeriod
        {
            get { return payPeriod; }
            set
            {
                if (value != payPeriod)
                {
                    payPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        } 
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
