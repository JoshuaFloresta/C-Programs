using System;
namespace UserNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        // Set up user and admin credentials
        User user = new User("user01", "pass123");

        Administrator admin = new Administrator("Joshua", "admin01", "admin123");

        Console.WriteLine("=== Login System ===");
        Console.WriteLine("Pls Enter your credentials");
        Console.Write("Enter User ID: ");
        string inputId = Console.ReadLine();

        Console.Write("Enter Password: ");
        string inputPass = Console.ReadLine();

        if (user.verifyLogin(inputId, inputPass))
        {
            Console.WriteLine("User login successful!");
        }
        else if (admin.verifyLogin(inputId, inputPass))
        {
            Console.WriteLine($"Administrator login successful! Welcome {admin.Admin_Name}");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }
}
    

     class User
    {
        private string user_id;
        protected string user_password;

       public User(string user_id, string user_password)
        {
            this.user_id = user_id;
            this.user_password = user_password;
        }

        public bool verifyLogin(string user_id, string user_password)
        {
            return this.user_id.Equals(user_id) && this.user_password.Equals(user_password);
        }

        public string User_Id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string User_Password
        {
            get { return user_password; }
            set { user_password = value; }
        }
    }
    

     class Administrator : User
    {
    private string admin_name;

    public Administrator(string admin_name, string user_id, string user_password)
        : base(user_id, user_password)  
    {
        this.admin_name = admin_name;
    }

    public string Admin_Name
    {
        get { return admin_name; }
        set { admin_name = value; }
    }
    
}