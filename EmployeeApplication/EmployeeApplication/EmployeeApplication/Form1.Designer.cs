namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            employeeId = new TextBox();
            firstName = new TextBox();
            label4 = new Label();
            lastName = new TextBox();
            label5 = new Label();
            position = new TextBox();
            label6 = new Label();
            submitBtn = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 0;
            label2.Text = "Add Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 46);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 1;
            label3.Text = "Employee ID *";
            // 
            // employeeId
            // 
            employeeId.Location = new Point(24, 70);
            employeeId.Name = "employeeId";
            employeeId.Size = new Size(190, 23);
            employeeId.TabIndex = 2;
            // 
            // firstName
            // 
            firstName.Location = new Point(24, 116);
            firstName.Name = "firstName";
            firstName.Size = new Size(190, 23);
            firstName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 96);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 3;
            label4.Text = "First Name *";
            // 
            // lastName
            // 
            lastName.Location = new Point(24, 165);
            lastName.Name = "lastName";
            lastName.Size = new Size(190, 23);
            lastName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 142);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 5;
            label5.Text = "Last Name *";
            // 
            // position
            // 
            position.Location = new Point(24, 213);
            position.Name = "position";
            position.Size = new Size(190, 23);
            position.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 190);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 7;
            label6.Text = "Position *";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.Highlight;
            submitBtn.ForeColor = SystemColors.Control;
            submitBtn.Location = new Point(66, 242);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(91, 30);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(234, 13);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 11;
            label7.Text = "Employee List";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(234, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(410, 244);
            dataGridView1.TabIndex = 12;
            // 
            // frmEmployeeDatabase
            // 
            ClientSize = new Size(656, 302);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(submitBtn);
            Controls.Add(position);
            Controls.Add(label6);
            Controls.Add(lastName);
            Controls.Add(label5);
            Controls.Add(firstName);
            Controls.Add(label4);
            Controls.Add(employeeId);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmEmployeeDatabase";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox employeeId;
        private TextBox firstName;
        private Label label4;
        private TextBox lastName;
        private Label label5;
        private TextBox position;
        private Label label6;
        private Button submitBtn;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
