using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class String
    {
        public static void Duplicate(string input)
        {
            string output = input + input;
            Console.WriteLine($"\nYour String duplicated is: {output}\n");
        }
    }
}
