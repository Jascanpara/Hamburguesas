using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public abstract class SBiulder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Sandwish _sandwish;

        public string Tamaño { get; set; }

        public Sandwish ObtenerHamburguesa() { return _sandwish; }

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

        public virtual void PasoMontarSandwish()
        {

        }

    }
}
