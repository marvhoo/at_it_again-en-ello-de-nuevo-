
namespace Goals
{
    class SimpleGoal : Goal
    {

        
        public SimpleGoal(string name, string description, int points,
        bool isComplete=false)
        : base(name, description, points, isComplete)
        {
        }

        public override void GetStringRepresentation()
        {
            SaveString = $"SimpleGoal\\{_shortName}\\{_description}\\{_points}\\{IsComplete}";
        }

        


    }
}
