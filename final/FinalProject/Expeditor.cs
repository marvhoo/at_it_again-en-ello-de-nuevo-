
using System.Data;
using System.IO.Compression;

namespace FinalProject
{
    class Expeditor : DataBase
    {
        private string userName, firstName, lastName, email, phoneNumber;

        public Expeditor(string userName, string firstName, string lastName, string email, string phoneNumber)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        Tasks tasks                                         = new();
        UserManagement userManagement                       = new();
        CoffeeMachineCatalog coffeeMachineManagement        = new();
      
        public Expeditor()
        {

        }

        public bool RunCatalog()
        {   Console.Clear();
            tasks.DisplayStartingMessage();
            tasks.ShowCatalog();
            int catalogChoice                               = tasks.GetCatalogChoice();
            return RunCatalogChoice(catalogChoice);
        
        }
        
        public bool RunUserManagement()
        {
            Console.Clear();
            userManagement.ShowCatalog();
            int catalogChoice                               = userManagement.GetCatalogChoice();
            return GoToUserManagementChoice(catalogChoice);       
        }

        public bool RunCoffeeMachineManagement()
        {
            Console.Clear();
            coffeeMachineManagement.ShowCatalog();
            int catalogChoice                               = coffeeMachineManagement.GetCatalogChoice();
            return GoToCoffeeMachineManagementChoice(catalogChoice);       
        }


        
        private bool RunCatalogChoice(int choice)
        {
            switch(choice)
            {
                //switch case for each catalog choice, 8 total
                case 1:
                    Console.Clear();
                    bool isRunning              = true;
                    while (isRunning)
                    {
                        isRunning = RunUserManagement();
                    }

                    return true;
                case 2:
                    Console.Clear();
                    bool isRunning2             = true; 
                    while (isRunning2)
                    {
                        isRunning2 = RunCoffeeMachineManagement();
                    }               
                    return true;
                case 3:
                    Console.Clear();
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    RunCatalog();
                    return true;
            }
        }


        public bool GoToUserManagementChoice(int choice)
        {
            switch(choice)
            {
                //switch case for each user management choice, 5 total
                case 1:
                
                    DisplayUsers();
                    Console.ReadKey();
                    return true;
                case 2:
                    Console.Write("Create a username: ");
                    string userName = Console.ReadLine();

                    Console.Write("\nEnter first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("\nEnter last name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("\nEnter email: ");
                    string email = Console.ReadLine();

                    Console.Write("\nEnter phone number: ");
                    string phoneNumber = Console.ReadLine();

                    User user = new(userName, firstName, lastName, email, phoneNumber);
                    AddUser(user);
                    return true;
                case 3:
                    Console.Write("\nEnter index of user to delete: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    DeleteUser(index);
                    return true;
                case 4:
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    RunUserManagement();
                    return true;
            }
        }

        public bool GoToCoffeeMachineManagementChoice(int choice)
        {
            switch(choice)
            {
                case 1:
                    Console.Write("Welcome to Dek's Coffee Machine!\nWhat would you like? (espresso, latte, cappuccino): ");
                    string coffeeChoice = Console.ReadLine().ToLower();
                    RunCoffeMake(coffeeChoice);            
                    return true;
                case 2:
                    Console.Write("This is your report as of today: ");
                    RunReport();
                    Console.ReadKey();
                    return true;
                case 3:
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    RunCoffeeMachineManagement();
                    return true;
            }
        
        }
        
        
    }
}