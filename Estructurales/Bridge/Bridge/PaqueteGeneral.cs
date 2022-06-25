using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class PaqueteGeneral : Paquete
    {
        public PaqueteGeneral(IMedioDeTransporte medio) : base(medio)
        {

        }
        public override void entrega()
        {
            Console.WriteLine("Estoy entregando un paquete general");
            this.medioDeEntrega.TiempoDeEntrega();
        }
    }
}
