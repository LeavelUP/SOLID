using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class UserInterface : InputChecker
    {
        static string input = null;

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
            if (Checker(input) == "int")
            {
                Integer.Addition(input);
            }
            else if (Checker(input) == "float")
            {
                Float.Square(input);
            }
            else if (Checker(input) == "string")
            {
                String.Duplicate(input);
            }
            else
                Console.WriteLine($"Unable to parse {input}");
        }
    }
}
