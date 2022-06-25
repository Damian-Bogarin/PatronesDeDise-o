using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class PaqueteFragil : Paquete
    {
        public PaqueteFragil(IMedioDeTransporte medio) : base(medio)
        {

        }

        public override void entrega()
        {
            Console.WriteLine("Estoy entregando un paquete Fragil ");
            this.medioDeEntrega.TiempoDeEntrega();
        }
    }
}
