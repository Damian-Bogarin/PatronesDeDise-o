using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MotorElectrico
    {
        bool activo;
        bool conectado;
        bool movimiento;

        public void Conectar()
        {
            if (conectado)
            {
                Console.WriteLine("Imposible conectar, ya esta conectado");
            }
            else
            {
                conectado = true;
                Console.WriteLine("Motor conectado!"); 
            }
        }

        public void Activar()
        {
            if (!conectado)
            {
                Console.WriteLine("Imposible activar, no esta conectado");
            }
            else
            {
                activo = true;
                Console.WriteLine("Motor Activado!");
            }
        }
        public void Mover()
        {
            if(conectado && activo)
            {
                movimiento = true;
                Console.WriteLine("Moviendo motor electrico");
            }
            else
            {
                Console.WriteLine("El motor no esta conectado o activo");
            }
        }
        public void Parar()
        {
            if (movimiento)
            {
                movimiento = false;
                Console.WriteLine("Parando motor electrico");

            }
            else
            {
                Console.WriteLine("Imposible parar si no esta en movimiento");
            }
        }

        public void Descontar()
        {
            if (conectado)
            {
                Console.WriteLine("Motor electrico desconectado");
            }
            else
            {
                Console.WriteLine("El motor ya esta desconectado!");
            }
        }

        public void Desactivar() {
            if (conectado)
            {
                conectado = false;
                Console.WriteLine("Motor Desconectado");
            }
            else
            {
                
                Console.WriteLine("Motor ya esta desconectado!");
            }
        }

        public void Enchufar()
        {
            if (!activo)
            {
                activo=false;
                Console.WriteLine("Motor cargando");
            }
            else
            {
                Console.WriteLine("Imposible enchufar motor activo");
            }
        }

    }
}
