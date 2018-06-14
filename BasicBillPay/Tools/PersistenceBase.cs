using System;
using System.IO;
using BasicBillPay.Models;
using BasicBillPay.Controls;
using BasicBillPay.Tools.Encryption;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BasicBillPay.Tools
{
    /// <summary>
    /// Generic Class for Persisting Any Serializable Objects
    /// </summary>
    internal static class PersistenceBase
    {
        /// <summary>
        /// Loads JSON object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CurrentFile"></param>
        /// <param name="DefaultFile">Backup File</param>
        /// <returns></returns>
        internal static T Load<T>(string CurrentFile, String DefaultFile = null) where T : new()
        {
            bool Decrypt = true;
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.CheckAdditionalContent = true;
            jss.TypeNameHandling = TypeNameHandling.Auto;
            T retval;
            //Load Settings from Specified File if it exists.
            if (File.Exists(CurrentFile))
            {
                String json = File.ReadAllText(CurrentFile);
                retval = JsonConvert.DeserializeObject<T>(json, jss);
            }
            else if (File.Exists(DefaultFile)) //Load Settings from Default File
            {
                String json = File.ReadAllText(DefaultFile);
                retval = JsonConvert.DeserializeObject<T>(json, jss);
            }
            else
            {
                //Have a problem and returning a Null object..
                //retVal =(T)(object)null;

                //Have a problem and returning a New Object
                retval = new T();
                Decrypt = false;
            }
            //Auto Decrypt // But Can't if the password isn't stored..
            if (Decrypt && retval is EncryptedModel)
            {
                (retval as EncryptedModel).Decrypt();
            }
            return retval;
        }

        internal static void Save(String CurrentFile, object obj)
        {
            //Auto Encrypt // Removes the password
            if (obj is EncryptedModel)
            {
                (obj as EncryptedModel).Encrypt();
            }
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.CheckAdditionalContent = true;
            jss.TypeNameHandling = TypeNameHandling.Auto;
            String json = JsonConvert.SerializeObject(obj, obj.GetType(), Formatting.Indented, jss);

            if (Directory.Exists(Path.GetDirectoryName(CurrentFile)))
            {

                File.WriteAllText(CurrentFile, json);
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(CurrentFile));
                File.WriteAllText(CurrentFile, json);
            }
            //Auto Decrypt //Can't decrypt
            if (obj is EncryptedModel)
            {
                (obj as EncryptedModel).Decrypt();
            }

        }
        internal static Type GetMyObjectClassType()
        {
            return typeof(PersistenceBase);
        }
        internal static string GetAppPath()
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
            return path;
        }
        /// <summary>
        /// Gets an Absolute Path given a desired relative Path
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        internal static string GetAbsolutePath(String filePath)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + filePath;
            return path;
        }

        internal static ApplicationSettings GetApplicationSettings(Control controlToCenterPopupOn)
        {
            String verification = "$impl3Ver!ficationP#rase"; // Just a known String to compare against to see if encryption passed.
            //This is a hard Coded Location on purpose..
            ApplicationSettings appSettings = Load<ApplicationSettings>(GetAbsolutePath(@"\Data\ApplicationSettings.bbp"));
            if (appSettings.Verification == null && appSettings.DbPath == null) // Checking to see if the appSettings are new or not.
            {
                appSettings.Verification = verification;
            }
            bool needPassword = true;
           // bool needUserPassword = false;
            switch (appSettings.EncryptionLevel)
            {
                case EncryptionLevel.None:
                    needPassword = false;
                    break;
                case EncryptionLevel.Auto:
                    needPassword = true;
                    break;
                case EncryptionLevel.Full:
                    needPassword = true;
                    //needUserPassword = true; //Need to Ask For the Password Every time
                    break;
                default:
                    break;
            }
            if (needPassword)
            {
                if (appSettings.Password == null)
                {
                    //Need to prompt for Password and verify that it is correct so as not to end up encrypting encrypted data and destroying it.
                    CtrlPasswordEnter cpe = new CtrlPasswordEnter();
                    Forms.ShowPopupControl(cpe, "Enter System Password", null);
                    appSettings.Password = cpe.Password;
                    appSettings.Decrypt();
                    if (appSettings.Verification != verification) // That would be bad for Auto.. but would happen if the password changed.
                    {
                        MessageBox.Show("Verification Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null; // Exit..
                    }
                }
                else
                {
                    if (appSettings.Verification != verification) // That would be bad for Auto.. but would happen if the password changed.
                    {
                        MessageBox.Show("Verification Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null; // Exit..
                    }
                    AESGCM.Password = appSettings.Password; // Set for Shortened function calls
                }
            }
            if (appSettings.Verification != verification) // That would be bad for Auto.. but would happen if the password changed.
            {
                MessageBox.Show("Verification Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Exit..
            }
            //Assign a default path if one doesn't exist.
            if (appSettings.DbPath == null)
            {
                //Hard Coded Default Database path.
                //Can't See the DbPath without a password unless no password is to be used and only base64
                appSettings.DbPath = PersistenceBase.GetAbsolutePath(@"\Data\mybills.bbp");
            }
            return appSettings;
        }
        internal static Database LoadDatabase(String dbPath)
        {
            return PersistenceBase.Load<Database>(dbPath);
        }
        internal static void SaveData(ApplicationSettings appSettings, Database db)
        {
            
            //Encrypt and save
            //appSettings.Encrypt();
            Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
            //appSettings.Decrypt();
            db.Verification = appSettings.Verification; //Update Verification
            Save(appSettings.DbPath, db); // Save the database
        }
    }
}
