using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TeTradicional : BebidaComponent
    {
        public override double Costo => 20;

        public override string Description => "Te";
    }
}
