namespace EmployeeNamespace
{
    public class Employee
    {
        // Private fields
        private string employeeId;
        private string firstName;
        private string lastName;
        private string position;

        // Public properties
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Constructor 1 (no parameters)
        public Employee() { }

        // Constructor 2 (with parameters)
        public Employee(string employeeId, string firstName, string lastName, string position)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }

        // Constructor 3 (partial data, uses 'this' to call another constructor)
        public Employee(string employeeId, string firstName)
            : this(employeeId, firstName, "N/A", "N/A") { }
    }
}
