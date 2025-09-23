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
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public Employee(string firstName, string lastName)
        {
            this.employeeId = "";
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = "";
        }

        public Employee(string employeeId, string firstName, string lastName, string position)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }

    }
}
