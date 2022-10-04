using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class UserInterface : IChecker
    {
        static string input = null;
        //string inputChecker = new UserInterface();

        public static void GetInput()
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Enter an Integer, Decimal, or String to continue:");
                input = Console.ReadLine();

                UseInput(input);

                Console.WriteLine("\nWould you like to enter another input? (y/n)");
                string toggle = Console.ReadLine();
                if (toggle == "Y" || toggle == "y")
                    loop = true;
                else
                    loop = false;
            }
        }

        private static void UseInput(string input)
        {
            IChecker inputChecker = new UserInterface();

            if (inputChecker.Checker(input) == "int")
            {
                Integer.Addition(input);
            }
            else if (inputChecker.Checker(input) == "float")
            {
                Float.Square(input);
            }
            else if (inputChecker.Checker(input) == "string")
            {
                String.Duplicate(input);
            }
            else
                Console.WriteLine($"Unable to parse {input}");
        }

        string IChecker.Checker(string input)
        {
            {
                if (int.TryParse(input, out int _))
                    return "int";
                else if (float.TryParse(input, out _))
                    return "float";
                else
                    return "string";
            }
        }
    }
}
