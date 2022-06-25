using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ITipoConduccion
    {
        
            string ObtenerDescripcion();
            int ObtenerPotencia(float decilitrosCombustible);
            int ObtenerIncrementoVelocidad(float decilitrosCombustible);
        
    }
}
