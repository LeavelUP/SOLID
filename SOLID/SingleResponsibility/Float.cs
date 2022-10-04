using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Float
    {
        public static void Square(string input)
        {
            float buffer = float.Parse(input);
            float output = buffer * buffer;
            Console.WriteLine($"\nYour number squared is: {output}\n");
        }
    }
}
