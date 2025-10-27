namespace CalculatorApplication
{
    partial class Form1
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
            num1 = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            num2 = new Label();
            txtBoxInput2 = new TextBox();
            label1 = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Font = new Font("Segoe UI", 12F);
            num1.Location = new Point(27, 25);
            num1.Name = "num1";
            num1.Size = new Size(145, 21);
            num1.TabIndex = 0;
            num1.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(203, 24);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(150, 29);
            txtBoxInput1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(237, 63);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(83, 27);
            cbOperator.TabIndex = 2;
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Font = new Font("Segoe UI", 12F);
            num2.Location = new Point(28, 98);
            num2.Name = "num2";
            num2.Size = new Size(166, 21);
            num2.TabIndex = 3;
            num2.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(202, 100);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(150, 29);
            txtBoxInput2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(126, 146);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 5;
            label1.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 14F);
            lblDisplayTotal.Location = new Point(203, 145);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(74, 25);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "Answer";
            lblDisplayTotal.Visible = false;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.Location = new Point(212, 202);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(141, 38);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 285);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label1);
            Controls.Add(txtBoxInput2);
            Controls.Add(num2);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(num1);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label num2;
        private TextBox txtBoxInput2;
        private Label label1;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
