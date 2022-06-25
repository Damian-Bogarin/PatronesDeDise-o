using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorDiesel diesel = new MotorDiesel();
            diesel.Arrancar();
            diesel.Acelerar();
            diesel.Detener();
            diesel.CargarCombustible();

            MotorNafta nafta = new MotorNafta();
            nafta.Arrancar();
            nafta.Acelerar();
            nafta.Detener();
            nafta.CargarCombustible();

            MotorElectricoAdapter electrico = new MotorElectricoAdapter();
            electrico.Arrancar();
            electrico.Acelerar();
            electrico.Detener();
            electrico.CargarCombustible();


        }
    }
}
