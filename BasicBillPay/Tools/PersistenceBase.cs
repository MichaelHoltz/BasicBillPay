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
    public class PersistenceBase
    {
        public static T Load<T>(string CurrentFile, String DefaultFile = null) where T : new()
        {
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
            }
            return retval;
        }

        public static void Save(String CurrentFile, object obj)
        {
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
        }
        public static Type GetMyObjectClassType()
        {
            return typeof(PersistenceBase);
        }
        public static string GetAppPath()
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
        public static string GetAbsolutePath(String filePath)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + filePath;
            return path;
        }

        internal static ApplicationSettings GetApplicationSettings(Control controlToCenterPopupOn)
        {
            ApplicationSettings appSettings = Load<ApplicationSettings>(GetAbsolutePath(@"\Data\ApplicationSettings.bbp"));
            bool needPassword = true;
            bool needUserPassword = false;
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
                    needUserPassword = true; //Need to Ask For the Password Every time
                    break;
                default:
                    break;
            }
            if (needPassword)
            {
                if (appSettings.Password == null)
                {
                    //Get Password for settings and data
                    Forms.ShowPopupControl(new CtrlPasswordSetup(), "System Password", controlToCenterPopupOn);
                    appSettings.Password = AESGCM.Password;
                }
                else
                {
                    AESGCM.Password = appSettings.Password; // Set for Shortened function calls
                }
            }
            //Assign a default path if one doesn't exist.
            if (appSettings.DbPath == null)
            {
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
            Save(appSettings.DbPath, db);
            Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
        }
    }
}
