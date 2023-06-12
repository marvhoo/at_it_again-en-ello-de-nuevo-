using System;

// Public class where other files will tap in.
public class Resume
{
    public string _name;
    public string _email;
    public string _phoneNumber;
    public string _skills;

    // Empty list where values will be added onto for later use.
    public List<WorkHistory> _jobs = new List<WorkHistory>();

// Funtion to display the information.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nEmail: {_email}\nPhone Number: {_phoneNumber}\nSkills: {_skills}");
        Console.WriteLine("Jobs:");

        foreach (WorkHistory job in _jobs)
        {
            job.Display();
        }
    }
}