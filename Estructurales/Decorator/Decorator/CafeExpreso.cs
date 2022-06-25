using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CafeExpreso : BebidaComponent
    {

        public override double Costo => 15;

        public override string Description => "Cafe Expreso";
    }
}
