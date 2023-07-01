
namespace library
{
    class Assignment
    {
        protected string _studentName, _topic, _studentID = "";

        public string GetStudentName()
        {
            return _studentName;
        }

        public void SetStudentName(string studentName)
        {
            _studentName = studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public void SetTopic(string topic)
        {
            _topic = topic;
        }                           

        public string GetStudentID()
        {
            return _studentID;
        }

        public void SetStudentID(string studentID)
        {
            _studentID = studentID;
        }
        
        public string GetSummary()
        {
            return $"{_studentID}, {_studentName} - {_topic}";
        }   
    }
}