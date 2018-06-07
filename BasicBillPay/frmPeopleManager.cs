using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
namespace BasicBillPay
{
    public partial class frmPeopleManager : Form
    {
        Database db = null;
        Person selectedPerson = null;
        public frmPeopleManager()
        {
            InitializeComponent();
        }
        public frmPeopleManager(ref Database database)
        {
            InitializeComponent();
            db = database;
        }

        private void frmPeopleManager_Load(object sender, EventArgs e)
        {
            LoadPeople();
            LoadAccounts();
            LoadPaychecks();    
        }
        /// <summary>
        /// Load All Known People
        /// </summary>
        private void LoadPeople()
        {
            lbPeople.Items.Clear();
            foreach (Person p in db.People)
            {
                lbPeople.Items.Add(p);
            }
        }
        private void LoadAccounts(Person p = null)
        {
            clbAccounts.Items.Clear();
            //Income accounts only.
            foreach (Account a in db.GetUnmanagedIncomeAccounts())
            {
               clbAccounts.Items.Add(a);
            }
            if (p != null)
            {
                foreach (Account a in db.GetManagedIncomeAccounts(p))
                {
                    clbAccounts.Items.Add(a, true);
                }
            }

        }
        private void LoadPaychecks(Person p = null)
        {
            clbPaychecks.Items.Clear();
            foreach (Paycheck pc in db.GetUnmanagedPayChecks())
            {
                clbPaychecks.Items.Add(pc);
            }
            if (p != null)
            {
                foreach (Paycheck pc in db.GetManagedPayChecks(p))
                {
                    clbPaychecks.Items.Add(pc, true);
                }

            }
        }
        
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must have a name entered or selected.");
                return;

            }
            Person p = null;
            if (lbPeople.SelectedIndex >= 0)
            {
                p = lbPeople.SelectedItem as Person;
                if (p.Name != tbName.Text.Trim())
                {
                    if (MessageBox.Show("Are you sure you want to update: " + p.Name + " - and change their name to: " + tbName.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            else
            {
                //This should be a new person anyway if no list box selection
                p = db.GetPerson(tbName.Text.Trim());
            }
            if (p == null)
            {
                p = new Person();
                db.People.Add(p);
            }
            p.Name = tbName.Text.Trim(); // Update Name
            p.AccountIds.Clear(); // Clear Accounts so they can be un-checked
            //Add Accounts
            foreach (var item in clbAccounts.CheckedItems)
            {
                Account a = item as Account;

                p.AccountIds.Add(a.Id);
            }
            //Add PayChecks
            p.PaycheckIds.Clear(); // Clear PayChecks so they can be unselected.
            foreach (var item in clbPaychecks.CheckedItems)
            {
                Paycheck pc = item as Paycheck;
                p.PaycheckIds.Add(pc.Id);
            }

            LoadPeople(); //Update People List

        }

        private void lbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPeople.SelectedIndex >= 0)
            {
                Person p = lbPeople.SelectedItem as Person;
                if (selectedPerson != p)
                {
                    selectedPerson = p;

                    tbName.Text = p.Name;
                    LoadAccounts(p);
                    LoadPaychecks(p);
                }
                else
                {
                    lbPeople.SelectedIndex = -1; // Deselect
                    selectedPerson = null;
                    LoadAccounts(null);
                    LoadPaychecks(null);
                }
            }
        }
    }
}
