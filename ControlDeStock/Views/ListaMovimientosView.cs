using ControlDeStock.Models;
using ControlDeStock.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        string url = "https://basededatosprueba-43f2.restdb.io/rest/movimiento?apikey=0eb02941b4157bb3f6f863477b58795b87db6";

        MovimientoService movimientoService = new();
        List<Movimiento> movimiento = new();
        Movimiento? movimientoModificado;

        ProductoService productoService = new();
        List<Producto> productos = new();


        public ListaMovimientosView()
        {
            InitializeComponent();
            _ = ObtenemosLosMovimientos();
            _ = CargarLosProductos();
        }

        private async Task CargarLosProductos()
        {
            productos = await productoService.GetAllAsync() ?? new List<Producto>();

            CbProductos.DataSource = productos;
            CbProductos.DisplayMember = "nombre";
            CbProductos.ValueMember = "_id";
        }

        //--*-- Método para obtener los productos y mostrarlos en la grilla --*--//
        private async Task ObtenemosLosMovimientos()
        {

           movimiento = await movimientoService.GetAllAsync()
                             ?? new List<Movimiento>();
           GridMovimientosLista.DataSource = movimiento;

            CbMovimientos.Items.Add("Entrada");
            CbMovimientos.Items.Add("Salida");
            CbMovimientos.Items.Add("Devolucion");
            CbMovimientos.Items.Add("Encargue");

        }

        //--*-- Método para eliminar un producto seleccionado en la grilla --*--//
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GridMovimientosLista.RowCount > 0 &&
        GridMovimientosLista.SelectedRows.Count > 0)
            {
                Movimiento movimientoSeleccionado =
                    (Movimiento)GridMovimientosLista.SelectedRows[0].DataBoundItem;

                if (movimientoSeleccionado._id is null)
                {
                    MessageBox.Show("El movimiento no tiene un ID válido");
                    return;
                }

                var respuesta = MessageBox.Show(
                    "¿Desea eliminar este movimiento?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (await movimientoService.DeleteAsync(
                        movimientoSeleccionado._id))
                    {
                        MessageBox.Show("Movimiento eliminado correctamente");

                        await ObtenemosLosMovimientos();
                    }
                }
            }
        }

        //*--*-- Método para navegar a la pestaña de agregar/modificar producto --*--*/    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            TabGeneral.SelectTab("TabAgregarModificar");
            movimientoModificado = null;
        }

        private void LimpiarCampos()
        {
            CbProductos.SelectedIndex = -1;
            CbMovimientos.SelectedIndex = -1;
            NumCantidad.Value = 0;
            FechaMovimiento.Value = DateTime.Now;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CbProductos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            Movimiento movimientoAGuardar = new()
            {
                _id = movimientoModificado?._id,

                producto = CbProductos.SelectedValue?.ToString(),

                tipo_movimiento = CbMovimientos.Text,

                cantidad = (int)NumCantidad.Value,

                fecha = FechaMovimiento.Value
            };

            Producto productoSeleccionado =
                productos.FirstOrDefault(
                    p => p._id == movimientoAGuardar.producto);

            if (productoSeleccionado != null)
            {
                if (movimientoAGuardar.tipo_movimiento == "Entrada")
                {
                    productoSeleccionado.stock_actual += movimientoAGuardar.cantidad;
                }
                else if (movimientoAGuardar.tipo_movimiento == "Salida")
                {
                    if (productoSeleccionado.stock_actual < movimientoAGuardar.cantidad)
                    {
                        MessageBox.Show("Stock insuficiente");
                        return;
                    }

                    productoSeleccionado.stock_actual -= movimientoAGuardar.cantidad;
                }

                await productoService.UpdateAsync(productoSeleccionado);
            }

            bool response;

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
                MessageBox.Show("Movimiento guardado correctamente");

                await ObtenemosLosMovimientos();

                LimpiarCampos();

                TabGeneral.SelectTab("TabListaMovimientos");
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            TabGeneral.SelectTab("TabListaMovimientos");
            LimpiarCampos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridMovimientosLista.RowCount > 0 &&
        GridMovimientosLista.SelectedRows.Count > 0)
            {
                movimientoModificado =
                    (Movimiento)GridMovimientosLista.SelectedRows[0].DataBoundItem;

                CbProductos.SelectedValue =
                    movimientoModificado.producto;

                CbMovimientos.Text =
                    movimientoModificado.tipo_movimiento;

                NumCantidad.Value =
                    movimientoModificado.cantidad;

                FechaMovimiento.Value =
                    movimientoModificado.fecha;

                TabGeneral.SelectTab("TabAgregarModificar");
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un movimiento para modificar.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (movimiento == null) return;

            string filtro = TxtBuscar.Text.ToLowerInvariant();

            var movimientosFiltrados = movimiento
                .Where(m =>
                    (m.tipo_movimiento ?? "")
                    .ToLowerInvariant()
                    .Contains(filtro))
                .ToList();

            GridMovimientosLista.DataSource = movimientosFiltrados;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick(); // Simulamos un clic en el botón de búsqueda cada vez que el texto del campo de búsqueda cambie, para actualizar la grilla en tiempo real.
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerramos la ventana actual para salir de la aplicación.   
        }

    }

}