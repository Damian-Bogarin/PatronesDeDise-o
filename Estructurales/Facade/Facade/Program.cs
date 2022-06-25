using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckFacade cliente1 = new CheckFacade();
            cliente1.buscar("05/12/2022", "01/01/2023", "Argentina", "Miami");

            CheckFacade cliente2 = new CheckFacade();
            cliente1.buscar("10/01/2023", "01/02/2023", "Argentina", "Alemania");

        }
    }
}
