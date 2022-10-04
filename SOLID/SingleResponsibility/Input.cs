using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    public abstract class Input
    {
        public abstract object Process(string obj);
        public abstract bool Support(string type);
    }
}
