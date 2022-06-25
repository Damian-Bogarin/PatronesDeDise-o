using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {

        private static Singleton instance = null;

        public string mensaje = "";

        private Singleton()
        {
            mensaje = "Hola, soy un Singleton";
        }

        public static Singleton Instance
        {
            get {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance; 
            }

        }
    }
}
