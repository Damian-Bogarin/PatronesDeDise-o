using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza(string pizza)
        {
            if (pizza == "napo")
            {
                return new PizzaNapolitana("argentina");
            }
            else if (pizza == "muzza")
            {
                return new PizzaDeMuzza("Argentina");
            }
            else return null;
        }
    }
}
