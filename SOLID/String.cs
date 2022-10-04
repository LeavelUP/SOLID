using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class String : InputChecker
    {
        public static void Duplicate(string input)
        {
            if (Checker(input) == "string")
            {
                string output = input + input;
                Console.WriteLine($"\nYour String duplicated is: {output}\n");
            }
        }
    }
}
