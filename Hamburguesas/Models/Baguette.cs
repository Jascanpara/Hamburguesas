using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesas.Models
{
    public class Baguette : IFood
    {
        public int Precio { get; set; }
        public string Pan { get; set; }
        public string Salsa { get; set; }
        public List<string> Relleno { get; set; }
        public TamañoEnum Tamaño { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }

        public Baguette()
        {

        }

        public Baguette(TamañoEnum tamaño, int precio, string pan, string salsa, List<string> relleno)
        //: this() //contructor manda a llamar al contructor base
        {
            Tamaño = tamaño;
            Precio = precio;
            Pan = pan;
            Salsa = salsa;
            Relleno = relleno;
        }

        public override string ToString()
        {
            return $"Hamburguesa: {Nombre} / Tamaño: {Tamaño}, Pan: {Pan}, Salsa: {Salsa}, Relleno: {string.Join("+", Relleno)}";
        }
    }
}
