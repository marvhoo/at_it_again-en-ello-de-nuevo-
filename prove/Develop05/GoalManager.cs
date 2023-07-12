
namespace Goals
{
    class GoalManager 
    {
        // TODO: private list of _goals, private int of _score
        private List<Goal> _goals = new();
        private int score ;
        Score _score = new();

        // TODO: List of public voids; Start, DisplayPlayerInfo, ListGoalname, ListGoalDetails, CreateGoal,
        // RecordEvent, SaveGoal, LoadGoal, 


        public GoalManager()
        {
            
        }

        public void Start()
        {
            List<string> menu = new()
            {
                "1. Create a new goal",
                "2. Record an event",
                "3. Display all goals",
                "4. Save goals",
                "5. Load goals",
                "6. Exit"
            };

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

        }

        // TODO: DisplayPlayerInfo, ListGoalname, ListGoalDetails, CreateGoal, RecordEvent, SaveGoal, LoadGoal,
        // DisplayPlayerInfo will display the player's name and score
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {score}\n");
        }

        // ListGoalname will list all the goal names
        public void ListGoalNames()
        {   
            Console.Clear();
            Console.WriteLine("What type of goal would you like to create?\n");
            List<string> goalTypes = new()
            {
                "1. Simple Goal",
                "2. Eternal Goal",
                "3. Checklist Goal"
            };

            foreach (string item in goalTypes)
            {
                Console.WriteLine(item);
            }

            Console.Write("\n>");
        }

        // ListGoalCurrentGoals()
        public void ListGoalDetails()
        {
       
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal._listString);
            }
        }

        // funtion will return a list of all the goals
        public List<Goal> GetGoals()
        {
            return _goals;
        }
    


        public void CreateGoal()
        {
            Console.Clear();

            ListGoalNames();

            int goalChoice = int.Parse(Console.ReadLine());
            if (goalChoice > 0 && goalChoice < 4)
            {
                Console.Clear();
                Console.Beep();
                Console.WriteLine("Creating goal\n");
                Thread.Sleep(2000);

                Console.Write("What is the name of your goal?\n>");
                string name = Console.ReadLine();

                Console.Write("Description of your goal?\n>");
                string description = Console.ReadLine();

                Console.Write("Point value for one complation?\n>");
                int points = int.Parse(Console.ReadLine());

                switch (goalChoice)
                {
                    case 1:
                        SimpleGoal simpleGoal = new(name, description, points);
                        _goals.Add(simpleGoal);
                        simpleGoal.GetStringRepresentation();
                        simpleGoal.GetDetailsString();
                        break;
                    case 2:
                        EternalGoal eternalGoal = new(name, description, points);
                        _goals.Add(eternalGoal);
                        eternalGoal.GetStringRepresentation();
                        eternalGoal.GetDetailsString();
                        break;
                    case 3:
                        Console.Write("How many times would you like to cokmplete the goal??\n>");
                        int forBonus= int.Parse(Console.ReadLine());

                        Console.Write("Bonus points?\n>");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        ChecklistGoal checklistGoal = new(name, description, points,
                        forBonus, bonusPoints);
                        _goals.Add(checklistGoal);
                        checklistGoal.GetStringRepresentation();
                        checklistGoal.GetDetailsString();
                        break;
              
                }
            }
            // loop is exited
        
        }

        // RecordGoal()
        public void RecordEvent()
        {
            int count = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{count}. {goal._listString}\n");
                count++;
            }

            Console.Write("Please chose a goal to record complete: ");
            int recordChoice = Convert.ToInt32(Console.ReadLine());
            if (_goals[recordChoice -1].IsComplete)
            {
            Console.WriteLine("That goal is already completed and cannot be completed further");
            } 
            else 
            {
                _goals[recordChoice - 1].RecordEvent();
                _score.SetScore(_goals[recordChoice - 1]._points);
                if(_goals[recordChoice - 1].GetType().ToString() == "ChecklistGoal")
                {
                    if(_goals[recordChoice - 1].IsComplete)
                    {
                        ChecklistGoal goal = (ChecklistGoal) _goals[recordChoice - 1];
                        _score.SetScore(goal.bonusPoints);
                        Console.WriteLine($"Congrats you earned {goal.bonusPoints} bonus points!");
                    }
                }
                _goals[recordChoice - 1].GetStringRepresentation();
                _goals[recordChoice - 1].GetDetailsString();
            }

    // show points
            Console.WriteLine($"Total Points: {_score.GetScore()}");
        }



        public void SaveGoal(string file, List<Goal> goalsList, Score score)
        {
            using (StreamWriter sw = new(file))
            {
                sw.WriteLine(score.GetScore());
                for(int i = 0; i < goalsList.Count; i++)
                {
                    sw.WriteLine(goalsList[i].SaveString);
                }
            }
                
        }

        public void LoadGoal(string file, Score score)
        {
            string[] lines = File.ReadAllLines(file);
            score.SetScore(int.Parse(lines[0]));
            List<Goal> loadList = new();
            for(int i = 1; i < lines.Length; i++)
            {
                string[] lineParts = lines[i].Split("\\");
                if(lineParts[0] == "SimpleGoal")
                {
                    loadList.Add(new SimpleGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToBoolean(lineParts[4])));
                } 
                else if(lineParts[0] == "EternalGoal")
                {
                    loadList.Add(new EternalGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToBoolean(lineParts[4])));
                } 
                else if(lineParts[0] == "ChecklistGoal")
                {
                    loadList.Add(new ChecklistGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToInt32(lineParts[5]), Convert.ToInt32(lineParts[6]), Convert.ToBoolean(lineParts[7]), Convert.ToInt32(lineParts[4])));
                }
            }
            foreach(var goal in loadList)
            {
                goal.GetDetailsString();
                goal.GetStringRepresentation();
            }
            _goals = loadList;
        }
        


    }
}