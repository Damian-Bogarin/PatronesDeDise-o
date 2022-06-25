using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad
{
    internal class BlueHandler : Handler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Color == "Blue")
                Console.WriteLine($"{this.GetType().Name} approved request {request.Code} as {request.Color}");
            else
                Console.WriteLine($"{this.GetType().Name} denied {request.Code} as {request.Color}");
        }
    }
}
