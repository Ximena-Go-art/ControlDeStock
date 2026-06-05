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
    public partial class ListaMovimientosView : Form
    {
        //--*-- Instanciamos los campos para su uso general --*--//
        HttpClient clientHttp = new();
        string url = "https://basededatosprueba-43f2.restdb.io/rest/movimientosstock?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
        MovimientoService movimientoService = new();
        List<Movimiento> movimiento;
        
        Movimiento movimientoModificado;

        public ListaMovimientosView()
        {
            InitializeComponent();
            _ = ObtenemosLosMovimientos();
        }

        //--*-- Método para obtener los productos y mostrarlos en la grilla --*--//
        private async Task ObtenemosLosMovimientos()
        {
            movimiento = await movimientoService.GetAllAsync() ?? new List<Movimiento>();
            GridMovimientosLista.DataSource = movimiento;
            //Obtener la lista de productos para llenar el ComboBox de selección de producto al agregar o modificar un movimiento.
            ProductoService productoService = new();
        }

        //--*-- Método para eliminar un producto seleccionado en la grilla --*--//
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //--*-- Controlamos que haya productos en la grilla y que se haya seleccionado al menos una fila antes de intentar eliminar. --*--//
            if (GridMovimientosLista.RowCount > 0 && GridMovimientosLista.SelectedRows.Count > 0)
            {
                //--*-- Obtenemos el producto seleccionado de la grilla.--*--//
                Movimiento movimientoSeleccionado = (Movimiento)GridMovimientosLista.SelectedRows[0].DataBoundItem;

                //--*-- Validamos que el _id no sea nulo antes de continuar --*--//
                if (movimientoSeleccionado._id is null)
                {
                    MessageBox.Show("El movimiento seleccionado no tiene un identificador válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //--*-- Mostramos un mensaje de confirmación antes de eliminar el producto.--*--//
                var respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar este movimiento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //--*-- Si el usuario confirma la eliminación, procedemos a eliminar el producto. --*--//
                    if (await movimientoService.DeleteAsync(movimientoSeleccionado._id))
                    {
                        MessageBox.Show("Movimiento eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await ObtenemosLosMovimientos(); // Llamamos al método para obtener los productos y mostrar la grilla actualizada.
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un movimiento para eliminar.", "No se ha seleccionado ningún movimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //*--*-- Método para navegar a la pestaña de agregar/modificar producto --*--*/    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            TabGeneral.SelectTab("TabAgregarModificar");
            movimientoModificado = null; // Reiniciamos la variable para indicar que no estamos modificando ningún producto.
        }

        private void LimpiarCampos()
        {
            /*TxtNombre.Clear();
            TxtCategoria.Clear();
            NumPrecio.Value = 0;
            NumStockActual.Value = 0;*/

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*
            Movimiento movimientoAGuardar = new()
            {
                _id = movimientoModificado?._id ?? null,
                producto = (Producto)CbProducto.SelectedItem,
                tipo_movimiento = CbTipoMovimiento.SelectedItem?.ToString(),
                cantidad = (int)NumCantidad.Value,
                fecha = DateTime.Now // Aquí podrías asignar la fecha actual o permitir que el usuario seleccione una fecha al agregar o modificar un movimiento.
            };
            

            bool response;// Variable para almacenar la respuesta de la operación de guardado (agregar o modificar).

            if (movimientoModificado != null)
            {
                response = await movimientoService.UpdateAsync(movimientoAGuardar);

            }
            else
            {
                response = await movimientoService.AddAsync(movimientoAGuardar);
            }
            if (response)
            {
                MessageBox.Show("Producto guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ObtenemosLosMovimientos(); // Llamamos al método para obtener los productos y mostrar la grilla actualizada.
                LimpiarCampos();
                TabGeneral.SelectTab("TabListaMovimientos");// Volvemos a la pestaña de lista de movimientos después de guardar el producto.
            }
            else
            {
                MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }


        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            TabGeneral.SelectTab("TabListaProductos");
            LimpiarCampos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridMovimientosLista.RowCount > 0 && GridMovimientosLista.SelectedRows.Count > 0)
            {
                //*--*-- Obtenemos el producto seleccionado de la grilla para modificarlo. --*--*/
                //movimientoModificado = (Movimiento)GridMovimientosLista.SelectedRows[0].DataBoundItem;//
                /*TxtNombre.Text = productoModificado.nombre;
                TxtCategoria.Text = productoModificado.categoria;
                NumPrecio.Value = productoModificado.presio;
                NumStockActual.Value = productoModificado.stock_actual;
                TabGeneral.SelectTab("TabAgregarModificar");*/

            }
            else
            {
                //*--*-- Si no se ha seleccionado ningún producto, mostramos un mensaje de error. --*--*/
               // MessageBox.Show("Por favor, seleccione un movimiento para modificar.", "No se ha seleccionado ningún movimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            /*if (movimiento == null) return;

            string filtro = TxtBuscar.Text.ToLowerInvariant();
            var movimientosFiltrados = movimiento
                .Where(m => (m.tipo_movimiento ?? "").ToLowerInvariant().Contains(filtro)
                .ToString().Contains(filtro));
            GridMovimientosLista.DataSource = movimientosFiltrados;*/
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //BtnBuscar.PerformClick(); // Simulamos un clic en el botón de búsqueda cada vez que el texto del campo de búsqueda cambie, para actualizar la grilla en tiempo real.
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerramos la ventana actual para salir de la aplicación.   
        }
    }
}



    

































































































































































































