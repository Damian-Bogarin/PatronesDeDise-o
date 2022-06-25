using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class MedioCamion : IMedioDeTransporte
    {
        public void TiempoDeEntrega()
        {
            Console.WriteLine("El tiempo de entrega es de 3 dias");
        }
    }
}
