namespace CashierApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UnameBox = new TextBox();
            passwordBox = new TextBox();
            label2 = new Label();
            submitBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Username *";
            // 
            // UnameBox
            // 
            UnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UnameBox.Location = new Point(12, 70);
            UnameBox.Name = "UnameBox";
            UnameBox.Size = new Size(195, 23);
            UnameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(12, 115);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(195, 23);
            passwordBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Password *";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.CornflowerBlue;
            submitBtn.ForeColor = Color.Snow;
            submitBtn.Location = new Point(13, 144);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(189, 28);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Login";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold);
            label3.Location = new Point(76, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 186);
            Controls.Add(label3);
            Controls.Add(submitBtn);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(UnameBox);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UnameBox;
        private TextBox passwordBox;
        private Label label2;
        private Button submitBtn;
        private Label label3;
    }
}