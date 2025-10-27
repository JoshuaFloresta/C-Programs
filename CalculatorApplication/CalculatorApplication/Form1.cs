using System;


namespace CalculatorApplication
{

    public class CalculatorClass
    {
        public delegate T Formula<T>(T x, T y);
        public Formula<double> myFormula;

        public double GetSum(double a, double b) => a + b;
        public double GetDifference(double a, double b) => a - b;
        public double GetProduct(double a, double b) => a * b;
        public double GetQuotient(double a, double b) => a / b;

        public event Formula<double> CalculateEvent
        {
            add
            {
                myFormula += value;
                Debug.WriteLine("Added the Delegate");
            }
            remove
            {
                myFormula -= value;
                Debug.WriteLine("Removed the Delegate");
            }
        }
    }

    public partial class Form1 : Form
    {
        CalculatorClass cal;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();

            cbOperator.Items.AddRange(new string[] { "+", "-", "x", "/" });
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxInput1.Text) ||
            (string.IsNullOrWhiteSpace(txtBoxInput2.Text))
             || string.IsNullOrWhiteSpace(cbOperator.Text))
            {
                MessageBox.Show("Please fill up all fields");
            }
            else
            {
                double num1 = Convert.ToDouble(txtBoxInput1.Text.Trim());
                double num2 = Convert.ToDouble(txtBoxInput2.Text.Trim());

                 switch (cbOperator.Text)
            {
                case "+":
                    cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetSum);
                    lblDisplayTotal.Visible = true;
                    break;

                case "-":
                    cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Visible = true;

                    break;
                case "x":
                    cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text=cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Visible = true;

                    break;
                case "/":
                    cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Visible = true;

                    break;
            }
            }
        }
    }
}
