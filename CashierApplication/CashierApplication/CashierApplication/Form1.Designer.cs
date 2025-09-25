namespace CashierApplication
{
    partial class frmPurchaseDiscount
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
            item_label = new Label();
            item_name = new TextBox();
            label1 = new Label();
            item_price = new TextBox();
            label2 = new Label();
            label3 = new Label();
            item_discount = new TextBox();
            item_quantity = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            total_price = new Label();
            payment_amount = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            change = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // item_label
            // 
            item_label.AutoSize = true;
            item_label.Location = new Point(12, 24);
            item_label.Name = "item_label";
            item_label.Size = new Size(34, 15);
            item_label.TabIndex = 0;
            item_label.Text = "Item:";
            // 
            // item_name
            // 
            item_name.Location = new Point(12, 42);
            item_name.Name = "item_name";
            item_name.Size = new Size(151, 23);
            item_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 75);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Price: ";
            // 
            // item_price
            // 
            item_price.Location = new Point(57, 71);
            item_price.Name = "item_price";
            item_price.Size = new Size(106, 23);
            item_price.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 22);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Discount (%): ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 74);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // item_discount
            // 
            item_discount.Location = new Point(169, 42);
            item_discount.Name = "item_discount";
            item_discount.Size = new Size(141, 23);
            item_discount.TabIndex = 6;
            // 
            // item_quantity
            // 
            item_quantity.Location = new Point(234, 74);
            item_quantity.Name = "item_quantity";
            item_quantity.Size = new Size(76, 23);
            item_quantity.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(89, 100);
            button1.Name = "button1";
            button1.Size = new Size(74, 26);
            button1.TabIndex = 8;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 142);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 142);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 10;
            label5.Text = "Total amount: ";
            // 
            // total_price
            // 
            total_price.AutoSize = true;
            total_price.Location = new Point(146, 142);
            total_price.Name = "total_price";
            total_price.Size = new Size(78, 15);
            total_price.TabIndex = 11;
            total_price.Text = "total_amount";
            total_price.Visible = false;
            // 
            // payment_amount
            // 
            payment_amount.AutoSize = true;
            payment_amount.Location = new Point(14, 166);
            payment_amount.Name = "payment_amount";
            payment_amount.Size = new Size(110, 15);
            payment_amount.TabIndex = 12;
            payment_amount.Text = "Payment Received: ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 162);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 23);
            textBox5.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(224, 160);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 14;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            change.AutoSize = true;
            change.Location = new Point(114, 197);
            change.Name = "change";
            change.Size = new Size(46, 15);
            change.TabIndex = 16;
            change.Text = "change";
            change.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 197);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 15;
            label9.Text = "Change:";
            // 
            // frmPurchaseDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 269);
            Controls.Add(change);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(payment_amount);
            Controls.Add(total_price);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(item_quantity);
            Controls.Add(item_discount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(item_price);
            Controls.Add(label1);
            Controls.Add(item_name);
            Controls.Add(item_label);
            Name = "frmPurchaseDiscount";
            Text = "Purchase Discounted Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label item_label;
        private TextBox item_name;
        private Label label1;
        private TextBox item_price;
        private Label label2;
        private Label label3;
        private TextBox item_discount;
        private TextBox item_quantity;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label total_price;
        private Label payment_amount;
        private TextBox textBox5;
        private Button button2;
        private Label change;
        private Label label9;
    }
}
