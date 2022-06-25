using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            oAnimal.Rasgos = new Detalles();
            oAnimal.Rasgos.Color = "Blanca";
            oAnimal.Rasgos.Raza = "Oveja";

            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.Rasgos.Color = "Multicolor";
            oAnimalClonado.Nombre = "Oveja Multicolor";

            Console.WriteLine("animal original: " + oAnimal.Rasgos.Color);
            Console.WriteLine("annimal clonado: " + oAnimalClonado.Rasgos.Color);
            Console.WriteLine("animal original: " + oAnimal.Nombre);
            Console.WriteLine("animal clonado: " + oAnimalClonado.Nombre);
        }
    }
}
