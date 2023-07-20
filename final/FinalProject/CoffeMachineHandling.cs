
using System.Runtime.Versioning;

namespace FinalProject 
{
    class CoffeeMachineHandling 
    {
        public double _profit = 0;
        Dictionary<string, int> _resources = new();
        
        public CoffeeMachineHandling()
        {
            _resources.Add("water", 3000);
            _resources.Add("milk", 2000);
            _resources.Add("coffee", 1000);
        }

    // dictionary containing the ingredients of each drink, their quantities, and the price of each drink.
        Dictionary<string, Dictionary<string, dynamic>> _menu = new()
        {
            {
                "espresso", new Dictionary<string, dynamic>
                {
                    { "ingredients", new Dictionary<string, int>
                        {
                            { "water", 50 },
                            { "coffee", 18 }
                        }
                    },
                    { "cost", 1.5 }
                }
            },
            {
                "latte", new Dictionary<string, dynamic>
                {
                    { "ingredients", new Dictionary<string, int>
                        {
                            { "water", 200 },
                            { "milk", 150 },
                            { "coffee", 24 }
                        }
                    },
                    { "cost", 2.5 }
                }
            },
            {
                "cappuccino", new Dictionary<string, dynamic>
                {
                    { "ingredients", new Dictionary<string, int>
                        {
                            { "water", 250 },
                            { "milk", 100 },
                            { "coffee", 24 }
                        }
                    },
                    { "cost", 3.0 }
                }
            }
        };       

        //Returns True if the resources are sufficient to make the drink, False if not.
        public bool CanBeMade(Dictionary<string, int> _orderIngredients)
        {

            foreach (var item in _orderIngredients)
            {
                string ingredient = item.Key;
                int quantity = item.Value;
                if (!_resources.ContainsKey(ingredient) || quantity > _resources[ingredient])
                {
                    Console.WriteLine($"Sorry, there is not enough {ingredient}.");
                    return false;
                } 
            }
            return true;
        }

        // Returns the total calculated from coins inserted.
        private static double ProcessCoins()
        {
            Console.Write("Please insert coins (quarters dimes nickels pennies): ");
            string[] coinsInput = Console.ReadLine().Split(' ');

            int _quarters = int.Parse(coinsInput[0]);
            int _dimes = int.Parse(coinsInput[1]);
            int _nickels = int.Parse(coinsInput[2]);
            int _pennies = int.Parse(coinsInput[3]);

            double total = _quarters * 0.25 + _dimes * 0.1 + _nickels * 0.05 + _pennies * 0.01;
            return total;
        }


        // Returns true if the payment is accepted, false if not.
        public bool CheckPayment(double _moneyReceived, double _drinkCost)
        {
            if (_moneyReceived >= _drinkCost)
            {
                double _change = Math.Round(_moneyReceived - _drinkCost, 2);
                Console.WriteLine($"Here is your _change: ${_change}");
                _profit += _drinkCost;
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, that's not enough money. Money refunded.");
                return false;
            }
        }

        // deducts the required ingredients from the resources.
        public void MakeCoffee(string _drinkName, Dictionary<string, int> _orderIngredients, double _drinkCost)
        {
            foreach (KeyValuePair<string, int> item in _orderIngredients)
            {
                string ingredient = item.Key;
                int orderQuantity = item.Value;             
    
                if (_resources.ContainsKey(ingredient))
                {
                    _resources[ingredient] -= orderQuantity;
                }
                else
                {
                    Console.WriteLine($"Sorry, there is not enough {ingredient}.");
                    return;
                }
            }
            Console.WriteLine($"Here is your {_drinkName}. Enjoy!");
        
        }

        public void RunCoffeMake(string choice)
        {
            if (_menu.TryGetValue(choice, out var drink))
            {
                var ingredients = drink["ingredients"] as Dictionary<string, int>;
                double cost = drink["cost"];

                if (CanBeMade(ingredients))
                {
                    double payment = ProcessCoins();
                    if (CheckPayment(payment, cost))
                    {
                        MakeCoffee(choice, ingredients, cost);
                    }
                }
            
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid drink.");
                }
            }
        }
        
        public void RunReport()
        {
            Console.WriteLine($"Water: {_resources["water"]}ml");
            Console.WriteLine($"Milk: {_resources["milk"]}ml");
            Console.WriteLine($"Coffee: {_resources["coffee"]}g");
            Console.WriteLine($"Money: ${_profit}");
        }
    }
}