using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Tools;
using BasicBillPay.Controls;
using BasicBillPay.Models;
using BasicBillPay.Tools.Encryption;
namespace BasicBillPay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Load Application Settings to decide which direction to go
            ApplicationSettings appSettings = PersistenceBase.GetApplicationSettings(null);
            if (appSettings != null)
            {
                //Load DB
                Database db = PersistenceBase.LoadDatabase(appSettings.DbPath);
                if (db.Accounts.Count > 0 && db.PayChecks.Count > 0)
                {
                    Application.Run(new frmMain(appSettings, db));
                }
                else
                {
                    Application.Run(new frmWelcome(appSettings, db));
                    Application.Run(new frmMain(appSettings, db));
                }
            }
            //Application.Run(new frmMainOld()); Old Working hard coded
        }
    }
}
