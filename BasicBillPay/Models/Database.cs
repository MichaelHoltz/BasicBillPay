﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BasicBillPay.Models
{
    /// <summary>
    /// All Data
    /// </summary>
    public class Database
    {
        public int NextPayCheckId { get; set; }
        public HashSet<PayCheck> PayChecks { get; set; }
        public int NextAccountId { get; set; }
        public HashSet<Account> Accounts { get; set; }
        public int NextPaymentId { get; set; }
        public HashSet<Payment> Payments { get; set; }
        public int NextBudgetItemId { get; set; }
        public HashSet<BudgetItem> BudgetItems { get; set; }

        public Database()
        {
            //Initialize HashSets so they can be added to.
            Accounts = new HashSet<Account>();
            Payments = new HashSet<Payment>();
            BudgetItems = new HashSet<BudgetItem>();
            PayChecks = new HashSet<PayCheck>();
        }

        #region Account Functions
        public Account AddAccount(String name, String number, String link, String userName)
        {
            Account account = new Account(NextAccountId++, name, number, link, userName );
            bool retVal = Accounts.Add(account); // Need to implement Hashing to prevent duplicates..
            if (!retVal) // Failed To add so get.
            {
                account = Accounts.FirstOrDefault(o => o.Id == account.Id);
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
        #endregion Account Functions

        #region Payment Functions
        public Payment AddPayment(int payToId, int payFromId, DateTime dateDue, DateTime datePaid, float paymentAmount)
        {
            Payment p = new Payment(NextPaymentId++, payToId, payFromId, dateDue, datePaid, paymentAmount);
            bool retVal = Payments.Add(p);
            if (!retVal)
            {
                p = Payments.FirstOrDefault(o => o.PayToId == payToId && o.PayFromId == payFromId);
            }
            return p;
        }
        #endregion Payment Functions
    }
}