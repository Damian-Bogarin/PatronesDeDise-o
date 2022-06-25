using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class CReceta : IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        public void CalcularCosto()
        {
            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 1.30;
        }

        public void ColocaNombre(string pNombre)
        {
            nombre = pNombre;
        }

        public string GetName()
        {
            return nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine($"{nombre} cuesta {venta}");
        }
    }
}
