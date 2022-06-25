using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            Pizza pizza;

            pizzeria = new PizzeriaArgentina();

            pizza = pizzeria.CrearPizza("napo");
            pizza.Render();

            pizza = pizzeria.CrearPizza("muzza");
            pizza.Render();



            pizzeria = new PizzeriaItaliana();


            pizza = pizzeria.CrearPizza("napo");
            pizza.Render();

            pizza = pizzeria.CrearPizza("muzza");
            pizza.Render();
        }
    }
}
