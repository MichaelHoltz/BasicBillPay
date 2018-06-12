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
        //private String tPass = null;
        public ApplicationSettings()
        {
        }
        public void Encrypt()
        {
            if (EncryptionLevel == EncryptionLevel.Full)
            {
                AESGCM.Password = Password;
               // tPass = Password; //Save to Temp
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
                    //Password = tPass; // Restore Temp Password
                    CryptoPassword.EPassword = Convert.FromBase64String(Password);
                    Password = CryptoPassword.Decrypt();
                }

                AESGCM.Password = Password;
            }
            else if (Password == null && AESGCM.Password != null)
            {
                Password = AESGCM.Password; // REstore Password
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
       // private String password = null;
        public String Password { get; set; }
        //{
        //    get
        //    {
        //        //if (Encrypt)
        //        //    return CryptoPassword.Decrypt();
        //        //else if (Decrypt)
        //        //{
        //        //    return password;
        //        //}
        //        //else
        //            return password;
        //    }
        //    set
        //    {
        //        //if (Encrypt)
        //        //    CryptoPassword.Encrypt(value);
        //        //else
        //            password = value;
        //    }
        //}

        private String _dbPath = null;
        /// <summary>
        /// Plain Text DbPath.
        /// </summary>
        public String DbPath { get; set; }
        //{
        //    get
        //    {
        //        //if (Encrypt)
        //        //    _dbPath = AESGCM.SimpleDecryptWithPassword(_dbPath);
        //        //else
        //            //return _dbPath;
        //        return _dbPath;
        //    }
        //    set
        //    {
        //        //if(Encrypt)
        //        //    _dbPath = AESGCM.SimpleEncryptWithPassword(value);
        //        //else
        //        //    _dbPath = value;
        //        _dbPath = value;
        //    }
        //}

    }
}
