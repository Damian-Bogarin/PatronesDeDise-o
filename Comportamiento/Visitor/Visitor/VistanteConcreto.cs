using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class VistanteConcreto : IVisitor
    {
        public void Visitar(Procesador componente)
        {
            Console.WriteLine(String.Format($"Procesador {componente.Serial}"));
        }

        public void Visitar(PlacaBase componente)
        {
            Console.WriteLine(String.Format($"Placa base {componente.Serial}"));
        }

        public void Visitar(DiscoRigido componente)
        {
            Console.WriteLine(String.Format($"Disco Rigido {componente.Serial}"));
        }
    }
}
