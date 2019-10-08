﻿using System;
using System.Collections.Generic;
using Hamburguesas.Builders;

namespace Hamburguesas.Models
{
    public class Hamburguesa: IFood
    {
        public int Precio { get; set; }
        public string Pan { get; set; }
        public string Salsa { get; set; }
        public List<string> Relleno { get; set; }
        public TamañoEnum Tamaño { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }

        public Hamburguesa()
        {

        }

        public Hamburguesa(TamañoEnum tamaño,int precio, string pan, string producto, string salsa, List<string> relleno)
        //: this() //contructor manda a llamar al contructor base
        {
            Producto = producto;
            Tamaño = tamaño;
            Precio = precio;
            Pan = pan;
            Salsa = salsa;
            Relleno = relleno;
        }

        public override string ToString()
        {
            return $"Producto: {Producto},Hamburguesa: {Nombre} / Tamaño: {Tamaño}, Pan: {Pan}, Salsa: {Salsa}, Relleno: {string.Join("+", Relleno)}";
        }

        public static implicit operator Hamburguesa(HBiulder v)
        {
            throw new NotImplementedException();
        }
    }
}
