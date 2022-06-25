using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class FlyweightFactory
    {
        private List<IFlyweight> flyweightList = new List<IFlyweight>();

        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int AddFlyweight(string pNombre)
        {
            bool existe = false;
            foreach (IFlyweight flyweight in flyweightList)
            {
                if (flyweight.GetName() == pNombre)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(pNombre);
                flyweightList.Add(miReceta);
                conteo = flyweightList.Count;
                return -1;
            }
        }
        //indexer
        public IFlyweight this[int index]
        {
            get { return flyweightList[index]; }
        }
    }
}
