using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BasicBillPay.Tools.Encryption;
namespace BasicBillPay.Models
{
    public class Paycheck:PeriodicBase, EncryptedModel
    {
        /// <summary>
        /// Id of this PayCheck Information
        /// </summary>
        public int Id { get; set; }
        private String name { get; set; }
        ///// <summary>
        ///// Account this is tied to - Umm Actually Should be the Person... Leaving for now.. But it's confusing. :(and I created it.)
        ///// </summary>
        //public int AccountId { get; set; }
        /// <summary>
        /// Name of the PayCheck  (Typically Company worked for, or person giving the money, etc.)
        /// </summary>
        public String Name {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float netPayPerPayPeriod = 0f;
        /// How much you keep when paid
        /// Direct Set (Can be calculated if all other values are set correctly) - But people can see the amount they just received..
        /// (Net Pay)
        /// The Minimum Required Value for use.. All the Others are just Extra.
        /// 
        /// </summary>
        public float NetPayPerPayPeriod
        {
            get
            {
                return netPayPerPayPeriod;
            }
            set
            {
                if (value != netPayPerPayPeriod)
                {
                    netPayPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float grossPayPerPayPeriod = 0f;
        public float GrossPayPerPayPeriod {
            get
            {
                return grossPayPerPayPeriod;
            }
            set
            {
                if (value != grossPayPerPayPeriod)
                {
                    grossPayPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float taxPerPayPeriod = 0f;
        public float TaxPerPayPeriod {
            get
            {
                return taxPerPayPeriod;
            }
            set
            {
                if (value != taxPerPayPeriod)
                {
                    taxPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
         }
        private float benefitCostPerPayPeriod = 0f;
        public float BenefitCostPerPayPeriod {
            get
            {
                return benefitCostPerPayPeriod;
            }
            set
            {
                if (value != benefitCostPerPayPeriod)
                {
                    benefitCostPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float garnishmentCostPerPayPeriod = 0f;
        public float GarnishmentCostPerPayPeriod
        {
            get
            {
                return garnishmentCostPerPayPeriod;
            }
            set
            {
                if (value != garnishmentCostPerPayPeriod)
                {
                    garnishmentCostPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float otherCostPerPayPeriod = 0f;
        public float OtherCostPerPayPeriod
        {
            get
            {
                return otherCostPerPayPeriod;
            }
            set
            {
                if (value != otherCostPerPayPeriod)
                {
                    otherCostPerPayPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private DateTime payDayStart = DateTime.Now;
        /// <summary>
        /// Start Date to Establish proper frequency
        /// </summary>
        public DateTime PayDayStart
        {
            get
            {
                return payDayStart;
            }
            set
            {
                if (value != payDayStart)
                {
                    payDayStart = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Paycheck()
        {
        }
        public Paycheck(int id, String name, TransactionPeriod payFrequency) : base(payFrequency)
        {
            Id = id;
            Name = name;
            PayDayStart = DateTime.Now; // Default to something close.
        }
        public void Encrypt()
        {
            //Hmm probably need to store floats as byte array so they can be encrypted and decrypted .. Another day because all would need to change.
            byte[] byteArray = BitConverter.GetBytes(NetPayPerPayPeriod);

            
            //NetPayPerPayPeriod = AESGCM.SimpleEncryptWithPassword(NetPayPerPayPeriod.ToString());
        }

        public void Decrypt()
        {
            float myFloat = System.BitConverter.ToSingle(BitConverter.GetBytes(NetPayPerPayPeriod), 0);
            //throw new NotImplementedException();
        }
        #region Pay Calculations
        public float TotalDeductionsPerPayPeriod()
        {
            return TaxPerPayPeriod + BenefitCostPerPayPeriod + GarnishmentCostPerPayPeriod + OtherCostPerPayPeriod;
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
            String key = this.GetType().Name + Id + Name; //If Id included then duplicate names are created.
            //Google: "disable fips mode" if the line below fails
            System.Security.Cryptography.MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(key));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            _hashCode = ivalue;
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
