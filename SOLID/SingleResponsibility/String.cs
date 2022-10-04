using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    public class String : Input
    {
        public override object Process(string obj)
        {
            string output = obj + obj;
            return output;
        }

        public override bool Support(string type)
        {
            return type == "string";
        }
    }
}
