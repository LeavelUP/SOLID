using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility
{
    public class Bool : Input
    {
        public override object Process(string obj)
        {
            return obj == "true";
        }

        public override bool Support(string type)
        {
            return type == "bool";
        }
    }
}
