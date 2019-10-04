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
            switch (Aux)
            {
                case 1:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Nombre = "CuatroQuesos", Pan = "Integral", Salsa = "Roquefort", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 2:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Nombre = "Hawaiana", Pan = "Parmesano", Salsa = "Piña", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 3:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Nombre = "Integral", Pan = "Integral", Salsa = "Vegui", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 4:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.triple, Nombre = "Birrea", Pan = "Ajonjoli", Salsa = "Roja", Precio = 75};
                    Pago += ham.Precio;
                    break;
                case 5:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Nombre = "Caramelisada", Pan = "Oregano", Salsa = "Cebolla dulce", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 6:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.triple, Nombre = "Tradicional", Pan = "Tostado", Salsa = "Golf", Precio = 75};
                    Pago += ham.Precio;
                    break;
                case 7:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Nombre = "Wakamole", Pan = "Normal", Salsa = "Palta", Precio = 55};
                    Pago += ham.Precio;
                    break;
                case 8:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Nombre = "Punt de S", Pan = "Integral", Salsa = "Roquefort", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 9:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.doble, Nombre = "Wooper", Pan = "Normal", Salsa = "Cesar", Precio = 65};
                    Pago += ham.Precio;
                    break;
                case 10:
                    ham = new Hamburguesa { Tamaño = TamañoEnum.simple, Nombre = "Bacon", Pan = "Mantequilla", Salsa = "BBQ", Precio = 55, Relleno = new List<string>(new string[] { "mozzarela", "gorgonzola", "parmesano", "ricotta" }) };
                    Pago += ham.Precio;
                    break;

            }
            Dato.Guardar(ham);
        }
        private void Consultar()
        {
            foreach (var item in Dato.Consultar())
            {
                DataRow fila = Tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Pan"] = item.Pan;
                fila["Salsa"] = item.Salsa;
                //fila["Relleno"] = item.Relleno;
                fila["Precio"] = item.Precio;
                Tabla.Rows.Add(fila);
            }
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
            Dato.Limpiar();
            Tabla.Clear();
            grilla.DataSource = Tabla;
        }
    }
}
