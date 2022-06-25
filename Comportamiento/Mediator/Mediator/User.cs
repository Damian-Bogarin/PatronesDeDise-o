using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class User
    {

        protected IMediator Mediator;
        protected string Name;

        public User(IMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);

        public string GetUserName() => Name;
    }
}
