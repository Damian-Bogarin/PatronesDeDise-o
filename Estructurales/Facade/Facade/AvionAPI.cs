using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class AvionAPI
    {
        public void BuscarVuelo(string fechaIda, string fechaRegreso, string origen, string destino){

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Vuelos encontrados para {destino} desde {origen}");
            Console.WriteLine($"Fecha IDA:{ fechaIda} y Fecha REGRESO: {fechaRegreso}");
            Console.WriteLine("-----------------------");
        }
    }
}
