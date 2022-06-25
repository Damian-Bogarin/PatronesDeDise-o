using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BloodyMaryBuilder : CocktailBuilder
    {
        public BloodyMaryBuilder()
        {
            bebida = new Bebida("Bloody Mary", "Refrescante");
        }

        public override void BuildBebidaPrincipal()
        {
            bebida["principal"] = "Vodka";
        }

        public override void BuildBebidaSecundaria()
        {
            bebida["secundario"] = "Zumo de Tomate";
        }

        public override void BuildHielos()
        {
            bebida["hielo"] = "1 cubito";
        }

        public override void BuildAperitivo()
        {
            bebida["aperitivo"] = "1 pizca de sal y pimienta negra";
        }
    }
}
