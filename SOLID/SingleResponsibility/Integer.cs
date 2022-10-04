using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Integer
    {
        public static void Addition(string input)
        {
            int buffer = int.Parse(input);
            int output = buffer + 2;
            Console.WriteLine($"\nYour number plus two is: {output}\n");
        }
    }
}
