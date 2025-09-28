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
    public partial class Form2 : Form
    {
        public Form2()
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


        }
    }
}
