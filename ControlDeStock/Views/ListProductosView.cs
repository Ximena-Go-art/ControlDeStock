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
        string url = "https://basededatosprueba-43f2.restdb.io/rest/producto?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
        ProductoService productoService = new();
        List<Producto> productos = new();
        Producto productoModificado;
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

                //--*-- Validamos que el _id no sea nulo antes de continuar --*--//
                if (productoSeleccionado._id is null)
                {
                    MessageBox.Show("El producto seleccionado no tiene un identificador válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        //*--*-- Método para navegar a la pestaña de agregar/modificar producto --*--*/    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            TabGeneral.SelectTab("TabAgregarModificar");
            productoModificado = null; // Reiniciamos la variable para indicar que no estamos modificando ningún producto.
        }

        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtCategoria.Clear();
            NumPrecio.Value = 0;
            NumStockActual.Value = 0;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto productoAGuardar = new()
            {
                _id = productoModificado._id,
                nombre = TxtNombre.Text,
                categoria = TxtCategoria.Text,
                presio = (int)NumPrecio.Value,
                stock_actual = (int)NumStockActual.Value
            };

            bool response;// Variable para almacenar la respuesta de la operación de guardado (agregar o modificar).

            if (productoModificado != null)
            {
                response = await productoService.UpdateAsync(productoAGuardar);

            }
            else
            {
                response = await productoService.AddAsync(productoAGuardar);
            }
            if (response) 
            {
                MessageBox.Show("Producto guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ObtenemosLosProductos(); // Llamamos al método para obtener los productos y mostrar la grilla actualizada.
                LimpiarCampos();
                TabGeneral.SelectTab("TabListaProductos"); // Volvemos a la pestaña de lista de productos después de guardar.
            }
            else
            {
                MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            TabGeneral.SelectTab("TabListaProductos");
            LimpiarCampos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridProductosList.RowCount > 0 && GridProductosList.SelectedRows.Count > 0)
            {
                //*--*-- Obtenemos el producto seleccionado de la grilla para modificarlo. --*--*/
                productoModificado = (Producto)GridProductosList.SelectedRows[0].DataBoundItem;//
                TxtNombre.Text = productoModificado.nombre;
                TxtCategoria.Text = productoModificado.categoria;
                NumPrecio.Value = productoModificado.presio;
                NumStockActual.Value = productoModificado.stock_actual;
                TabGeneral.SelectTab("TabAgregarModificar");

            }
            else
            {
                //*--*-- Si no se ha seleccionado ningún producto, mostramos un mensaje de error. --*--*/
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "No se ha seleccionado ningún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}



    




