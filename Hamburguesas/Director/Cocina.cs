
using Hamburguesas.Models;
using Hamburguesas.Builders;

namespace Hamburguesas.Director
{
    public class Cocina
    {
        private HBiulder _hBuilder;

        public void RecepcionarProximaH(HBiulder pizzaBuilder)
        {
            _hBuilder = pizzaBuilder;
        }

        public void CocinarHamburguesaPasoAPaso()
        {
            _hBuilder.PasoPrepararProducto();
            _hBuilder.PasoPrepararPan();
            _hBuilder.PasoAñadirSalsa();
            _hBuilder.PasoPrepararRelleno();
        }

        public Hamburguesa PizzaPreparada => _hBuilder.ObtenerHamburguesa();

        public Hamburguesa CocinarPizza(HBiulder hBuilder)
        {
            hBuilder.PasoPrepararProducto();
            hBuilder.PasoPrepararPan();
            hBuilder.PasoAñadirSalsa();
            hBuilder.PasoPrepararRelleno();
            return hBuilder.ObtenerHamburguesa();
        }
    }
}
