
using System.Collections.Generic;
using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public class H1 : HBiulder
    {
        public H1(TamañoEnum tamaño)
        {
            _Hamburguesa = new Hamburguesa
            {
                Tamaño = tamaño,
                Nombre = "CuatroQuesos",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararPan()
        {
            _Hamburguesa.Pan = "Integral";
        }

        public override void PasoAñadirSalsa()
        {
            _Hamburguesa.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _Hamburguesa.Relleno.Add("mozzarela");
            _Hamburguesa.Relleno.Add("gorgonzola");
            _Hamburguesa.Relleno.Add("parmesano");
            _Hamburguesa.Relleno.Add("ricotta");
        }
    }
}
