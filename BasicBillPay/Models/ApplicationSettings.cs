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
    public class ApplicationSettings:EncryptedModel
    {
        public ApplicationSettings()
        {
        }
        public void Encrypt()
        {
            if (EncryptionLevel == EncryptionLevel.Full)
            {
                AESGCM.Password = Password;
                Password = null; //Clear Password so it's not saved.
            }
            else
            {
                Password = CryptoPassword.Encrypt(Password); //Save Encrypted
            }
            
            DbPath = AESGCM.SimpleEncryptWithPassword(DbPath);
            Verification = AESGCM.SimpleEncryptWithPassword(Verification);
        }
        public void Decrypt()
        {
            if (Password != null)
            {
                if (EncryptionLevel == EncryptionLevel.Auto) // For Auto
                {
                    CryptoPassword.EPassword = Convert.FromBase64String(Password);
                    Password = CryptoPassword.Decrypt();
                }
                AESGCM.Password = Password;
            }
            else if (Password == null && AESGCM.Password != null)
            {
                Password = AESGCM.Password; // Restore Password
            }
            if (Password == null && EncryptionLevel == EncryptionLevel.Full)
            {
                //Can't Decrypt yet!!
                return;
            }
            DbPath = AESGCM.SimpleDecryptWithPassword(DbPath);
            Verification = AESGCM.SimpleDecryptWithPassword(Verification);
        }
        public EncryptionLevel EncryptionLevel {get; set;} = EncryptionLevel.None;
        /// <summary>
        /// Idea is to use for Password Verification so as not to destroy the data with an incorrect password.
        /// </summary>
        public String Verification { get; set; }

        public String Password { get; set; }

        /// <summary>
        /// Plain Text DbPath.
        /// </summary>
        public String DbPath { get; set; }

    }
}
