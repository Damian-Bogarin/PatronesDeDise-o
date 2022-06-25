using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class MuebleriaAntigua : Muebleria
    {
        public override Messa CrearMesa()
        {
            return new MesaAntigua();
        }

        public override Silla CrearSilla()
        {
            return new SillaAntigua();
        }
    }
}
