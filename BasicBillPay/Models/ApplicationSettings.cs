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
        private String dbPath;
        public String DbPath
        {
            get
            {
                return dbPath;
            }
            set
            {
                dbPath = value;
            }
        }

        private String password;
        [JsonIgnore]
        public String Password
        {
            get
            {
                password = Decrypt();
                return password;
            }
            set
            {
                Encrypt(value);
                password = value;
            }
        }
        [JsonIgnore]
        public byte[] Entropy { get; set; }
        [JsonIgnore]
        public byte[] Cypher { get; set; }
        public int SIndex { get; set; }
        public byte[] EPassword { get; set; }
        private void CodeHolder()
        {
            string password = "This is a password";
            string cipher = AESGCM.SimpleEncryptWithPassword("This is a test", password);
            MessageBox.Show(cipher);
            string plainText = AESGCM.SimpleDecryptWithPassword(cipher, password);
            MessageBox.Show(plainText);
        }

        private void Encrypt(string plainText)
        {
            ///Example of "https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainText);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            //binaryWriter("entropy.bin", entropy);
            byte[] ciphertext = ProtectedData.Protect(plaintextBytes, entropy, DataProtectionScope.CurrentUser);
            //Save for decrypt
            Entropy = entropy;
            SIndex = Entropy.Length;
            Cypher = ciphertext;
            EPassword = new byte[SIndex + Cypher.Length];
            System.Buffer.BlockCopy(Entropy, 0, EPassword, 0, SIndex);
            System.Buffer.BlockCopy(Cypher, 0, EPassword, SIndex, Cypher.Length);
            SplitFields();
            //binaryWriter("cipher.bin", ciphertext);
        }
        private String Decrypt()
        {
            SplitFields();
            ///Example of "https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"
            //byte[] plaintext2 = ProtectedData.Unprotect(binaryReader("cipher.bin"), binaryReader("entropy.bin"), DataProtectionScope.CurrentUser);
            byte[] plaintext2 = ProtectedData.Unprotect(Cypher,Entropy, DataProtectionScope.CurrentUser);
            String pt = Encoding.UTF8.GetString(plaintext2);
            return pt;
        }
        private void SplitFields()
        {
            int j = 0;
            int i = 0;
            Entropy = new byte[SIndex];
            Cypher = new byte[EPassword.Length - SIndex];
            for (i = 0; i < SIndex; i++)
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
        private void getCipher()
        {

        }

        //private byte[] binaryReader(String fn)
        //{
        //    String fileName = PersistenceBase.GetAbsolutePath(@"\Data\" + fn );
        //    FileStream readStream;
        //    readStream = new FileStream(fileName, FileMode.Open);

        //    BinaryReader readBinary = new BinaryReader(readStream);
        //    long FileSize = readStream.Length;
        //    byte[] retVal = new byte[FileSize];

        //    for (UInt32 b = 0; b < FileSize; b++)
        //    {
        //        retVal[b] = readBinary.ReadByte();
        //    }
        //    readBinary.Close();
        //    return retVal;
        //}

        //private void binaryWriter(String fn, byte[] data)
        //{
        //    String fileName = PersistenceBase.GetAbsolutePath(@"\Data\" + fn);
        //    FileStream writeStream;
        //    writeStream = new FileStream(fileName, FileMode.OpenOrCreate);
        //    BinaryWriter writeBinary = new BinaryWriter(writeStream);
        //    writeBinary.Write(data); // Write to File from receive word array
        //    writeStream.Close();
        //}
    }
}
