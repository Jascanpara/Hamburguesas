using System.Collections.Generic;
using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public class B1 : BBiulder
    {
        public B1(TamañoEnum tamaño)
        {
            _baguette = new Baguette
            {
                Tamaño = tamaño,
                Nombre = "CuatroQuesos",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararPan()
        {
            _baguette.Pan = "Integral";
        }

        public override void PasoAñadirSalsa()
        {
            _baguette.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _baguette.Relleno.Add("mozzarela");
            _baguette.Relleno.Add("gorgonzola");
            _baguette.Relleno.Add("parmesano");
            _baguette.Relleno.Add("ricotta");
        }
    }
}
