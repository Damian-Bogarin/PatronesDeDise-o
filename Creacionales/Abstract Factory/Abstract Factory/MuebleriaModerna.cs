using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class MuebleriaModerna : Muebleria
    {
        public override Messa CrearMesa()
        {
            return new MesaModerna();
        }

        public override Silla CrearSilla()
        {
            return new SillaModerna();
        }
    }
}
