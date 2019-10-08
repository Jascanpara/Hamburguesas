using System.Collections.Generic;
using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public class S1 : SBiulder
    {
        public S1(TamañoEnum tamaño)
        {
            _sandwish = new Sandwish
            {
                Tamaño = tamaño,
                Nombre = "CuatroQuesos",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararPan()
        {
            _sandwish.Pan = "Integral";
        }

        public override void PasoAñadirSalsa()
        {
            _sandwish.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _sandwish.Relleno.Add("mozzarela");
            _sandwish.Relleno.Add("gorgonzola");
            _sandwish.Relleno.Add("parmesano");
            _sandwish.Relleno.Add("ricotta");
        }
    }
}
