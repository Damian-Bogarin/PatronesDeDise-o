using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Bebida
    {
        private string _nombreBebida;
        private string _tipoBebida;
        private Dictionary<string, string> _contenido = new Dictionary<string, string>();

        public Bebida(string nombre, string tipo)
        {
            this._nombreBebida = nombre;
            this._tipoBebida = tipo;
        }

        public string this[string key]
        {
            get { return _contenido[key]; }
            set { _contenido[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("{0}:", _nombreBebida.ToUpper());
            Console.WriteLine("Tipo de bebida: {0}", _tipoBebida);
            Console.WriteLine(" Bebida principal : {0}", _contenido["principal"]);
            Console.WriteLine(" Bebida secundaria : {0}", _contenido["secundario"]);
            Console.WriteLine(" Hielo: {0}", _contenido["hielo"]);
            Console.WriteLine(" Aperitivo : {0}", _contenido["aperitivo"]);
        }
    }
}
