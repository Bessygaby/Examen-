using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace BessyMartinez
{
    public partial class FormularioDescuento : Form
    {
        private readonly string nombreProducto;
        private readonly string precio;
        private readonly object totalLabel;
        private double total;

        public FormularioDescuento()
        {
            InitializeComponent();
        }

        private void FormularioDescuento_Load(object sender, EventArgs e)
        {
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public double PrecioUnitario { get; set; }

            public Producto(string nombre, double precioUnitario)
            {
                Nombre = nombre;
                PrecioUnitario = precioUnitario;
            }
        }

        private async void calcularButton_Click(object sender, EventArgs e)
        {
            // Obtener los productos y sus precios unitarios
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("Producto 1", 100));
            productos.Add(new Producto("Producto 2", 200));
            productos.Add(new Producto("Producto 3", 300));

            // Calcular el descuento
            double total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.PrecioUnitario;
            }
            await Task.Delay(2000); // Simular un proceso que tarda 2 segundos
            double descuento = total * 0.15;
            double totalConDescuento = total - descuento;

            // Mostrar el resultado
            resultadoLabel.Text = string.Format("Total: {0:C}\nDescuento: {1:C}\nTotal a pagar: {2:C}", total, descuento, totalConDescuento);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un nombre de producto y un precio unitario válido.
            if (string.IsNullOrWhiteSpace(productoTextBox.Text) || !double.TryParse(precioTextBox.Text, out double precio))
            {
                MessageBox.Show("Ingrese un nombre de producto y un precio unitario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Añadir el producto y el precio unitario a la lista de productos.
            listaProductosListBox.Items.Add(string.Format("{0} - {1:C}", productoTextBox.Text, precio));

            // Sumar el precio del producto al total.
            total += precio;
            string v = string.Format("Total: {0:C}", total);
           

            // Limpiar los campos de entrada.
            productoTextBox.Text = "";
            precioTextBox.Text = "";
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            // Obtener el índice del elemento seleccionado
            int indiceSeleccionado = listaProductosListBox.SelectedIndex;

            // Verificar si hay un elemento seleccionado
            if (indiceSeleccionado != -1)
            {
                // Remover el elemento de la lista
                listaProductosListBox.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void listaProductosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaProductosListBox.Items.Add("Producto: " + nombreProducto + " - Precio: " + precio);
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(precioTextBox.Text);
        }
    }
    }
