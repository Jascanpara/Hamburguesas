using System;
namespace Hamburguesas.Models
{
    public interface IFood
    {
        int Precio { get; set; }
        string Pan { get; set; }
        string Salsa { get; set; }
        TamañoEnum Tamaño { get; set; }
        string Nombre { get; set; }
    }
}
