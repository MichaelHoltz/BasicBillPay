using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    /// <summary>
    /// Account - Rent, Car Payment, Utility, etc.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account Id for normalization
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Account Name
        /// 
        /// Spreadsheet Source = What
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        public String Number { get; set; }
        /// <summary>
        /// Where to Access Account
        /// 
        /// Spreadsheet Source = Where
        /// </summary>
        public String Link { get; set; }
        /// <summary>
        /// UserName for Account - Will be encrypted (if not all fields)
        /// </summary>
        public String UserName { get; set; }
        /// <summary>
        /// Calculated based on Date...
        /// </summary>
        public float Balance { get; set; }

        public Account()
        {

        }
        public Account(int accountId, String name, String number, String link, String userName)
        {
            Id = accountId;
            Name = name;
            Number = number;
            Link = link;
            UserName = userName;
        }
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
            String key = this.GetType().Name + Name + Number;
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
