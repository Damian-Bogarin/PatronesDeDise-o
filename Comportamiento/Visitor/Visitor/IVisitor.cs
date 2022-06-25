using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        void Visitar(Procesador componente);


        void Visitar(PlacaBase componente);


        void Visitar(DiscoRigido componente); 
       
    }
}
