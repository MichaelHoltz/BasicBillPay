﻿using System;
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

        #region Overrides
        /// <summary>
        /// Returns this instance ToString
        /// </summary>
        public override string ToString()
        {
            return Name;
        }
        #endregion
        #region HashCodes / Object Identification
        //TODO - use / include the "correct" id..
        private int _hashCode = 0;
        [JsonIgnore]
        [JsonProperty("H")]
        public int HashCode
        {
            get
            {
                return _hashCode == 0 ? generateHashCode() : _hashCode;
            }
            //Need set for persistence to restore 
            set
            {
                _hashCode = value;
            }
        }
        private int generateHashCode()
        {
            //THis is expensive and should be done only once since it will not be changing
            //TODO - use / include the "correct" id..
            String key = this.GetType().Name + Name + AccountId;
            //Google: "disable fips mode" if the line below fails
            System.Security.Cryptography.MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(key));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            return ivalue;

        }
        public override int GetHashCode()
        {
            return HashCode;
        }
        public override bool Equals(object obj)
        {
            return obj.GetHashCode().Equals(HashCode); // == this.GetHashCode();
        }
        #endregion
    }
}
