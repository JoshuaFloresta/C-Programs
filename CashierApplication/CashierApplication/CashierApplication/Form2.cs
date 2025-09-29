using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        abstract class UserAccount
        {
            private string full_name;    
            protected string user_name;  
            protected string user_password;

            protected UserAccount(string name, string uName, string password)
            {
                this.full_name = name;
                this.user_name = uName;
                this.user_password = password;
            }

            public abstract bool ValidateLogin(string uName, string password);

            public string GetFullName()
            {
                return full_name;
            }
        }

        class Cashier : UserAccount
        {
            private string department;  

            public Cashier(string name, string department, string uName, string password)
                : base(name, uName, password)
            {
                this.department = department;
            }

            public override bool ValidateLogin(string uName, string password)
            {
                return this.user_name == uName && this.user_password == password;
            }

            public string GetDepartment()
            {
                return department;
            }
        }

    private void submitBtn_Click(object sender, EventArgs e)
        {
            string user_name = UnameBox.Text;
            string user_password = passwordBox.Text;

            Cashier cashier = new Cashier("Joshua Floresta", "Sales", "Joshz", "01cashier");

            if(user_name == "" || user_password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cashier.ValidateLogin(user_name, user_password))
            {
                MessageBox.Show($"Welcome {cashier.GetFullName()} from {cashier.GetDepartment()} department!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmPurchaseDiscount purchaseForm = new frmPurchaseDiscount();
                purchaseForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
