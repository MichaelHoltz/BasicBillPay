using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBillPay.Models
{
    /// <summary>
    /// Used for Splitting a Budget Item
    /// </summary>
    public class SplitItem
    {
        /// <summary>
        /// ID of this Split Item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Total amount to split
        /// </summary>
        public float Total { get; set; }


    }
}
