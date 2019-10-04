using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public abstract class HBiulder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Hamburguesa _Hamburguesa;

        public string Tamaño { get; set; }

        public Hamburguesa ObtenerHamburguesa() { return _Hamburguesa; }

        // Un paso para cada una de las propiedades
        public virtual void PasoPrepararPan()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoMontarHamburguesa()
        {

        }

    }
}
