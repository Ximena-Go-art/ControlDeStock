using ControlDeStock.Models;
using ControlDeStock.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeStock.Views
{
    public partial class ListProductosView : Form
    {
        //--*-- Instanciamos los campos para su uso general --*--//
        HttpClient clientHttp = new();
        string url = "https://basededatosprueba-43f2.restdb.io/rest/productos?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
        ProductoService productoService = new();
        List<Producto> productos = new();
        public ListProductosView()
        {
            InitializeComponent();
            ObtenemosLosProductos();
        }

        //--*-- Método para obtener los productos y mostrarlos en la grilla --*--//
        private async Task ObtenemosLosProductos()
        {
            GridProductosList.DataSource = await productoService.GetAllAsync();
             
        }

        //--*-- Método para eliminar un producto seleccionado en la grilla --*--//
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //--*-- Controlamos que haya productos en la grilla y que se haya seleccionado al menos una fila antes de intentar eliminar. --*--//
            if (GridProductosList.RowCount > 0 && GridProductosList.SelectedRows.Count > 0)
            {
                //--*-- Obtenemos el producto seleccionado de la grilla.--*--//
                Producto productoSeleccionado = (Producto)GridProductosList.SelectedRows[0].DataBoundItem;

                //--*-- Mostramos un mensaje de confirmación antes de eliminar el producto.--*--//
                var respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar {productoSeleccionado.nombre}", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes) 
                {
                    //--*-- Si el usuario confirma la eliminación, procedemos a eliminar el producto. --*--//
                    if (await productoService.DeleteAsync(productoSeleccionado._id))
                    { 
                        MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await ObtenemosLosProductos(); // Llamamos al método para obtener los productos y mostrar la grilla actualizada.
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "No se ha seleccionado ningún producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
