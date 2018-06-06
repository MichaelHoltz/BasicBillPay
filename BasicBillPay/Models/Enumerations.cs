using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBillPay.Models
{
    public static class Enumerations
    {

    }
    /// <summary>
    /// TransactionPeriod Enumeration (Trying to be clever about values..)
    /// </summary>
    public enum TransactionPeriod
    {
        Hourly = (52 * 40), //Works based on 40 hour work week.. (If Hours are to be different this will have to change)
        Daily = 365, //Very iffy - 
        Weekly = 52,
        Biweekly = 26,
        Monthly = 12,
        Yearly = 1,
    }
    public enum AccountType
    {
        Income=0,
        Expense=1,
        Credit =2 
    }
}
