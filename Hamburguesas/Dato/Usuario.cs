using Hamburguesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesas.Dato
{
    class Usuario
    {
        List<Hamburguesa> lista = new List<Hamburguesa>();

        //Guardar los usuarios
        public void Guardar(Hamburguesa modelo)
        {
            lista.Add(modelo);
        }

        //Consulta todos los usuarios

        public List<Hamburguesa> Consultar()
        {
            return lista;
        }

        public void Limpiar()
        {
            lista.Clear();
        }
    }
}
