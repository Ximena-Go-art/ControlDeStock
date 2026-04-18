using ControlDeStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeStock.Services
{
    public class ProductoService
    {
        string url = "https://basededatosprueba-43f2.restdb.io/rest/productos?apikey=0eb02941b4157bb3f6f863477b58795b87db6";


        public async Task<List<Producto>?> GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Producto>>();
                }
                else
                {
                    throw new Exception("Error al obtener las peliculas");
                }
            }
        }
        public async Task<bool> DeleteAsync( string _id)
        {
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.DeleteAsync(url);
                if (!respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else               
                {
                    throw new Exception("Error al eliminar el producto");
                }
            }
        }
    }
}
