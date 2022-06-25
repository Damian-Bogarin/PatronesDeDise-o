using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string _description;  
        protected string _origin;

        public void Render()
        {
            Console.WriteLine($"pizza de {_description} hecha en {_origin}");
        }
    }
}
