using System.Text.RegularExpressions;
using System;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        BindingSource showProductList;

        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;


        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$")) 
                throw new StringFormatException("Product name must only contain letters.");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$")) 
                throw new NumberFormatException("Quantity must be a number.");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^\d+(\.\d+)?$"))    
                throw new CurrencyFormatException("Price must be a valid number.");
            return Convert.ToDouble(price);
        }



        class ProductClass
        {
            private int _Quantity;
            private double _SellingPrice;
            private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
            public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
            double Price, int Quantity, string Description)
            {
                this._Quantity = Quantity;
                this._SellingPrice = Price;
                this._ProductName = ProductName;
                this._Category = Category;
                this._ManufacturingDate = MfgDate;
                this._ExpirationDate = ExpDate;
                this._Description = Description;
            }
            public string productName
            {
                get
                {
                    return this._ProductName;
                }
                set
                {
                    this._ProductName = value;
                }
            }


            public string category
            {
                get
                {
                    return this._Category;
                }
                set
                {
                    this._Category = value;
                }
            }
            public string manufacturingDate
            {
                get
                {
                    return this._ManufacturingDate;
                }
                set
                {
                    this._ManufacturingDate = value;
                }
            }
            public string expirationDate
            {
                get
                {
                    return this._ExpirationDate;
                }
                set
                {
                    this._ExpirationDate = value;
                }
            }
            public string description
            {
                get
                {
                    return this._Description;
                }
                set
                {
                    this._Description = value;
                }
            }
            public int quantity
            {
                get
                {
                    return this._Quantity;
                }
                set
                {
                    this._Quantity = value;
                }
            }
            public double sellingPrice
            {
                get
                {
                    return this._SellingPrice;
                }
                set
                {
                    this._SellingPrice = value;
                }
            }
        }



        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }


        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Number");
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid String");
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Price");
            }
            finally
            {
                txtProductName.Clear();
                txtQuantity.Clear();
                txtSellPrice.Clear();
            }
        }
    }
}


