
using System.Data;
using System.IO.Compression;

namespace FinalProject
{
    class Expeditor : DataBase
    {
        Tasks tasks = new();
        UserManagement userManagement = new();
        public Expeditor()
        {

        }

        public bool RunCatalog()
        {   Console.Clear();
            tasks.DisplayStartingMessage();
            tasks.ShowCatalog();
            int catalogChoice = tasks.GetCatalogChoice();
            return RunCatalogChoice(catalogChoice);
        
        }
        
        public bool RunUserManagement()
        {
            Console.Clear();
            userManagement.ShowCatalog();
            int catalogChoice = userManagement.GetCatalogChoice();
            return GoToUserManagementChoice(catalogChoice);       

            
        }
        
        private bool RunCatalogChoice(int choice)
        {
            switch(choice)
            {
                //switch case for each catalog choice, 8 total
                case 1:
                    Console.Clear();
                    bool isRunning = true;
                    while (isRunning)
                    {
                        isRunning = RunUserManagement();
                    }

                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                case 5:
                    return true;
                case 6: 
                    return true;
                case 7: 
                    return true;
                case 8: 
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
                    Console.Write("\nEnter index of user to update: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    // UpdateUser(index);
                    return true;
                case 4:
                    return true;
                case 5:
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    RunUserManagement();
                    return true;
            }
        }

    }
}