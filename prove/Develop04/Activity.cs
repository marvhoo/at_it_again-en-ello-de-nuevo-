using System.Diagnostics;

    class Activity
    {
        private string _name, _description;
        static int _duration, _spinnerCounter;


        public Activity()
        {
            _spinnerCounter = _duration = 0;
        }

        public void SetActivityName(string activityName)
        {
            _name = activityName;
        }
        

        public void SetDescription(string description)
        {
            _description = description;
        }

        public int GetDuration()
        {
            return _duration;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name}!\n");
            Console.WriteLine(_description+"\n");

            Console.WriteLine("How many seconds would you like to do this activity for?");
            _duration = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"You will be doing this activity for {_duration} seconds.\n"
            + "Get ready...");
            Console.Beep();
            ShowSpinner(4);
            Console
            
            
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nYou have completed the activity!\n"
            + $"{_duration} seconds of {_name} complete!");
            Console.Beep();
            ShowSpinner(4);
            Console.Write("\nPress any key to continue...\n");
            Console.ReadKey();
            Console.Beep();
            Console.Clear();
        }

        public void ShowSpinner(int seconds)
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(seconds);  
            List<string> spinner = new List<string> {"/", "-", "\\", "|"};

            while (DateTime.Now < end)
            {
                foreach (string s in spinner)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                }
            }    

            Console.Write(" ");
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(string.Format("{0}", i));
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Thread.Sleep(1000);
            } 
            Console.Write(" ");
        }
    }
    
