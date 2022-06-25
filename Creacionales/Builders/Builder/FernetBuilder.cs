using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FernetBuilder : CocktailBuilder
    {
        public FernetBuilder()
        {
            bebida = new Bebida("Fernet", "Digestivo");
        }

        public override void BuildBebidaPrincipal()
        {
            bebida["principal"] = "Fernet Branca";
        }

        public override void BuildBebidaSecundaria()
        {
            bebida["secundario"] = "Coca Cola";
        }

        public override void BuildHielos()
        {
            bebida["hielo"] = "2 cubitos";
        }
        public override void BuildAperitivo()
        {
            bebida["aperitivo"] = "Ninguno";
        }
    }
}
