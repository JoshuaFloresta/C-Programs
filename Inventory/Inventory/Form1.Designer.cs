namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            gridViewProductList = new DataGridView();
            richTxtDescription = new RichTextBox();
            label8 = new Label();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 1;
            label2.Text = "Add Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(25, 106);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(25, 137);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 3;
            label4.Text = "Mfg Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(25, 168);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 4;
            label5.Text = "Exp Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(25, 202);
            label6.Name = "label6";
            label6.Size = new Size(32, 19);
            label6.TabIndex = 5;
            label6.Text = "Qty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(25, 235);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(127, 75);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(201, 23);
            txtProductName.TabIndex = 7;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(127, 106);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(201, 23);
            cbCategory.TabIndex = 8;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(127, 137);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(200, 23);
            dtPickerMfgDate.TabIndex = 9;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(127, 168);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(200, 23);
            dtPickerExpDate.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(126, 200);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(201, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(127, 235);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(201, 23);
            txtSellPrice.TabIndex = 12;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(25, 276);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(655, 140);
            gridViewProductList.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(355, 105);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(325, 124);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(355, 78);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(577, 240);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(101, 26);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProduct);
            Controls.Add(label8);
            Controls.Add(richTxtDescription);
            Controls.Add(gridViewProductList);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private DataGridView gridViewProductList;
        private RichTextBox richTxtDescription;
        private Label label8;
        private Button btnAddProduct;
    }
}
