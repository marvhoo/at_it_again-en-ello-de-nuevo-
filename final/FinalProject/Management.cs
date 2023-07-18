
namespace FinalProject
{
    class Management
    {
        protected List<string> menuOptions = new();
        public Management()
        {
        }

        public virtual void ShowCatalog()
        {
            int count = 1;
            
            foreach (string mO in menuOptions)
            {
                Console.WriteLine($"{count}. {mO}");
                count++;
            }
            Console.WriteLine(); // spacing
            Console.Write("Enter your choice: ");
        }

        public virtual int GetCatalogChoice()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}