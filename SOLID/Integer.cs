using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Integer : InputChecker
    {
        public static void Addition(string input)
        {
            if (Checker(input) == "int")
            {
                int buffer = int.Parse(input);
                int output = buffer + 2;
                Console.WriteLine($"\nYou number plus two is: {output}\n");
            }
        }
    }
}
