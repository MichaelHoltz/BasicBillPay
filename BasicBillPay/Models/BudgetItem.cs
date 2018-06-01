using System;
using System.Collections.Generic;
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
    public class BudgetItem
    {
        public String Name { get; set; }
        public TransactionPeriod PaidFrequency { get; set; }
        public float Amount { get; set; }
        public float Split1Amount { get; set; }
        public int Split1AccountId { get; set; }
        public float Split2Amount { get; set; }
        public int Split2AccountId { get; set; }
        

    }
}
