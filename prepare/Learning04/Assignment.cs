
namespace library
{
    public class Assignment
    {
        private string _studentName, _topic, _studentID;

        public Assignment(string studentName, string studentID, string topic)
        {
            _studentName = studentName;
            _studentID = studentID;
            _topic = topic;
        }

        public string GetStudentName()
        {
            return _studentName;
        }

        // public void SetStudentName(string studentName)
        // {
        //     _studentName = studentName;
        

        public string GetTopic()
        {
            return _topic;
        }

        // public void SetTopic(string topic)
        // {
        //     _topic = topic;
        // }                           

        public string GetStudentID()
        {
            return _studentID;
        }

        // public void SetStudentID(string studentID)
        // {
        //     _studentID = studentID;
        // }
        
        public string GetSummary()
        {
            return $"ID: {_studentID}: {_studentName} - {_topic}";
        }   
    }
}