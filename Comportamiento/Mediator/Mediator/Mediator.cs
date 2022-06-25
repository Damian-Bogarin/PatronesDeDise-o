using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private string _groupName = String.Empty;
        private List<User> _users = new List<User>();

        public Mediator(string groupName) => _groupName = groupName;

        public string GetGroupName() => _groupName;

        public void RegisterUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"\t{user.GetUserName()} (has joined to the group '{_groupName}'!)");
        }

        public void SendMessage(User user, string message)
        {
            foreach (var userGroup in _users)
                if (userGroup != user)
                    userGroup.Receive(message);
        }
    }
}
