
namespace FinalProject
{
    class CoffeeMachineCatalog : Management
    {
        public CoffeeMachineCatalog()
        {   
            {
                menuOptions.Add("Make Coffee");
                menuOptions.Add("Resources Status");
                menuOptions.Add("Exit");    
            }    
        }

        public override void ShowCatalog()
        {
            base.ShowCatalog();
        }
    }
}