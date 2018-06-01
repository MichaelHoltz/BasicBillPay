using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    public class PayCheck
    {
        /// <summary>
        /// Id of this PayCheck Information
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Account this is tied to
        /// </summary>
        public int AccountId { get; set; }
        public String Name { get; set; }
        /// <summary>
        /// How often you are paid
        /// Direct Set
        /// </summary>
        public TransactionPeriod PayPeriod { get; set; }
        /// <summary>
        /// How much you keep when paid
        /// Direct Set
        /// (Net Pay)
        /// </summary>
        public float NetPayPerPayPeriod { get; set; }
        public float GrossPayPerPayPeriod { get; set; }
        public float TaxPerPayPeriod { get; set; }
        public float BenifitCostPerPayPeriod { get; set; }
        public float GarnishmentCostPerPayPeriod { get; set; }
        public float OtherCostPerPayPeriod { get; set; }

        #region Pay Calculations
        public float TotalDeductionsPerPayPeriod()
        {
            return TaxPerPayPeriod + BenifitCostPerPayPeriod + GarnishmentCostPerPayPeriod + OtherCostPerPayPeriod;
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
