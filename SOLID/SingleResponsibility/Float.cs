using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    public class Float : Input
    {
        public override object Process(string obj)
        {
            float buffer = float.Parse(obj);
            float output = buffer * buffer;
            return output;
        }

        public override bool Support(string type)
        {
            return type == "float";
        }
    }
}
