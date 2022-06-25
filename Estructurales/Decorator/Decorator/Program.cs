using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafe = new CafeSolo();

            cafe = new Leche(cafe);
            cafe = new Azucar(cafe);

            BebidaComponent cafeDescafeinado = new CafeDescafeinado();

            cafeDescafeinado = new Azucar(cafeDescafeinado);

            Console.WriteLine($"Producto: {cafe.Description} tiene un costo de : {cafe.Costo}");
            Console.WriteLine($"Producto: {cafeDescafeinado.Description} tiene un costo de : {cafeDescafeinado.Costo}");
        }
    }
}
