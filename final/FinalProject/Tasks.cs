
namespace FinalProject
{
    class Tasks : Management
    {
        public Tasks()
        {
            menuOptions.Add("User");
            menuOptions.Add("Food");
            menuOptions.Add("Music");
            menuOptions.Add("Books");
            menuOptions.Add("Movies");
            menuOptions.Add("Games");
            menuOptions.Add("Banking");
            menuOptions.Add("Exit");        
        }

        public override void ShowCatalog()
        {
            base.ShowCatalog();
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine("Welcome to your virtual assistant!");
            Console.WriteLine("Please select a task/hobby to manage.\n");
        }
    }
}