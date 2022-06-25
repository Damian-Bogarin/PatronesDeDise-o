using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CocktailBuilder builder;
            Barman barman = new Barman();

            builder = new FernetBuilder();
            barman.Construct(builder);
            builder.Bebida.Show();

            builder = new BloodyMaryBuilder();
            barman.Construct(builder);
            builder.Bebida.Show();

            Console.ReadLine();
        }
    }
}
