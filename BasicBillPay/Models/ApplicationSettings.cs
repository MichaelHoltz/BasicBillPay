using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using BasicBillPay.Tools;
using Newtonsoft.Json;
using BasicBillPay.Tools.Encryption;
using System.Security.Cryptography;
using System.IO;


namespace BasicBillPay.Models
{
    /// <summary>
    /// Application Settings (Encrypted)
    /// </summary>
    public class ApplicationSettings
    {
        public EncryptionLevel EncryptionLevel {get; set;} = EncryptionLevel.None;

        /// <summary>
        /// ONLY secure in a controlled environment with permission only for the current intended user. 
        /// </summary>
        public String EPassword
        {
            get
            {
                if (EncryptionLevel == EncryptionLevel.None)
                    return null;
                return Convert.ToBase64String(CryptoPassword.EPassword);
            } 
            set
            {
                if (EncryptionLevel != EncryptionLevel.None)
                    CryptoPassword.EPassword = Convert.FromBase64String(value); 
            }
        }

        [JsonIgnore]
        public String Password
        {
            get
            {
                return CryptoPassword.Decrypt();
            }
            set
            {
                CryptoPassword.Encrypt(value);
            }
        }


        public String EDbPath { get; set; }
        private String _dbPath = null;
        [JsonIgnore]
        public String DbPath
        {
            get
            {
                if(_dbPath == null && EncryptionLevel != EncryptionLevel.None)
                    _dbPath = AESGCM.SimpleDecryptWithPassword(EDbPath);
                return _dbPath;
            }
            set
            {
                if(EncryptionLevel != EncryptionLevel.None)
                    EDbPath = AESGCM.SimpleEncryptWithPassword(value);
                _dbPath = value;
            }
        }

    }
}
