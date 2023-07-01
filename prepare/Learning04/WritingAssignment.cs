
namespace library
{
    class WritingAssignment : Assignment
    {
        private string _title = "";

        public WritingAssignment(string studentName, string studentID, string topic, string title)
            : base(studentName, studentID, topic)
        {
            _title = title;
        }

        // public string GetTitle()
        // {
        //     return _title;
        // }

        // public void SetTitle(string title)
        // {
        //     _title = title;
        // }
        public string GetWritinginformation()
        {
            string studentName = GetStudentName();
            string topic = GetTopic();
            string studentID = GetStudentID();
            string title = _title;

            return $"ID: {studentID}: {studentName} - {topic}\n" 
            + $"{title} by {studentName}";
        }
    }
}