using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class InputChecker
    {
        public static string Checker(string input)
        {
            int a;
            float b;

            if (int.TryParse(input, out a))
                return "int";
            else if (float.TryParse(input, out b))
                return "float";
            else
                return "string";
        }
    }
}
