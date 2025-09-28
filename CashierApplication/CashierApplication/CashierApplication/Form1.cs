using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace CashierApplication
{
    public partial class frmPurchaseDiscount : Form
    {
        public frmPurchaseDiscount()
        {
            InitializeComponent();
        }

        abstract class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            private double total_price;


            public Item(string item_name, double item_price, int item_quantity)
            {
                this.item_name = item_name;
                this.item_price = item_price;
                this.item_quantity = item_quantity;
            }

            public abstract double GetTotalPrice();

            public abstract void SetPayment(double amount);
        }

        class DiscountedItem : Item 
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;

            public DiscountedItem(string item_name, double item_price, int item_quantity, double item_discount) 
                : base(item_name, item_price, item_quantity)
            {
                this.item_name = item_name;
                this.item_price = item_price;
                this.item_quantity = item_quantity;
                this.item_discount = item_discount;
            }

            public override double GetTotalPrice()
            {
                double discount = item_discount * 0.01;
                double discount_value = discount * item_price;
                discounted_price = item_quantity * (item_price - discount_value);

                return discounted_price;
            }

            public override void SetPayment(double amount)
            {
                payment_amount = amount;
            }

            public double getChange()
            {
                change = payment_amount - discounted_price;
                return change;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = item_name.Text;
            double itemPrice = Convert.ToDouble(itemBox.Text);
            int itemQuantity = Convert.ToInt32(item_quantity.Text);
            double itemDiscount = Convert.ToDouble(item_discount.Text);
            DiscountedItem item = new DiscountedItem(itemName, itemPrice, itemQuantity, itemDiscount);

            double totalPrice = item.GetTotalPrice();

            total_price.Text = "₱" + totalPrice.ToString();

            total_price.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemName = item_name.Text;
            double itemPrice = Convert.ToDouble(itemBox.Text);
            int itemQuantity = Convert.ToInt32(item_quantity.Text);
            double itemDiscount = Convert.ToDouble(item_discount.Text);
            double paymentAmount = Convert.ToDouble(payment_amount.Text);


            DiscountedItem item = new DiscountedItem(itemName, itemPrice, itemQuantity, itemDiscount);            
            item.SetPayment(paymentAmount);

            item.GetTotalPrice();
            
            if(paymentAmount < item.GetTotalPrice())
            {
                MessageBox.Show("Insufficient Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double changeAmount = item.getChange();
            change.Text = "₱" + changeAmount.ToString();
            change.Visible = true;

        }
    }
}
