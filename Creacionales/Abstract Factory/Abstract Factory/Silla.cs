using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal abstract class Silla
    {
        protected string _description;

        public string Description
        {
            get { return _description; }
        }
    }
}
