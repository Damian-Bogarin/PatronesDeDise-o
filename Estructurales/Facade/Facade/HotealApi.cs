using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HotealApi
    {
        public void buscarHoteles(string fechaEntrada,string fechaSalida, string origen, string destino)
        {
            Console.WriteLine($"---------------");
            Console.WriteLine($"Hoteles encontrados:");
            Console.WriteLine($"Ingreso: {fechaEntrada}");
            Console.WriteLine($"Salida: {fechaSalida}");
            Console.WriteLine($"Hotel A");
            Console.WriteLine($"Hotel B");
            Console.WriteLine($"Hotel C");
            Console.WriteLine($"---------------");
        }
    }
}
