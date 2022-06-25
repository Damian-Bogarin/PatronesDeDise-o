using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Muebleria fabrica = new MuebleriaAntigua();

            Messa mesa = fabrica.CrearMesa();
            Silla silla = fabrica.CrearSilla();

            Console.WriteLine(mesa.Description);
            Console.WriteLine(silla.Description);

            fabrica = new MuebleriaModerna();
            mesa = fabrica.CrearMesa();
            silla = fabrica.CrearSilla();

            Console.WriteLine(mesa.Description);
            Console.WriteLine(silla.Description);

        }
    }
}
