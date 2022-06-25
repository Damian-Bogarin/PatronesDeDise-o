using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class CheckFacade
    {
        private AvionAPI avionApi;
        private HotealApi hotealApi;

        public CheckFacade()
        {
            avionApi = new AvionAPI();
            hotealApi = new HotealApi();
        }

        public void buscar(string fechaIda,string fechaVuelta, string origen, string destino)
        {
            avionApi.BuscarVuelo(fechaIda, fechaVuelta, origen, destino); 
            hotealApi.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
        }
    }
}
