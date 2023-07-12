  
namespace Goals
{
    class ChecklistGoal : Goal
    {
        public int howMany{get; set; }
        public int forBonus{get; set; }
        public int bonusPoints{get; set; }


        public ChecklistGoal(string name, string description, int points, 
        int HowMany, int BonusPoints, bool isComplete=false, int ForBonus=0)
        : base(name, description, points, isComplete)
        {
            howMany = HowMany;
            bonusPoints = BonusPoints;
            forBonus = ForBonus; 
        }

        public override void RecordEvent()
        {
            if (howMany < forBonus)
            {
                howMany++;
                
            }
            if (howMany == forBonus)
            
            {
                IsComplete = true;
            }
        }

        public override void GetStringRepresentation()
        {
            SaveString = $"ChecklistGoal\\{_shortName}\\{_description}\\{_points}\\{howMany}\\{forBonus}\\{bonusPoints}\\{IsComplete}\\";
        }

        public override void GetDetailsString()
        {
            string checkbox = "";
            if (IsComplete)
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }
            _listString = $"{checkbox} {_shortName} {_description} -- Currently completed {howMany}/{forBonus}";
        }

        
    }
}
