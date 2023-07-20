
namespace FinalProject
{
    class DataBase : CoffeeMachineHandling
    {
        protected List<User> users;

        public DataBase()
        {
            users = new();
        }

        public void DisplayUsers()
        {   
            LoadUsers();
            int count = 1;
            foreach(User user in users)
            {   
                
                Console.Write($"{count}. ");
                count++;
                user.Display();
                Console.WriteLine();
            }
        }

        public void AddUser(User newUser)
        {   LoadUsers();
            users.Add(newUser);
            SaveUsers();
        }
        
        // method will delete user based on username
        // if username is not found, method will return true 
        // and user will be prompted to try again
        public void DeleteUser(int index)  //RUNdELETEUSER
        {
            users.RemoveAt(index);
            SaveUsers();
        }

        // users from AddUser() and DeleteUser() will be saved to a file
        public void SaveUsers()
        {
            List<string> _users = new();
            foreach(User user in users)
            {
                string userAsCSV = $"{user.userName}|{user.firstName}|{user.lastName}|{user.email}|{user.phoneNumber}";
                _users.Add(userAsCSV);
            }

            File.WriteAllLines("Users.txt", _users);
        }
        
        public void LoadUsers()
        {
            List<string> _users = File.ReadAllLines("Users.txt").ToList();
            foreach(string user in _users)
            {
                string[] userAsArray = user.Split("|");
                User newUser = new(userAsArray[0], userAsArray[1], userAsArray[2], userAsArray[3], userAsArray[4]);
                users.Add(newUser);
            }
        }
    }
}