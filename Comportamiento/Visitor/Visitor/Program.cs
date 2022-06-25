using System;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new VistanteConcreto();

            Componente dr = new DiscoRigido("155151514DDs-DR");

            Componente pb = new PlacaBase("asdasdasdqwe125-PB");
            Componente p = new Procesador("654654546-P");


            dr.Aceptar(visitor);
            dr.Aceptar(visitor);
            pb.Aceptar(visitor);
        }
    }
}
