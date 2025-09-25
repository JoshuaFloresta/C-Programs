using System.Security.Cryptography.X509Certificates;

namespace CashierApplication
{
    public partial class frmPurchaseDiscount : Form
    {

        class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            private double total_price ; 
       

            public Item(string item_name, double item_price, int item_quantity)
            {
                this.item_name = item_name;
                this.item_price = item_price;
                this.item_quantity = item_quantity;
            }

            public double getTotalPrice()
            {
                total_price = item_price * item_quantity;
                return total_price;
            }

            public void setPayment(double amount)
            {
                return;
            }

        }

        class DiscountedItem : Item
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;

            public DiscountedItem(string item_name, double item_price, int item_quantity, double item_discount) : base(item_name, item_price, item_quantity)
            {
                this.item_name = item_name;
                this.item_price = item_price;
                this.item_quantity = item_quantity;
                //this.item_discount = item_discount;
            }

        }

        public frmPurchaseDiscount()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
