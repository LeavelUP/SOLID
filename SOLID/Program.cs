using System;
using Microsoft.Extensions.DependencyInjection;
using SOLID.SingleResponsibility;

namespace SOLID
{
    class Program
    {
        static void Main()
        {
            //setup our IoC/DI container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInputFactory, InputFactory>()
                .AddSingleton<UserInterface, UserInterface>()
                .AddSingleton<Input, Float>()
                .AddSingleton<Input, Integer>()
                .AddSingleton<Input, SOLID.SingleResponsibility.String>()
                .AddSingleton<Input, Bool>()
            .BuildServiceProvider();

            Console.WriteLine("Hello!");
            var userInterface = serviceProvider.GetService<UserInterface>();
            userInterface.GetInput();
        }
    }
}
