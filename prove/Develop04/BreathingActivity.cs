
    class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            this.SetActivityName("Breathing Activity");
            this.SetDescription("This activity will help you relax and focus by breathing"
            + "in and out slowly and deeply.\nYou will be prompted to breathe in and out for a set amount of time.");
        }

        public void Run()
        {
            DisplayStartingMessage();
            int interval = GetDuration() / 6;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(interval);
                
                Console.WriteLine("\nBreathe out...");
                ShowCountDown(interval);
            
            }
            DisplayEndingMessage();
        }
    }
