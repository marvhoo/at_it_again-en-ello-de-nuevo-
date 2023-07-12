
// class SimpleGoalManagement
// {
//     public void DisplayGoals
// }

// while (choice != 6)
//             {
//                 Console.Clear();
//                 foreach (string item in menu)
//                 {
//                     Console.WriteLine(item);
//                 }
//                 Console.Write("What would you like to do? \n>");
//                 // following will throw an exception if user enters a non-integer 

//                 if (!int.TryParse(Console.ReadLine(), out choice))
//                 {
//                     Console.WriteLine("Invalid choice");
//                     Thread.Sleep(2000);
//                     continue;
//                 }

//                 else if (choice < 1 || choice > 6)
//                 {
//                     Console.WriteLine("Invalid choice");
//                     Thread.Sleep(2000);
//                     continue;
//                 }

//                 else if (choice == 6)
//                 {
//                     Console.WriteLine("Goodbye!");
//                     Thread.Sleep(2000);
//                     break;
//                 }

//                 else
//                 {
//                     switch (choice)
//                     {
//                         case 1:
//                             int goalChoice = 0;
//                             Console.Clear();
//                             Console.WriteLine("Choose a goal preference: ");
                            

//                             foreach (string item in goalTypes)
//                                 {
//                                     Console.WriteLine(item);
//                                 }
//                                 Console.Write("What goal would you like to set? \n>");
//                                 // following will throw an exception if user enters a non-integer

//                                 if (!int.TryParse(Console.ReadLine(), out goalChoice))
//                                 {
//                                     Console.WriteLine("Invalid choice");
//                                     Thread.Sleep(2000);
//                                     continue;
//                                 }

//                             if (goalChoice == 1)
//                             {
                                

                                
//                                 switch (goalChoice)
//                                 {
//                                     case 1:
//                                         Console.Clear();
//                                         Console.WriteLine("Simple Goal Creation\n");

//                                         Console.Write("What is the name of your goal?\n>");
//                                         string name = Console.ReadLine();

//                                         Console.Write("Description of your goal?\n>");
//                                         string description = Console.ReadLine();

//                                         Console.Write("Point value of your goal?\n>");
//                                         string points = Console.ReadLine();
//                                         SimpleGoal simpleGoal = new(name, description, points);


//                                         break;
//                                     case 2:
//                                         Console.WriteLine("Eternal Goal");
//                                         break;
//                                     case 3:
//                                         Console.WriteLine("Checklist Goal");
//                                         break;
//                                     default:
//                                         Console.WriteLine("Invalid choice");
//                                         break;
//                                 }
//                             }


//                             break;
//                         case 2:
//                             Console.WriteLine("Goal recording");

//                             break;
//                         case 3:
//                             Console.WriteLine("List all goals");
//                             break;
//                         case 4:
//                             Console.WriteLine("Name of the file to save to:");
//                             string fileName = Console.ReadLine();
//                             goalManager.SaveGoal(fileName);                


//                             break;
//                         case 5:
//                             Console.WriteLine("Load goals");
//                             break;
//                         case 6:
//                             Console.WriteLine("Exit");
//                             break;
//                         default:
//                             Console.WriteLine("Invalid choice");
//                             break;
//                     }
//                 }
//             }    