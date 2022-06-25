using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza(string pizza)
        {
            if (pizza == "napo")
            {
                return new PizzaNapolitana("Italia");
            }
            else if (pizza == "muzza")
            {
                return new PizzaDeMuzza("Italia");
            }
            else
            {
                return null;
            }
        }
    }
}
