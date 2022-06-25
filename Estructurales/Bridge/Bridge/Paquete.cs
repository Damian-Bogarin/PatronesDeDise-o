using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Paquete
    {
        protected IMedioDeTransporte medioDeEntrega;

        public Paquete(IMedioDeTransporte medio)
        {
            this.medioDeEntrega = medio;
        }
        public abstract void entrega();
    }
}
