using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace SOLID.SingleResponsibility
{
    public class InputFactory : IInputFactory
    {
        public readonly IServiceProvider _serviceProvider;
        public InputFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public Input GetInput(string type)
        {
            var services = _serviceProvider.GetServices<Input>();
            Input input = null;
            foreach(Input item in services)
            {
                if (item.Support(type)) { input = item;
                    break;
                }
            }
            return input;
        }
    }
}
