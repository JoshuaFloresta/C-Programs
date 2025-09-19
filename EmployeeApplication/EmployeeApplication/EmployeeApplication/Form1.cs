using System;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            this.Load += frmEmployeeDatabase_Load;
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            // Setup DataGridView columns
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Employee ID";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Last Name";
            dataGridView1.Columns[3].Name = "Position";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Create new employee using constructor
            Employee emp = new Employee(
                employeeId.Text,
                firstName.Text,
                lastName.Text,
                position.Text
            );

            // Add to DataGridView
            dataGridView1.Rows.Add(emp.EmployeeId, emp.FirstName, emp.LastName, emp.Position);

            // Clear textboxes
            employeeId.Clear();
            firstName.Clear();
            lastName.Clear();
            position.Clear();
        }
    }
}
