using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BasicBillPay.Tools.Encryption;
namespace BasicBillPay.Models
{
    internal interface EncryptedModel
    {
        void Encrypt();
        void Decrypt();
    }
}
