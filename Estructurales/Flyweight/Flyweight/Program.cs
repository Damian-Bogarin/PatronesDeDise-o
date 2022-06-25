using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensalada = new List<int>();

            List<int> Rapidas = new List<int>();

            FlyweightFactory factory = new FlyweightFactory();

            i = factory.AddFlyweight("Hamburguesa");

            Americana.Add(i);
            Carnes.Add(i);
            Rapidas.Add(i);

            i = factory.AddFlyweight("Wisconsin cheese");
            Americana.Add(i);
            Ensalada.Add(i);

            i = factory.AddFlyweight("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = factory.AddFlyweight("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapidas.Add(i);


            i = factory.AddFlyweight("Coditos");
            Mexicana.Add(i);
            Rapidas.Add(i);


            i = factory.AddFlyweight("Nopales");
            Mexicana.Add(i);
            Ensalada.Add(i);

            i = factory.AddFlyweight("Pizza");
            Italiana.Add(i);
            Rapidas.Add(i);

            //Mostramos y llevamos a cabo el proceso en la comida rapida

            foreach(int n in Italiana)
            {
                CReceta receta = (CReceta)factory[n];
                receta.CalcularCosto();
                receta.Mostrar();
            }

            Console.WriteLine("----");


        }
    }
}
