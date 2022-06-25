using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paquete mipaquete = new PaqueteGeneral(new MedioCamion());
            mipaquete.entrega();

            Paquete fragil = new PaqueteFragil(new MedioMiniFlete() );
            fragil.entrega();

        }
    }
}
