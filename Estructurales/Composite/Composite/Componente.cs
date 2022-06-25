using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Componente
    {
        string _nombre;

        public Componente(string nombre)
        {
            _nombre = nombre;
        }

        public string Name { get { return _nombre; } }
        public abstract void AddChill(Componente c);

        public abstract  IList<Componente> GetChill();

        public abstract int GetTamaño { get; }
    }
}
