using Hamburguesas.Models;

namespace Hamburguesas.Builders
{
    public abstract class BBiulder 
    {
        // Protected para que las clases que implementen puedan acceder
        protected Baguette _baguette;

        public string Tamaño { get; set; }

        public Baguette ObtenerHamburguesa() { return _baguette; }

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

        public virtual void PasoMontarBaguette()
        {

        }

    }
}
