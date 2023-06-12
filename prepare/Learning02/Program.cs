using System;
// using ResumeBuilder;


class Program
{
    static void Main(string[] args)
    {
        // Resume myResume = new Resume();
        // myResume._name = "Marvin Galicia";
        // myResume._email = "mgalicia0315@gmail.com";
        // myResume._phoneNumber = "747-327-1067";
        // myResume._skills = "programming, teamwork, communication";
        // Console.WriteLine(myResume);

        WorkHistory Mcds = new WorkHistory();
        Mcds._companyName = "McDonalds";
        Mcds._jobTitle = "Crew Member";
        Mcds._startDate = "2017";
        Mcds._endDate = "2018";
        // Console.WriteLine(Mcds);

        WorkHistory CCC = new WorkHistory();
        CCC._companyName = "CCC";
        CCC._jobTitle = "Ticket Maker";
        CCC._startDate = "2018";
        CCC._endDate = "2019";
        // Console.WriteLine(CCC);

        WorkHistory Construction = new WorkHistory();
        Construction._companyName = "Many";
        Construction._jobTitle = "Labor/Handyman";
        Construction._startDate = "2019";
        Construction._endDate = "2023";
        // Console.WriteLine(Construction);

        WorkHistory Tender = new WorkHistory();
        Tender._companyName = "Tender Greens";
        Tender._jobTitle = "Carver";
        Tender._startDate = "2019";
        Tender._endDate = "2019";
        // Console.WriteLine(Tender);

        WorkHistory TelAviv = new WorkHistory();
        TelAviv._companyName = "Tel Aviv Grill";
        TelAviv._jobTitle = "Ticket Maker";
        TelAviv._startDate = "2021";
        TelAviv._endDate = "2021";
        // Console.WriteLine(TelAviv);

        WorkHistory Chats = new WorkHistory();
        Chats._companyName = "CCC";
        Chats._jobTitle = "Hospitality";
        Chats._startDate = "2023";
        Chats._endDate = "2023";
        // Console.WriteLine(Chats);

        WorkHistory Mission = new WorkHistory();
        Mission._companyName = "Church of Jesus Christ of Latter Day Saints";
        Mission._jobTitle = "Elder";
        Mission._startDate = "late 2023";
        Mission._endDate = "2025";
        // Console.WriteLine(Mission);


        Resume myResume = new Resume();
        myResume._name = "Marvin Galicia";
        myResume._email = "mgalicia0315@gmail.com";
        myResume._phoneNumber = "747-327-1067";
        myResume._skills = "programming, teamwork, communication";
        myResume._jobs.Add(Mcds);
        myResume._jobs.Add(CCC);
        myResume._jobs.Add(Construction);
        myResume._jobs.Add(Tender);
        myResume._jobs.Add(TelAviv);
        myResume._jobs.Add(Chats);
        myResume._jobs.Add(Mission);

        myResume.Display();

    }
}

