using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicBillPay.Models;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    /// <summary>
    /// Estimated Recurring bill with no exact due date or amount
    /// 
    /// Ex. Family Food, Family Clothing, Medical 
    /// Also Yearly 
    /// </summary>
    public class BudgetItem:PeriodicBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id = 0;
        public int Id
        {
            get { return id; }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int index = 0;
        public int Index
        {
            get { return index; }
            set
            {
                if (value != index)
                {
                    index = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private String name;
        public String Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float amount = 0f;
        public float Amount
        {
            get { return amount; }
            set
            {
                if (value != amount)
                {
                    amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float split1Amount = 0f;
        public float Split1Amount
        {
            get { return split1Amount; }
            set
            {
                if (value != split1Amount)
                {
                    split1Amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int split1AccountId = 0;
        public int Split1AccountId
        {
            get { return split1AccountId; }
            set
            {
                if (value != split1AccountId)
                {
                    split1AccountId = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float split2Amount = 0f;
        public float Split2Amount
        {
            get { return split2Amount; }
            set
            {
                if (value != split2Amount)
                {
                    split2Amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int split2AccountId = 0;
        public int Split2AccountId
        {
            get { return split2AccountId; }
            set
            {
                if (value != split2AccountId)
                {
                    split2AccountId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public BudgetItem()
        {
        }
        public BudgetItem(int id, String name, float amount, TransactionPeriod paidFrequency):base(paidFrequency)
        {
            Id = id;
            Name = name;
            Amount = amount;
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
            //Console.WriteLine(Name + " - " + Id + ": " + _hashCode);
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
