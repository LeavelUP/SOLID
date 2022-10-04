﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    public class Integer : Input
    {
        public override object Process(string obj)
        {
            int buffer = int.Parse(obj);
            int output = buffer + 2;
            return output;
        }

        public override bool Support(string type)
        {
            return type == "int";
        }
    }
}
