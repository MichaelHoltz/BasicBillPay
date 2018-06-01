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
    /// TransactionPeriod Enumeration (Trying to be clever about values.. but probably not going to work.)
    /// </summary>
    public enum TransactionPeriod
    {
        Hourly = (52 * 40), //iffy
        Daily = 365, //Very iffy
        Weekly = 52,
        Biweekly = 26,
        Monthly = 12,
        Yearly = 1
    }
}
