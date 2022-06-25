using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConsoleObserver : IObserver
    {
        public void Update(SubjectEvent subjectEvent)
        {
            Console.WriteLine("An event just happened!");
            Console.WriteLine("Event type: " + subjectEvent.EventType);
            Console.WriteLine("Date: " + subjectEvent.EventDate);
        }
    }
}
