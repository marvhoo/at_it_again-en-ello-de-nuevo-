
namespace FinalProject
{
    class UserManagement : Management
    {
        List<User> users = new();
        readonly DataBase database = new();
        public UserManagement()

        {
            menuOptions = new()
            {
                "List all members",
                "Add a new member",
                "Update a member",
                "Delete a member",
                "Exit"
            };
        }

        

        
        
    }
}