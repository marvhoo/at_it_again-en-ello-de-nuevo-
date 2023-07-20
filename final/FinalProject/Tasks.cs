
namespace FinalProject
{
    class Tasks : Management
    {
        public Tasks()
        {
            menuOptions.Add("User");
            menuOptions.Add("Coffee Machine");
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