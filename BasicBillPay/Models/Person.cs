using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicBillPay.Models
{
    /// <summary>
    /// Class to group Income and Expenses
    /// </summary>
    public class Person: INotifyPropertyChanged
    {
        #region INotify Property Changed
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
        #endregion INotify Property Changed
        public int Id { get; set; } = -1;
        private String name = String.Empty;
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
        private HashSet<int> accountIds;
        /// <summary>
        /// Account Ids associated with this person
        /// </summary>
        public HashSet<int> AccountIds
        {
            get { return accountIds; }
            set
            {
                if (value != accountIds)
                {
                    accountIds = value;
                    NotifyPropertyChanged();
                }
            }
         }
        private HashSet<int> paycheckIds;
        /// <summary>
        /// Paycheck Ids associated with this person
        /// </summary>
        public HashSet<int> PaycheckIds
        {
            get { return paycheckIds; }
            set
            {
                if (value != paycheckIds)
                {
                    paycheckIds = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private TransactionPeriod totalsTransactionPeriod = TransactionPeriod.Monthly;
        /// <summary>
        /// Transaction Period selected by/for the person
        /// </summary>
        public TransactionPeriod TotalsTransactionPeriod
        {
            get { return totalsTransactionPeriod; }
            set
            {
                if (value != totalsTransactionPeriod)
                {
                    totalsTransactionPeriod = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float incomeTotal = 0f;
        /// <summary>
        /// Budget Total for a Person
        /// NOTE Budget Items are Scalable by Transaction Period
        /// </summary>
        public float IncomeTotal
        {
            get { return incomeTotal; }
            set
            {
                if (value != incomeTotal)
                {
                    incomeTotal = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float billsTotal = 0f;
        /// <summary>
        /// Budget Total for a Person
        /// NOTE Budget Items are Scalable by Transaction Period
        /// </summary>
        public float BillsTotal
        {
            get { return billsTotal; }
            set
            {
                if (value != billsTotal)
                {
                    billsTotal = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float budgetTotal = 0f;
        /// <summary>
        /// Budget Total for a Person
        /// NOTE Budget Items are Scalable by Transaction Period
        /// </summary>
        public float BudgetTotal
        {
            get { return budgetTotal; }
            set
            {
                if (value != budgetTotal)
                {
                    budgetTotal = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private float expensesTotal = 0f;
        /// <summary>
        /// Expenses Total for a Person (Bills + Budget)
        /// NOTE Expense Items are Scalable by Transaction Period
        /// </summary>
        public float ExpensesTotal
        {
            get { return expensesTotal; }
            set
            {
                if (value != expensesTotal)
                {
                    expensesTotal = value;
                    NotifyPropertyChanged();
                }
            }
        }

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
