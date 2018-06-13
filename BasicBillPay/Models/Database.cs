using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BasicBillPay.Tools;

namespace BasicBillPay.Models
{
    /// <summary>
    /// All Data
    /// </summary>
    public class Database:EncryptedModel, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
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
        #endregion INotifyPropertyChanged
        public int NextPayCheckId { get; set; }
        public HashSet<Paycheck> PayChecks { get; set; }
        public int NextAccountId { get; set; }
        public HashSet<Account> Accounts { get; set; }
        public int NextPaymentId { get; set; }
        public HashSet<Payment> Payments { get; set; }
        public int NextBudgetItemId { get; set; }
        public HashSet<BudgetItem> BudgetItems { get; set; }
        public int NextPersonId { get; set; }
        /// <summary>
        /// People relevant to this system.
        /// </summary>
        public HashSet<Person> People { get; set; }
        #region EncryptedModel for all models that are EncryptedModel
        public void Encrypt()
        {
            foreach (Account a in Accounts)
            {
                a.Encrypt();
            }
            foreach (Paycheck p in PayChecks)
            {
                p.Encrypt();
            }

        }

        public void Decrypt()
        {
            foreach (Account a in Accounts)
            {
                a.Decrypt();
            }
            foreach (Paycheck p in PayChecks)
            {
                p.Decrypt();
            }

        }
        #endregion EncryptedModel
        public Database()
        {
            //Initialize HashSets so they can be added to.
            Accounts = new HashSet<Account>();
            Payments = new HashSet<Payment>();
            BudgetItems = new HashSet<BudgetItem>();
            PayChecks = new HashSet<Paycheck>();
            People = new HashSet<Person>();
        }

        #region Account Functions
        public Account AddAccount(String name, AccountType type, String number, String link, String userName)
        {
            Account account = new Account(NextAccountId++, name, type, number, link, userName );
            bool retVal = Accounts.Add(account); // Need to implement Hashing to prevent duplicates..
            if (!retVal) // Failed To add so get.
            {
                NextAccountId--; // Remove to not have gaps
                account = Accounts.FirstOrDefault(o => o.Name == account.Name);
            }
            return account;
        }
        /// <summary>
        /// Get Full Account information from ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account GetAccount(int id)
        {
            return Accounts.FirstOrDefault(o => o.Id == id);
        }
        public Account GetAccount(String name)
        {
            return Accounts.FirstOrDefault(o => o.Name == name);
        }
        public List<Account> GetAccounts(AccountType type)
        {
            return Accounts.Where(o => o.Type == type).ToList();
        }
        /// <summary>
        /// Get Managed or Unmanaged Accounts
        /// </summary>
        /// <param name="p">if not null then all accounts managed by this person</param>
        /// <returns></returns>
        public List<Account> GetManagedIncomeAccounts(Person p)
        {
            List<Account> retVal = new List<Account>();
           // Dictionary<Account, String> managed = new Dictionary<Account, String>();
            //Sort out who manages what accounts
            //For Each Account
            foreach (Account a in GetAccounts(AccountType.Income))
            {
                //For Each Person
                foreach (Person checkPerson in People)
                {
                    
                    if (checkPerson.AccountIds.Contains(a.Id) && checkPerson.Name == p.Name)
                    {
                        //Save the relationship
                        //managed.Add(a, checkPerson.Name);
                        retVal.Add(a);
                    }
                }
            }
            //foreach (KeyValuePair<Account, String> item in managed)
            //{
            //    if (item.Value == p.Name )
            //    {
            //        retVal.Add(item.Key);
            //    }
            //}
            return retVal;
        }
        public List<Account> GetUnmanagedIncomeAccounts()
        {
            List<Account> unManaged = new List<Account>();

            //Sort out who manages what accounts
            //For Each Account
            foreach (Account a in GetAccounts(AccountType.Income))
            {
                unManaged.Add(a);
                //For Each Person
                foreach (Person checkPerson in People)
                {
                    if (checkPerson.AccountIds.Contains(a.Id))
                    {
                        unManaged.Remove(a);
                    }
                }
            }
            return unManaged;
        }

