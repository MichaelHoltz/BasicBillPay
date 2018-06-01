using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Payment
    {
        public int Id { get; set; }
        /// <summary>
        /// Where to pay 
        /// </summary>
        public int PayToId { get; set; }
        public int PayFromId { get; set; }
        [JsonIgnore]
        public Account PayTo
        {
            get
            {
                if (databaseFunctions != null)
                {
                    return databaseFunctions.GetAccount(PayToId);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                PayToId = value.Id;
            }
        }
        [JsonIgnore]
        public Account PayFrom
        {
            get
            {
                if (databaseFunctions != null)
                {
                    return databaseFunctions.GetAccount(PayFromId);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                PayFromId = value.Id;
            }
        }

        public DateTime DateDue { get; set; } // Normalization Violation

        public DateTime DatePaid { get; set; }
        public float PaymentAmount { get; set; }

        /// <summary>
        /// Payment Authorization / Reference / Transaction Number
        /// </summary>
        public String Reference { get; set; }

        private Database databaseFunctions = null;
        public Payment()
        {
        }
        public Payment(int id, int payToId, int payFromId, DateTime dateDue, DateTime datePaid, float paymentAmount, ref Database db)
        {
            Id = id;
            PayToId = payToId;
            PayFromId = payFromId;
            DateDue = dateDue;
            DatePaid = datePaid;
            PaymentAmount = paymentAmount;
            databaseFunctions = db;
        }

        #region Overrides
        /// <summary>
        /// Returns this instance ToString
        /// </summary>
        public override string ToString()
        {
            if (PayTo != null)
            {
                return PayTo.Name;
            }
            else
                return "PayTo is Null!!";
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
            String key = this.GetType().Name + this.ToString();
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
