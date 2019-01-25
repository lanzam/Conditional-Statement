/* Author: Mariel Lanza
   Date: 01/23/2019
   Comments: Class Project - Conditional Statement. This C# Console application demonstrates the use 
             of the Conditional SWITCH statement to determine the a letter grade based on the syllabus
             grading policy.
*/
using System;

namespace GradeVer._2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Ask the user for input
            Console.WriteLine("What grade do you expect get in ISM 4300? Please enter your grade (integer value)... ");

            /* The TRY + CATCH block will verify user input
               CATCH will handle bad input and will display an error message
            */
            try
            {
                // This variable will gather the user input 
                string input = Console.ReadLine();
                // This variable will Parsed the user input to an integer
                int grade = int.Parse(input);

                /* Conditional SWITCH statement will be executed to output different grades
                   depending on the integer value entered for grade
                */
                switch (grade) 
                {
                    /* Variable "value" will be used to determine their grade.
                       Used *when* to specify a condition for the variable.
                    */
                    case int value when value <= 60:  
                        Console.WriteLine("Grade: F");
                        Console.ReadKey(true);
                        break; // *break* Terminate if the statement is true
                    case int value when value == 61:
                        Console.WriteLine("Grade: D-");
                        Console.ReadKey(true);
                        break;
                    case int value when value >= 62 && value <= 67:
                        Console.WriteLine("Grade: D");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 68 || value == 69:
                        Console.WriteLine("Grade: D+");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 70 || value == 71:
                        Console.WriteLine("Grade: C-");
                        Console.ReadKey(true);
                        break;
                    case int value when value >= 72 && value <= 77:
                        Console.WriteLine("Grade: C");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 78 || value == 79:
                        Console.WriteLine("Grade: C+");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 80 || value == 81:
                        Console.WriteLine("Grade: B-");
                        Console.ReadKey(true);
                        break;
                    case int value when value >= 82 && value <= 87:
                        Console.WriteLine("Grade: B");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 88 || value == 89:
                        Console.WriteLine("Grade: B+");
                        Console.ReadKey(true);
                        break;
                    case int value when value == 90 || value == 91:
                        Console.WriteLine("Grade: A-");
                        Console.ReadKey(true);
                        break;
                    case int value when value >= 92 && value <= 97:
                        Console.WriteLine("Grade: A");
                        Console.ReadKey(true);
                        break;
                    case int value when value >= 98 && value <= 100:
                        Console.WriteLine("Grade: A+");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Please enter your score between 1 and 100 (integer value). Please try again...");
                        Console.ReadKey(true);
                        break;
                } // End of SWITCH
            } // End of TRY
            catch
            {
                Console.WriteLine("Please enter a valid integer number ranging from 0 to 100");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of CATCH                  
        } // End of MAIN
    } // End of CLASS
} // End of NAMESPACE
