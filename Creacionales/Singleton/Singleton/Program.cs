using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);


            Singleton.Instance.mensaje = "Acabo de cambiar el Singleton para todos sin tener que instanciarlo de nuevo!";

            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