        /// <summary>
        /// Get Account Total for Account by ID Translated to Transaction Period
        /// </summary>
        /// <param name="id"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public float GetAccountTotal(int id, TransactionPeriod period)
        {
            Account a = GetAccount(id);
            float total = 0f;
            
            foreach (Payment p in Payments.Where(o => o.PayFromId == a.Id))
            {
                total += p.GetAmount(p.PaymentAmount, period);
            }
            return total;
        }

        public List<Account> GetExpenseAccountsForIncomeAccount(String name)
        {
            List<Account> retVal = new List<Account>();
            Account a = GetAccount(name);
            foreach (Payment p in Payments)
            {
                if (p.PayFromId == a.Id)
                {
                    retVal.Add(GetAccount(p.PayToId));
                }
            }
            return retVal;

        }
        #endregion Account Functions
        #region Payment Functions
        public Payment AddPayment(int payToId, int payFromId, DateTime dateDue, DateTime datePaid, float paymentAmount, TransactionPeriod paymentFrequency)
        {
            Payment p = new Payment(NextPaymentId++, payToId, payFromId, dateDue, datePaid, paymentAmount, paymentFrequency);
            bool retVal = Payments.Add(p);
            if (!retVal)
            {
                p = Payments.FirstOrDefault(o => o.PayToId == payToId && o.PayFromId == payFromId);
            }
            return p;
        }

