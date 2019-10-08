using Hamburguesas.Builders;
using Hamburguesas.Director;
using Hamburguesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburguesas
{
    public partial class Form1 : Form
    {        
        int Aux = 0;
        int Pago = 0;
        DataTable Tabla;
        Dato.Usuario Dato = new Dato.Usuario();
        public Form1()
        {
            InitializeComponent();
            button1.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H6.jpg");
            button2.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H7.jpg");
            button3.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H2.jpg");
            button4.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H8.jpg");
            button5.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H9.jpg");
            button6.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H1.jpg");
            button7.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H3.jpg");
            button8.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H4.jpg");
            button9.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H5.jpg");
            button10.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\H10.jpg");
            button11.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\B1.jpg");
            button12.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\B2.jpg");
            button13.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\B3.jpg");
            button14.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\B4.jpg");
            button15.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\B5.jpg");
            button16.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\S1.jpg");
            button17.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\S2.jpg");
            button18.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\S3.jpg");
            button19.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\S4.jpg");
            button20.BackgroundImage = Image.FromFile(@"C:\Users\SEARS\Music\6to semestre\Patrones de Diseño\Patrones de diseño\Hamburguesas\Hamburguesas\Imagenes\S5.jpg");
            Iniciar();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Aux = 1;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Aux = 2;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Aux = 3;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Aux = 4;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Aux = 5;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Aux = 6;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Aux = 7;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Aux = 8;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Aux = 9;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Aux = 10;
            Guardar();
            Iniciar();
            Consultar();
        }
        private void Iniciar()
        {
            lPagar.Text = Pago.ToString();
            Tabla = new DataTable();
            Tabla.Columns.Add("Producto");
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Pan");
            Tabla.Columns.Add("Salsa");
            //Tabla.Columns.Add("Relleno");
            Tabla.Columns.Add("Precio");
            //Tabla.Columns.Add("Eliminar");
            grilla.DataSource = Tabla;
        }
        private void Guardar()
        {
            var cocina = new Cocina();
            Hamburguesa ham = null;
            Sandwish san = null;
            Baguette bag = null;
            switch (Aux)
            {
                case 1:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Producto="Hamburguesa", Nombre = "CuatroQuesos", Pan = "Integral", Salsa = "Roquefort", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 2:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Producto = "Hamburguesa", Nombre = "Hawaiana", Pan = "Parmesano", Salsa = "Piña", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 3:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Producto = "Hamburguesa", Nombre = "Integral", Pan = "Integral", Salsa = "Vegui", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 4:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.triple, Producto = "Hamburguesa", Nombre = "Birrea", Pan = "Ajonjoli", Salsa = "Roja", Precio = 75};
                    Pago += ham.Precio;
                    break;
                case 5:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Producto = "Hamburguesa", Nombre = "Caramelisada", Pan = "Oregano", Salsa = "Cebolla dulce", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 6:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.triple, Producto = "Hamburguesa", Nombre = "Tradicional", Pan = "Tostado", Salsa = "Golf", Precio = 75};
                    Pago += ham.Precio;
                    break;
                case 7:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Producto = "Hamburguesa", Nombre = "Wakamole", Pan = "Normal", Salsa = "Palta", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 8:
                    ham = new Hamburguesa{ Tamaño = TamañoEnum.doble, Producto = "Hamburguesa", Nombre = "Punt de S", Pan = "Integral", Salsa = "Roquefort", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 9:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Producto = "Hamburguesa", Nombre = "Wooper", Pan = "Normal", Salsa = "Cesar", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 10:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Producto = "Hamburguesa", Nombre = "Bacon", Pan = "Mantequilla", Salsa = "BBQ", Precio = 55, Relleno = new List<string>(new string[] { "mozzarela", "gorgonzola", "parmesano", "ricotta" }) };
                    Pago += ham.Precio;
                    break;
                case 11:
                    bag = new Baguette { Tamaño = TamañoEnum.simple, Producto = "Baguette", Nombre = "CuatroQuesos", Pan = "Integral", Salsa = "Roquefort", Precio = 55 };
                    Pago += bag.Precio;
                    break;
                case 12:
                    bag = new Baguette { Tamaño = TamañoEnum.doble, Producto = "Baguette", Nombre = "Hawaiana", Pan = "Parmesano", Salsa = "Piña", Precio = 65 };
                    Pago += bag.Precio;
                    break;
                case 13:
                    bag = new Baguette { Tamaño = TamañoEnum.simple, Producto = "Baguette", Nombre = "Integral", Pan = "Integral", Salsa = "Vegui", Precio = 55 };
                    Pago += bag.Precio;
                    break;
                case 14:
                    bag = new Baguette { Tamaño = TamañoEnum.triple, Producto = "Baguette", Nombre = "Birrea", Pan = "Ajonjoli", Salsa = "Roja", Precio = 75 };
                    Pago += bag.Precio;
                    break;
                case 15:
                    bag = new Baguette { Tamaño = TamañoEnum.doble, Producto = "Baguette", Nombre = "Caramelisada", Pan = "Oregano", Salsa = "Cebolla dulce", Precio = 65 };
                    Pago += bag.Precio;
                    break;
                case 16:
                    san = new Sandwish { Tamaño = TamañoEnum.triple, Producto = "Sandwish", Nombre = "Tradicional", Pan = "Tostado", Salsa = "Golf", Precio = 75 };
                    Pago += san.Precio;
                    break;
                case 17:
                    san = new Sandwish { Tamaño = TamañoEnum.simple, Producto = "Sandwish", Nombre = "Wakamole", Pan = "Normal", Salsa = "Palta", Precio = 55 };
                    Pago += san.Precio;
                    break;
                case 18:
                    san = new Sandwish { Tamaño = TamañoEnum.doble, Producto = "Sandwish", Nombre = "Punt de S", Pan = "Integral", Salsa = "Roquefort", Precio = 65 };
                    Pago += san.Precio;
                    break;
                case 19:
                    san = new Sandwish { Tamaño = TamañoEnum.doble, Producto = "Sandwish", Nombre = "Wooper", Pan = "Normal", Salsa = "Cesar", Precio = 65 };
                    Pago += san.Precio;
                    break;
                case 20:
                    san = new Sandwish { Tamaño = TamañoEnum.simple, Producto = "Sandwish", Nombre = "Bacon", Pan = "Mantequilla", Salsa = "BBQ", Precio = 55, Relleno = new List<string>(new string[] { "mozzarela", "gorgonzola", "parmesano", "ricotta" }) };
                    Pago += san.Precio;
                    break;
            }
            Dato.Guardar(ham,bag,san);
        }
        private void Consultar()
        {
            if (Aux < 11)
            {
                foreach (var item in Dato.ConsultarH())
                {
                    DataRow fila = Tabla.NewRow();
                    fila["Producto"] = item.Producto;
                    fila["Nombre"] = item.Nombre;
                    fila["Pan"] = item.Pan;
                    fila["Salsa"] = item.Salsa;
                    //fila["Relleno"] = item.Relleno;
                    fila["Precio"] = item.Precio;
                    Tabla.Rows.Add(fila);
                }
            }
            else if (Aux < 16)
            {
                foreach (var item in Dato.ConsultarB())
                {
                    DataRow fila = Tabla.NewRow();
                    fila["Producto"] = item.Producto;
                    fila["Nombre"] = item.Nombre;
                    fila["Pan"] = item.Pan;
                    fila["Salsa"] = item.Salsa;
                    //fila["Relleno"] = item.Relleno;
                    fila["Precio"] = item.Precio;
                    Tabla.Rows.Add(fila);
                }
            }
            else
            {
                foreach (var item in Dato.ConsultarS())
                {
                    DataRow fila = Tabla.NewRow();
                    fila["Producto"] = item.Producto;
                    fila["Nombre"] = item.Nombre;
                    fila["Pan"] = item.Pan;
                    fila["Salsa"] = item.Salsa;
                    //fila["Relleno"] = item.Relleno;
                    fila["Precio"] = item.Precio;
                    Tabla.Rows.Add(fila);
                }
            }
            Aux = 0;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            //grilla.DataSource = null;
            limpiar();
            
        }

        private void LPagar_Click(object sender, EventArgs e)
        {
            
        }

        private void limpiar()
        {
            Pago = 0;
            lPagar.Text = Pago.ToString();
            Dato.Limpiar();
            Tabla.Clear();
            grilla.DataSource = Tabla;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Aux = 11;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Aux = 12;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Aux = 13;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Aux = 14;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Aux = 15;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Aux = 16;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Aux = 17;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Aux = 18;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Aux = 19;
            Guardar();
            Iniciar();
            Consultar();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Aux = 20;
            Guardar();
            Iniciar();
            Consultar();
        }
    }
}
