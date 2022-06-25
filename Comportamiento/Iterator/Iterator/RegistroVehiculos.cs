using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class RegistroVehiculos : IRegistroVehiculos
    {
        private ArrayList listaVehiculos;

        public RegistroVehiculos()
        {
            this.listaVehiculos = new ArrayList();
        }

        public void InsertarVehiculo(string marca, string modelo, double precio)
        {
            Vehiculo v = new Vehiculo(marca, modelo, DateTime.Now, precio);
            listaVehiculos.Add(v);
        }

        public Vehiculo MostrarInformacionVehiculo(int indice)
        {
            return (Vehiculo)listaVehiculos[indice];
        }

        public IIteratorVehiculo ObtenerIterator()
        {
            return new IteratorVehiculo(listaVehiculos);
        }
    }
}
