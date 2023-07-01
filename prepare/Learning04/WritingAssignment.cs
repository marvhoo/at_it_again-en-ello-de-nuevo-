
namespace library
{
    class WritingAssignment : Assignment
    {
        private string _title = "";

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }
        public string GetWritinginformation()
        {
            return $"{_studentID}: {_studentName} - {_topic}\n" 
            + $"{_title}";
        }
    }
}