using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    public interface IInputFactory
    {
        Input GetInput(string type);
    }
}
