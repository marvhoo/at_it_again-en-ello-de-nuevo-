
namespace  Goals
{
    interface IGoal 
    {
        string _shortName {get; set;}
        string _description {get; set;}
        string points {get; set;}
        bool IsComplete {get; set;}
        string SaveString {get; set;}
        string _listString {get; set;}
        void RecordEvent();
        void GetStringRepresentation();
        void GetDetailsString();
    }
}