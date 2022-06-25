using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad
{
    public class Request
    {
        public Request(string code, string color)
        {
            Code = code;
            Color = color;
        }

        public string Code { get; set; }
        public string Color { get; set; }
    }
}
