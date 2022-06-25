using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Barman
    {
        public void Construct(CocktailBuilder cocktailBuilder)
        {
            cocktailBuilder.BuildBebidaPrincipal();
            cocktailBuilder.BuildBebidaSecundaria();
            cocktailBuilder.BuildHielos();
            cocktailBuilder.BuildAperitivo();
        }
    }
}
