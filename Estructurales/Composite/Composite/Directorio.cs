using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Directorio : Componente
    {
        private List<Componente> _hijos;

        public Directorio(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }
        public override int GetTamaño
        {
            get
            {
                int t = 0;
                foreach (var item in _hijos)
                {
                    t += item.GetTamaño;
                }
                return t;
            }
        }

        public override void AddChill(Componente c)
        {
           _hijos.Add(c);
        }

        public override IList<Componente> GetChill()
        {
            return _hijos.ToArray();
        }
    }
}
