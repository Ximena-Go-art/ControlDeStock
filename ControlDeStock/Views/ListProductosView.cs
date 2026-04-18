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
        HttpClient clientHttp = new();
        string url = "https://basededatosprueba-43f2.restdb.io/rest/productos?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
        ProductoService productoService = new();
        List<Producto> productos = new List<Producto>();
        public ListProductosView()
        {
            InitializeComponent();
            ObtenemosLosProductos();
        }
        private async void ObtenemosLosProductos()
        {
            GridProductosList.DataSource = await productoService.GetAllAsync();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Chequemaos si se ha seleccionado un producto
            if (GridProductosList.RowCount > 0 && GridProductosList.SelectedRows.Count > 0)
            {
                Producto productoSeleccionado = (Producto)GridProductosList.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar {productoSeleccionado.nombre}", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                { 
                    if (await productoService.DeleteAsync(productoSeleccionado._id))
                    { 
                        MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosLosProductos(); // Actualizamos la lista de productos después de eliminar
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
