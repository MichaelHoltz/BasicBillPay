﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BasicBillPay.Tools.Encryption;
namespace BasicBillPay.Models
{
    /// <summary>
    /// Account - Rent, Car Payment, Utility, etc.
    /// </summary>
    public class Account:EncryptedModel
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
        /// Index for sorting (All are Zero unless sorted)
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Account Type
        /// </summary>
        public AccountType Type { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        /// 
        //public String ENumber { get; set; }
        //private String _number = null;
        public String Number { get; set; }
        //{
        //    get
        //    {
        //        if (_number == null)
        //            _number = AESGCM.SimpleDecryptWithPassword(ENumber);
        //        return _number;
        //    }
        //    set
        //    {
        //        ENumber = AESGCM.SimpleEncryptWithPassword(value);
        //        _number = value;
        //    }
        //}


        /// <summary>
        /// Where to Access Account
        /// 
        /// Spreadsheet Source = Where
        /// </summary>
       // public String ELink { get; set; }
       // private String _link = null;
        public String Link { get; set; }
        //{
        //    get
        //    {
        //        if(_link == null)
        //            _link = AESGCM.SimpleDecryptWithPassword(ELink);
        //        return _link;
        //    }
        //    set
        //    {
        //        ELink = AESGCM.SimpleEncryptWithPassword(value);
        //        _link = value;
        //    }
        //}

        /// <summary>
        /// UserName for Account - Will be encrypted (if not all fields)
        /// </summary>
        //public String EUserName { get; set; }
        //private String _userName = null;
        
        public String UserName { get; set; }
        //{
        //    get
        //    {
        //        if(_userName == null)
        //            _userName = AESGCM.SimpleDecryptWithPassword(EUserName);
        //        return _userName;
        //    }
        //    set
        //    {
        //        EUserName = AESGCM.SimpleEncryptWithPassword(value);
        //        _userName = value;
        //    }
        //}
        /// <summary>
        /// Calculated based on Date...
        /// </summary>
        public float Balance { get; set; }
        public void Encrypt()
        {

            Number = AESGCM.SimpleEncryptWithPassword(Number);
            Link = AESGCM.SimpleEncryptWithPassword(Link);
            UserName = AESGCM.SimpleEncryptWithPassword(UserName);
        }
        public void Decrypt()
        {
            Number = AESGCM.SimpleDecryptWithPassword(Number);
            Link = AESGCM.SimpleDecryptWithPassword(Link);
            UserName = AESGCM.SimpleDecryptWithPassword(UserName);

        }
        public Account()
        {

        }
        public Account(int accountId, String name, AccountType type, String number, String link, String userName)
        {
            Id = accountId;
            Name = name;
            Type = type;
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
