using System;
public class WorkHistory
{
    public string _companyName;
    public string _jobTitle;
    public string _startDate;
    public string _endDate;
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate} - {_endDate}");
    }
    
}

// public class Resume
// {
//     public string _name = "";
//     public string _email = "";
//     public string _phoneNumber = "";
//     public string _skills = "";

//     public override string ToString()
//     {
//         return $"Name: {_name}\nEmail: {_email}\nPhone Number: {_phoneNumber}\nSkills: {_skills}";
//     }
// }