        #endregion Payment Functions
        #region Budget Item Functions
        /// <summary>
        /// Add Basic non-split Budget Item..
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="paidFrequency"></param>
        /// <returns></returns>
        public BudgetItem AddBudgetItem(String name, float amount, TransactionPeriod paidFrequency)
        {
            //Need first two People
            Person[] p = People.ToArray();
            
            Person p0 = p[0]; //First Person
            Person p1 = new Person();
            if (p.Length > 0) //Second Person if they exist.
                p1 = p[1];
            

            BudgetItem b = new BudgetItem(NextBudgetItemId++, name, amount, paidFrequency, p0.Id, p1.Id);
            bool retVal = BudgetItems.Add(b);
            if (!retVal)
            {
                b = BudgetItems.FirstOrDefault(o => o.Id == b.Id); // Payments.FirstOrDefault(o => o.PayToId == payToId && o.PayFromId == payFromId);
            }
            return b;

        }
        public TransactionPeriod BudgetTotalTransactionPeriod { get; set; } = TransactionPeriod.Monthly; // Default to Monthly
        private float budgetTotal = 0f;
        /// <summary>
        /// Calculated and Stored Budget Total
        /// </summary>
        public float BudgetTotal
        {
            get
            {
                //float budgetTotal = 0f;
                //foreach (BudgetItem bitem in BudgetItems)
                //{
                //    budgetTotal += bitem.Amount;
                //}
                return budgetTotal;
            }
            set
            {
                if (value != budgetTotal)
                {
                    budgetTotal = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public float GetBudgetTotal(Person person)
        {
            float budgetTotal = 0f;
            foreach (BudgetItem bItem in BudgetItems.Where(o=>o.Split1AccountId == person.Id))
            {
                budgetTotal += bItem.GetAmount(bItem.Split1Amount, person.TotalsTransactionPeriod);
            }
            foreach (BudgetItem bItem in BudgetItems.Where(o => o.Split2AccountId == person.Id))
            {
                budgetTotal += bItem.GetAmount(bItem.Split2Amount, person.TotalsTransactionPeriod);
            }
            person.BudgetTotal = budgetTotal;
            return budgetTotal;
        }
        #endregion Budget Item Functions
        #region People Functions
        public Person GetPerson(String name)
        {
            return People.FirstOrDefault(o => o.Name == name);
        }
        public Person GetPerson(int id)
        {
            return People.FirstOrDefault(o => o.Id == id);
        }

        public Person AddPerson(String name)
        {
            //Add the Person
            Person person = new Person(name, NextPersonId++);
            People.Add(person);

            //Add Default Income Tracking Account
            String accountName = Conversion.Pluralize(person.Name) + " Income Account"; // Cash or Checking
            //Add account to Database
            Account a = AddAccount(accountName, AccountType.Income, null, null, null);
            //Associate the Account with this person
            person.AccountIds.Add(a.Id);


            //Add Default Pay Source Account
            String payCheckName = Conversion.Pluralize(person.Name) + " Paycheck";
            //Add Paycheck to database
            Paycheck pc = AddPayCheck(payCheckName, TransactionPeriod.Biweekly); // Need to Ask
            //Associate the paycheck with this person
            person.PaycheckIds.Add(pc.Id);
            return person;

        }
        public float GetTotalBills(Person person)
        {
            float totalBills = 0f;
            foreach (int item in person.AccountIds)
            {
                //TODO - Make sure they are Expense Accounts.
                totalBills += GetAccountTotal(GetAccount(item).Id, person.TotalsTransactionPeriod);
            }
            person.BillsTotal = totalBills; //Update The Total Bills
            return totalBills;
        }
        public HashSet<Person> GetPeople()
        {
            return People;
        }
        public List<Person> GetPeople(bool addBlankPerson, Person personToExclude = null)
        {
            List<Person> retVal = new List<Person>();
            if (addBlankPerson)
            {
                Person p = new Person();
                retVal.Add(p);
            }
            if (personToExclude == null)
            {
                retVal.AddRange(People);
            }
            else
            {
                retVal.AddRange(People.Where(o => o.Id != personToExclude.Id));
            }
            return retVal;
        }

        #endregion People Functions
        #region Paycheck Functions
        public Paycheck AddPayCheck(String name, TransactionPeriod payFrequency)
        {
            Paycheck pc = new Paycheck(NextPayCheckId++, name, payFrequency);
            bool retVal = PayChecks.Add(pc);
            if (!retVal)
            {
                NextPayCheckId--; // Remove one
                pc = PayChecks.FirstOrDefault(o => o.Name == pc.Name);
            }
            return pc;
        }

        public HashSet<Paycheck> GetPayChecks()
        {
            return PayChecks;
        }

        public float GetTotalIncome(Person person)
        {
            float total = 0f;
            //Add up Paycheck Amounts
            foreach (Paycheck pc in PayChecks)
            {
                if (person.PaycheckIds.Contains(pc.Id)) // One of person's Paychecks
                {
                    total += pc.GetAmount(pc.NetPayPerPayPeriod, person.TotalsTransactionPeriod); // Get Scaled amount
                }

            }
            //Add up Transfers (Not sure if this is going to stay as is)
            foreach (Payment pItem in Payments.OrderBy(o => o.DateDue))
            {
                //Transfers from one person's account to another.
                if (person.AccountIds.Contains(pItem.PayToId))
                {
                    total += pItem.GetAmount(pItem.PaymentAmount, person.TotalsTransactionPeriod); //Can't create this by app at this time see TODO
                }
            }
            person.IncomeTotal = total; // Set Person IncomeTotal
            return total;
        }

        public List<Paycheck> GetManagedPayChecks(Person p)
        {
            List<Paycheck> retVal = new List<Paycheck>();
            //Dictionary<PayCheck, String> managed = new Dictionary<PayCheck, String>();
            //Sort out who manages what accounts
            //For Each Account
            foreach (Paycheck pc in GetPayChecks())
            {
                //For Each Person
                foreach (Person checkPerson in People)
                {

                    if (checkPerson.PaycheckIds.Contains(pc.Id) && checkPerson.Name == p.Name)
                    {
                        //Save the relationship
                        retVal.Add(pc);
                        //managed.Add(pc, checkPerson.Name); 
                    }
                }
            }
            //foreach (KeyValuePair<PayCheck, String> item in managed)
            //{
            //    if (item.Value == p.Name)
            //    {
            //        retVal.Add(item.Key);
            //    }
            //}
            return retVal;
        }
        public List<Paycheck> GetUnmanagedPayChecks()
        {
            List<Paycheck> unManaged = new List<Paycheck>();
            //Sort out who manages what accounts
            //For Each Account
            foreach (Paycheck pc in GetPayChecks())
            {
                unManaged.Add(pc);
                //For Each Person
                foreach (Person checkPerson in People)
                {
                    if (checkPerson.PaycheckIds.Contains(pc.Id))
                    {
                        unManaged.Remove(pc);
                    }
                }
            }
            return unManaged;
        }


        #endregion
    }
}
