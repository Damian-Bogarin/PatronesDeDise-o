using System;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Componente root = new Directorio("raiz");

            Componente archivo1 = new Archivo("archivo1", 10);
            Componente archivo2 = new Archivo("archivo2", 20);
            Componente archivo3 = new Archivo("archivo2", 30);
            Componente archivo4 = new Archivo("archivo3", 40);
            Componente archivo5 = new Archivo("archivo4", 50);

            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");

            dir1.AddChill(archivo1);
            dir2.AddChill(archivo2);
            dir3.AddChill(archivo3);
            dir3.AddChill(archivo4);

            dir1.AddChill(dir3);


            root.AddChill(dir1);
            root.AddChill(dir2);
            root.AddChill(archivo5);

            Console.WriteLine($"El tamaño del directorio {root.Name} es {root.GetTamaño}");
            Console.WriteLine($"El tamaño del directorio {dir1.Name}es {dir1.GetTamaño}");

            Console.WriteLine($"El tamaño del directorio {dir2.Name} se {dir2.GetTamaño}");
            Console.WriteLine($"El tamaño del directorio {dir3.Name} es {dir3.GetTamaño}");
        }
    }
}
