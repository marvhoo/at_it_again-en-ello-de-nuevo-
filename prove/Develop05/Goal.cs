
namespace Goals
{
    class Goal : IGoal
    {
        // TODO: private strings of _shortName, _description, _category, _difficulty, _status, _dateCreated, _dateCompleted
        // TODO: private ints of _id, _score, _bonus

        public string _shortName, _description, _listString, SaveString;
        public int _points;
        public bool IsComplete = false;
        public Goal()
        {

        }
        public Goal(string name , string description, 
        int points, bool isComplete)
        {
            _shortName = name;
            _description = description;
            _points = points;
            IsComplete = isComplete;
        }
        

        // TODO: public void of RecordEvent, bool of IsComplete, strings of GetDetailsString, GetStringRepresentation

        //RecordGoal()
        public virtual void RecordEvent()
        {
            IsComplete = true;
        }

        //SaveToSaveString()
        public virtual void GetStringRepresentation()
        {
            SaveString =  $"{_shortName}\\{_description}\\{_points}\\{IsComplete}";
        }     

        //SaveToListString()
        public virtual void GetDetailsString()
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
            _listString = $"{checkbox} {_shortName} {_description} {_points}";
        }
        
        
    }

    internal interface IGoal
    {
    }
}
