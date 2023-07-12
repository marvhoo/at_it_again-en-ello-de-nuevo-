
class Entry 
{
    public string _shortName, _description, _points; 
    public Entry(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_shortName}\n{_description}\n{_points}");
    }

    public void SimpleGoalDescription()
    {
        Console.WriteLine("Simple Goal: A goal that can be completed in one step.");
    }
}