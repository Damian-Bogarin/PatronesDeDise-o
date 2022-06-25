using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MotorElectricoAdapter : Motor
    {
        MotorElectrico motor = new MotorElectrico();
        public override void Acelerar()
        {
            motor.Mover();
        }

        public override void Arrancar()
        {
            motor.Conectar();
            motor.Activar();
        }

        public override void CargarCombustible()
        {
            motor.Enchufar();
        }

        public override void Detener()
        {
            motor.Desactivar();
            motor.Parar();
        }
    }
}
