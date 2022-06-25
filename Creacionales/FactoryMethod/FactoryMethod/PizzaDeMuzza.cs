using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PizzaDeMuzza : Pizza
    {
        public PizzaDeMuzza(string origin)
        {
            this._origin = origin;
            this._description = "Pizza de muzza";
        }
    }
}
