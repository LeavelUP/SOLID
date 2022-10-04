using System;
using System.Collections.Generic;
using System.Text;
using SOLID.SingleResponsibility;

namespace SOLID
{
    public class UserInterface
    {
        static string input = null;
        public readonly IInputFactory _inputFactory;
        public UserInterface(IInputFactory inputFactory)
        {
            _inputFactory = inputFactory;
        }

        public void GetInput()
        {
            bool loop = true;
            while (loop)
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

        private void UseInput(string input)
        {
            var inputType = Checker(input);
            var inputName = _inputFactory.GetInput(inputType);
            var output = inputName.Process(input);
            Console.WriteLine(output);
        }

        private string Checker(string input)
        {
            {
                if (int.TryParse(input, out int _))
                    return "int";
                else if (float.TryParse(input, out _))
                    return "float";
                else if (bool.TryParse(input, out _))
                    return "bool";
                else
                    return "string";
            }
        }
    }
}
