using System;
using System.ComponentModel.Design.Serialization;
using Goals;

GoalManager goalManager     = new();
Score score                 = new();
int choice                  = 0;

Console.WriteLine("Welcome to the Goal Manager!");

var _goalsList = goalManager.GetGoals();


while (choice != 6)
{
    goalManager.DisplayPlayerInfo();
    Console.WriteLine("Select an option from the menu below:\n>");
    goalManager.Start();
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:            
            goalManager.CreateGoal();
            Console.Clear();

            break;
        
        case 2:
            Console.WriteLine("Goal recording");
            goalManager.RecordEvent();
            break;
        
        case 3:
            Console.WriteLine("Your goals are:\n");
            goalManager.ListGoalDetails();
            break;
        
        case 4:
            Console.WriteLine("Name of the file to save to:");
            string fileName = Console.ReadLine();
            goalManager.SaveGoal(fileName, _goalsList, score);                

            break;
        
        case 5:
            Console.WriteLine("Name of the file to load from:");
            string loadFileName = Console.ReadLine();
            goalManager.LoadGoal(loadFileName, score);

            break;
    }
}


// showed creativity by implementing a scoring system, an interface, various classes that 
// inherit from the interface, and a class that uses the interface as a property
// Additionally, created a class for score tracking. 
// Changed behaviors from the "original" blueprint.