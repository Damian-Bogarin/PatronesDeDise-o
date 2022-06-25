using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator("Patterns for C# Group");

            Console.WriteLine($"GROUP '{mediator.GetGroupName()}' CREATED!\n");

            User jorge = new ConcreteUser(mediator, "Jorge");
            User maria = new ConcreteUser(mediator, "María");
            User carlos = new ConcreteUser(mediator, "Carlos");

            mediator.RegisterUser(jorge);
            mediator.RegisterUser(maria);
            mediator.RegisterUser(carlos);

            Console.WriteLine();

            maria.Send("Hi all!");
            Console.WriteLine();
            carlos.Send("Wow!, I love this group!");
            Console.WriteLine();
            jorge.Send("Hi María and Carlos!");
        }
    }
}
