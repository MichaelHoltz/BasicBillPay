using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicBillPay.Models
{
    /// <summary>
    /// Class to group Income and Expenses
    /// </summary>
    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        /// <summary>
        /// Account Ids associated with this person
        /// </summary>
        public HashSet<int> AccountIds { get; set; }
        /// <summary>
        /// Paycheck Ids associated with this person
        /// </summary>
        public HashSet<int> PaycheckIds { get; set; }

        public Person()
        {
            AccountIds = new HashSet<int>();
            PaycheckIds = new HashSet<int>();
        }
        public Person(String name, int id)
        {
            Name = name;
            Id = id;
            AccountIds = new HashSet<int>();
            PaycheckIds = new HashSet<int>();

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
            String key = this.GetType().Name + Id + Name;
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
