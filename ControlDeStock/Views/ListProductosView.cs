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
        HttpClient clientHttp = new HttpClient();
        string url = "https://basededatosprueba-43f2.restdb.io/rest/productos?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
        ProductoService productoService = new ProductoService();
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
    }
}
