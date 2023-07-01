
namespace library
{ 
    class MathAssignment : Assignment
    {
        private string _textbookSection, _problem = "";

        public MathAssignment(string studentName, string studentID, string topic, string textbookSection, string problem)
            : base(studentName, studentID, topic)
        {
            _textbookSection = textbookSection;
            _problem = problem;
        }


        // public string GetTextbookSection()
        // {
        //     return _textbookSection;
        // }

        // public void SetTextbookSection(string textbookSection)
        // {
        //     _textbookSection = textbookSection;
        // }

        // public string GetProblem()
        // {
        //     return _problem;
        // }

        // public void SetProblem(string problem)
        // {
        //     _problem = problem;
        // }

        public string GetHomeworkList()
        {
            string studentName = GetStudentName();
            string topic = GetTopic();
            string studentID = GetStudentID();
            
            return $"{studentID}: {studentName} - {topic}\n"  
            + $"Section {_textbookSection} Problems {_problem}";
        }
    }
}