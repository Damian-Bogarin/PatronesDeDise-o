using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Archivo : Componente
    {
        int _tamaño;

        public override int GetTamaño
        {
            get
            {
                return _tamaño; 
            }
        }

        public Archivo(string nombre, int tamaño) : base(nombre)
        {
            _tamaño = tamaño;

        }

        public override void AddChill(Componente c)
        {
            
        }

        public override IList<Componente> GetChill()
        {
            return null;
        }
    }
}
