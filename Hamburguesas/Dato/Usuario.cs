using Hamburguesas.Models;
using System.Collections.Generic;

namespace Hamburguesas.Dato
{
    class Usuario
    {
        List<Hamburguesa> listaH = new List<Hamburguesa>();
        List<Baguette> listaB = new List<Baguette>();
        List<Sandwish> listaS = new List<Sandwish>();

        //Guardar los usuarios
        public void Guardar(Hamburguesa modeloH, Baguette modeloB, Sandwish modeloS)
        {
            if (modeloH!=null)
            listaH.Add(modeloH);
            if (modeloB != null)
                listaB.Add(modeloB);
            if (modeloS != null)
                listaS.Add(modeloS);
        }

        //Consulta todos los usuarios

        public List<Hamburguesa> ConsultarH()
        {
            return listaH;
        }
        public List<Baguette> ConsultarB()
        {
            return listaB;
        }
        public List<Sandwish> ConsultarS()
        {
            return listaS;
        }

        public void Limpiar()
        {
            listaH.Clear();
            listaB.Clear();
            listaS.Clear();
        }
    }
}
