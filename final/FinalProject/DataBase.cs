
namespace FinalProject
{
    class DataBase
    {
        List<User> users;

        public DataBase()
        {
            users = new();
        }

        public void DisplayUsers()
        {   
            LoadUsers();
            foreach(User user in users)
            {
                user.Display();
                Console.WriteLine();
            }
        }

        public void AddUser(User newUser)
        {
            users.Add(newUser);
            SaveUsers();
        }
        
        // public void UpdateUser(int index)
        // {
        //     users[index] = updatedUser;
        // }

        public void DeleteUser(int index)
        {
            users.RemoveAt(index);
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