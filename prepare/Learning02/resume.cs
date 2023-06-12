using System;

public class Resume
{
    public string _name;
    public string _email;
    public string _phoneNumber;
    public string _skills;

    public List<WorkHistory> _jobs = new List<WorkHistory>();

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