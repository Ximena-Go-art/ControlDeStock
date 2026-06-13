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
        Producto? productoModificado;

        public ListaMovimientosView()
        {
            InitializeComponent();
            ObtenemosLosMovimientos();
            //CargarLosProductos();
        }

        //--*-- Método para obtener los productos y mostrarlos en la grilla --*--//
        private async Task ObtenemosLosMovimientos()
        {
            movimiento = await movimientoService.GetAllAsync() ?? new List<Movimiento>();
            GridMovimientosLista.DataSource = movimiento;
        }



        //--*-- Método para eliminar un producto seleccionado en la grilla --*--//
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //--*-- Controlamos que haya productos en la grilla y que se haya seleccionado al menos una fila antes de intentar eliminar. --*--//
            if (GridMovimientosLista.RowCount > 0 &&
        GridMovimientosLista.SelectedRows.Count > 0)
            {
                Movimiento movimientoSeleccionado =
                    (Movimiento)GridMovimientosLista.SelectedRows[0].DataBoundItem;

                if (movimientoSeleccionado._id is null)
                {
                    MessageBox.Show(
                        "El movimiento no tiene un identificador válido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var respuesta = MessageBox.Show(
                    "¿Desea eliminar este movimiento?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (await movimientoService.DeleteAsync(movimientoSeleccionado._id))
                    {
                        MessageBox.Show(
                            "Movimiento eliminado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        await ObtenemosLosMovimientos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Error al eliminar el movimiento.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
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
            CbProductos.SelectedIndex = -1;
            CbMovimientos.SelectedIndex = -1;
            NumCantidad.Value = 0;
            FechaMovimiento.Value = DateTime.Now;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CbProductos.SelectedItem is not Producto productoSeleccionado)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Movimiento movimientoAGuardar = new()
            {
                _id = movimientoModificado?._id,
                id_producto = productoSeleccionado,
                tipo_movimiento = CbMovimientos.Text,
                cantidad = (int)NumCantidad.Value,
                fecha = FechaMovimiento.Value
            };

            switch (CbMovimientos.Text)
            {
                case "Entrada":
                    productoSeleccionado.stock_actual += movimientoAGuardar.cantidad;
                    break;

                case "Salida":
                    if (productoSeleccionado.stock_actual < movimientoAGuardar.cantidad)
                    {
                        MessageBox.Show("No hay stock suficiente para realizar la salida.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    productoSeleccionado.stock_actual -= movimientoAGuardar.cantidad;
                    break;
            }

            await productoService.UpdateAsync(productoSeleccionado);


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
                MessageBox.Show("Movimiento guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ObtenemosLosMovimientos(); // Llamamos al método para obtener los productos y mostrar la grilla actualizada.
                LimpiarCampos();
                TabGeneral.SelectTab("TabListaMovimientos"); // Volvemos a la pestaña de lista de productos después de guardar.
            }
            else
            {
                MessageBox.Show("Error al agregar el movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                CbProductos.SelectedValue = movimientoModificado.id_producto;
                CbMovimientos.Text = movimientoModificado.tipo_movimiento;
                NumCantidad.Value = movimientoModificado.cantidad;
                FechaMovimiento.Value = movimientoModificado.fecha;

                TabGeneral.SelectTab("TabAgregarModificar");
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un movimiento para modificar.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (movimiento == null) return;

            string filtro = TxtBuscar.Text.ToLower();

            var movimientosFiltrados = movimiento
                .Where(m =>
                    (m.tipo_movimiento ?? "")
                    .ToLower()
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

        //---- Método para cargar los tipos en el ComboBox ----//
        private void CargarTiposDeMovimiento()
        {
            // 1. Creamos la lista con los tipos de movimientos fijos.
            /*List<Movimiento> listaMovimientos = new List<Movimiento>()
                {
                        new Movimiento { _id = 1, tipo_movimiento = "Entrada" },
                        new Movimiento { _id = 2, tipo_movimiento = "Salida" },
                        new Movimiento { _id = 3, tipo_movimiento = "Ajuste de Stock" }
                };

            // 2. Asignamos la lista al ComboBox "CbMovimientos".
            CbMovimientos.DataSource = null;
            CbMovimientos.DataSource = listaMovimientos;

            // 3. Configuramos qué se muestra y qué es el valor interno.
            CbMovimientos.DisplayMember = "tipo_movimiento";
            CbMovimientos.ValueMember = "_id";

            // 4. Opcional: Dejamos el ComboBox sin selección inicial.
            CbMovimientos.SelectedIndex = -1;
        }

            //---- Evento para manejar el cambio de selección en el ComboBox ----//
                private void CbMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validamos que exista una selección para evitar errores.
            if (CbMovimientos.SelectedIndex == -1) return;

            // Obtenemos el objeto completo seleccionado.
            if (CbMovimientos.SelectedItem is Movimiento movimientoSeleccionado)
            {
                int idSeleccionado = movimientoSeleccionado._id;
                string nombreSeleccionado = movimientoSeleccionado.tipo_movimiento;

                // TODO: Aquí puedes utilizar los valores obtenidos (idSeleccionado y nombreSeleccionado)
                // para la lógica que necesites, como ajustar el stock o mostrar/ocultar controles.*/
        }

    }

}