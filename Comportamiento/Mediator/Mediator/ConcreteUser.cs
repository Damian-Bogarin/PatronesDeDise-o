using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IMediator mediator, string name) : base(mediator, name) { }

        public override void Receive(string message) =>
            Console.WriteLine($"\t{Name} (Received Message) > {message}");

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} (Sending Message) > {message}\n");
            Mediator.SendMessage(this, message);
        }
    }
}
