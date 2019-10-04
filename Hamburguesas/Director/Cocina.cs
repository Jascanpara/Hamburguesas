
using Hamburguesas.Models;
using Hamburguesas.Builders;

namespace Hamburguesas.Director
{
    public class Cocina
    {
        private HBiulder _HBuilder;

        public void RecepcionarProximaHamburguesa(HBiulder HBuilder)
        {
            _HBuilder = HBuilder;
        }

        public void CocinarHamburguesaPasoAPaso()
        {
            _HBuilder.PasoPrepararPan();
            _HBuilder.PasoAñadirSalsa();
            _HBuilder.PasoPrepararRelleno();
        }

        public Hamburguesa HPreparada => _HBuilder.ObtenerHamburguesa();

        public Hamburguesa CocinarHamburguesa(HBiulder HBuilder)
        {
            HBuilder.PasoPrepararPan();
            HBuilder.PasoAñadirSalsa();
            HBuilder.PasoPrepararRelleno();
            return HBuilder.ObtenerHamburguesa();
        }
    }
}
