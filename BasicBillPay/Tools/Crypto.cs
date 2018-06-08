using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Management; //Requires reference to System.Management for ManagementClass
using System.Threading.Tasks;

namespace BasicBillPay.Tools.Encryption
{
    /// <summary>
    /// Just for making it simpler for using a master password.
    /// For best security the Password should not be saved and should be at strong password entered every time.
    /// 
    /// </summary>
    public static class CryptoPassword
    {
        /// <summary>
        /// Similar but different Example
        /// </summary>
        private static void CodeHolder()
        {
            string password = "This is a password";
            string cipher = AESGCM.SimpleEncryptWithPassword("This is a test", password);
            MessageBox.Show(cipher);
            string plainText = AESGCM.SimpleDecryptWithPassword(cipher, password);
            MessageBox.Show(plainText);
        }

        private const int SINDEX = 25;
        private static byte[] Entropy { get; set; }
        private static byte[] Cypher { get; set; }
        public static byte[] EPassword { get; set; }
        public static String Encrypt(string plainText)
        {
            if (String.IsNullOrEmpty(plainText))
                return plainText;
            ///Example of "https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainText);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[SINDEX];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            byte[] ciphertext = ProtectedData.Protect(plaintextBytes, entropy, DataProtectionScope.CurrentUser);
            //Save for decrypt
            Entropy = entropy;
            //SINDEX = Entropy.Length;
            Cypher = ciphertext;
            EPassword = new byte[SINDEX + Cypher.Length];
            System.Buffer.BlockCopy(Entropy, 0, EPassword, 0, SINDEX);
            System.Buffer.BlockCopy(Cypher, 0, EPassword, SINDEX, Cypher.Length);
            SplitFields();
            
            return Convert.ToBase64String(EPassword);
        }
        public static String Decrypt()
        {
            String pt = null;
            if ( EPassword != null)
            {
                SplitFields();  //Get Cypher and Entropy
                ///Example of "https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"
                ///Below will error out if tried from anywhere and anyone other than the original user.
                byte[] plaintext = ProtectedData.Unprotect(Cypher, Entropy, DataProtectionScope.CurrentUser);
                //Convert.ToBase64String(cipherText);
                pt = Encoding.UTF8.GetString(plaintext);
            }
            return pt;
        }
        /// <summary>
        /// Used to Split one Encrypted Field into its parts.
        /// </summary>
        private static void SplitFields()
        {
            int j = 0;
            int i = 0;
            Entropy = new byte[SINDEX];
            Cypher = new byte[EPassword.Length - SINDEX];
            for (i = 0; i < SINDEX; i++)
            {
                Entropy[i] = EPassword[i];

            }
            j = i;
            i = 0;
            for (; j < EPassword.Length; j++)
            {
                Cypher[i++] = EPassword[j];
            }
        }
        /// <summary>
        /// Used as a way of generating an auto password that is unique to each machine..
        /// Problem if user replaces network card..  or want's to use on a different machine if used otherwise.
        /// </summary>
        /// <returns></returns>
        internal static String GetMAC()
        {
            String firstMAC = null;
            using (var mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    if (mo["MacAddress"] != null)
                    {
                        firstMAC = mo["MacAddress"].ToString();
                        break;
                    }
                    //Console.WriteLine(mo["MacAddress"].ToString());
                }
            }
            return firstMAC;
        }

    }
}
