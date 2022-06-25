using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class MedioMiniFlete : IMedioDeTransporte
    {
        public void TiempoDeEntrega()
        {
            Console.WriteLine("Entrega al dia");
        }
    }
}
