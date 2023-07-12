
namespace Goals
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points,
        bool isComplete=false) 
        : base(name, description, points, isComplete)
        {

        }

        public override void GetStringRepresentation()
        {
            SaveString = $"EternalGoal\\{_shortName}\\{_description}\\{_points}\\{IsComplete}";
        }
        

        public override void RecordEvent()
        {
            IsComplete = false;
        }

    
    }

}
