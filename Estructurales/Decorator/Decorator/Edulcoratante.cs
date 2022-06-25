using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Edulcoratante : AgregadoDecorator
    {
        public Edulcoratante(BebidaComponent bebida) : base(bebida) { }



        public override double Costo => _bebida.Costo + 2;

        public override string Description => String.Format($"{_bebida.Description}, edulcorante");
    }
}
