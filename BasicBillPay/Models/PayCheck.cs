using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    public class PayCheck:PeriodicBase
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
        /// <summary>
        /// Start Date to Establish proper frequency
        /// </summary>
        public DateTime PayDayStart { get; set; }

        public PayCheck()
        {
        }
        public PayCheck(TransactionPeriod payFrequency) : base(payFrequency)
        {

        }
        #region Pay Calculations
        public float TotalDeductionsPerPayPeriod()
        {
            return TaxPerPayPeriod + BenifitCostPerPayPeriod + GarnishmentCostPerPayPeriod + OtherCostPerPayPeriod;
        }
        #endregion Pay Calculations


    }
}
