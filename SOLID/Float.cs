using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Float : InputChecker
    {
        public static void Square(string input)
        {
            if (Checker(input) == "float")
            {
                float buffer = float.Parse(input);
                float output = buffer * buffer;
                Console.WriteLine($"\nYou number squared is: {output}\n");
            }
        }
    }
}
