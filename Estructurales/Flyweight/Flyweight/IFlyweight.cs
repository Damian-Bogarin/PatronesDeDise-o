﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal interface IFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalcularCosto();
        void Mostrar();
        string GetName();
    }
}
