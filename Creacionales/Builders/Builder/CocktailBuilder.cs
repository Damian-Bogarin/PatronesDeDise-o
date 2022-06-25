using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class CocktailBuilder
    {
        protected Bebida bebida;

        public Bebida Bebida
        {
            get { return bebida; }
        }

        public abstract void BuildBebidaPrincipal();
        public abstract void BuildBebidaSecundaria();
        public abstract void BuildHielos();
        public abstract void BuildAperitivo();
    }
}
