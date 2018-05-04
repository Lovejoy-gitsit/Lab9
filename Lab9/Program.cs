using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab9
{
    class Program
    {
        //declare a variable for a counter to increase the number range of students once they are added
        static int studentCounter = 0;
        static void Main(string[] args)
        {
   
            List<string> NamesList = new List<string>() { "Kim", "John", "Lonnie", "Diana", "Patricia", "Derrick", "Tim", "Brian", "Shawn", "Tina", "Richard", "Nicole", "Paula", "Karen", "Stephen", "Jacob", "Sonya", "David", "JJ", "Crystal" };
            List<string> FoodList = new List<string>(){ "Pizza", "Burgers", "Pasta", "Chips", "Lasanga", "Turkey", "Macaroni & Cheese", "Ribs", "Salmon", "Ice Cream", "Cake", "Cereal", "Seafood", "Funnel Cake", "Pancakes", "Chili", "PB&J", "Brisket", "Snickers", "Nachos" };
            List<string> HometownList = new List<string>(){ "New York", "Detroit", "Dallas", "Phoenix", "Miami", "Los Angeles", "Seattle", "Kansas City", "Oklahoma City", "Atlanta", "Cleveland", "Houston", "Boston", "San Diego", "Chicago", "Green Bay", "Newark", "Virginia Beach", "Philadelphia", "Austin" };
            List<string> ColorList = new List<string>() { "Orange", "Blue", "Red", "Yellow", "Black", "Purple", "Gray", "White", "Brown", "Green", "Silver", "Gold", "Maroon", "Tan", "Lavender", "Turquoise", "Pink", "Dark Blue", "Dark Red", "Light Blue" };
            //ArrayList addNewName = new ArrayList();
                Console.WriteLine("Welcome to our C# class");
                //Console.WriteLine("Which student would you like to know more about: (enter a number between 1-20) ");
                //printing list to the screen
                foreach (string elements in NamesList)
                    //printing user number selection
                    Console.WriteLine(elements);
                //Console Clear prevents list from showing
                Console.Clear();
            while (true)
            {

                Console.Write($"Enter a number between 1 and {20 + studentCounter} to learn more about a student: ");
                int userStudentSelection = 0;
                while (!int.TryParse(Console.ReadLine(), out userStudentSelection) || userStudentSelection < 1 || userStudentSelection > 20 + studentCounter) 
                {
                Console.Write("Enter a valid number: ");
                }
                //Names.Add(UserSelection);
                Console.WriteLine($"You selected student {userStudentSelection}, {NamesList[userStudentSelection-1]}");
                studentCounter++;
           
            
                Console.WriteLine($"Enter (h) for hometown, (f) for food, or (c) for color to learn more about, {NamesList[userStudentSelection - 1]}");
                string aboutStudentSelection = Console.ReadLine().ToLower();
                if (aboutStudentSelection == "h")
                {
                    Console.WriteLine($"{NamesList[userStudentSelection - 1]}'s hometown is {HometownList[userStudentSelection - 1]}");
                }
                else if (aboutStudentSelection == "f")
                {
                    Console.WriteLine($"{NamesList[userStudentSelection - 1]}'s favorite food is {FoodList[userStudentSelection - 1]}");
                }
                else if (aboutStudentSelection == "c")
                {
                    Console.WriteLine($"{NamesList[userStudentSelection - 1]}'s favorite color is {ColorList[userStudentSelection - 1]}");
                }

                Console.WriteLine($"Would you like to learn more about {NamesList[userStudentSelection - 1]} or add another student, \nenter (y) to learn more, (a) to add another student, or (q) to quit");
                string learnMoreOrAddStudent = Console.ReadLine().ToLower();
                if (learnMoreOrAddStudent == "y")
                {
                    continue;
                }
                else if (learnMoreOrAddStudent == "q")
                {
                    break;
                }


                else if (learnMoreOrAddStudent == "a")
                {
                    
                    Console.WriteLine("Enter a student's name: ");
                    string newName = Console.ReadLine();
                    while (!Regex.IsMatch(newName, "^[a-z A-Z]{2,}$"))
                    {
                        Console.WriteLine("Invalid: Letters only");
                        newName = Console.ReadLine();
                    }
                        NamesList.Add(newName);

                    Console.WriteLine($"Enter {newName}'s hometown");
                    string newHometown = Console.ReadLine();
                    HometownList.Add(newHometown);

                    Console.WriteLine($"Enter {newName}'s favorite food");
                    string newFood = Console.ReadLine();
                    FoodList.Add(newFood);

                    Console.WriteLine($"Enter {newName}'s favorite color");
                    string newColor = Console.ReadLine();
                    ColorList.Add(newColor);
                }
               
                else
                {
                    Console.WriteLine("You entered invalid data, try again");
                    
                }

                continue;
                    
                
            }
                     
                    
        }
                    
    }     
}

