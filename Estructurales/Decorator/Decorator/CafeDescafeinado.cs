using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 5;

        public override string Description => "Cafe descafeinado";
    }
}
