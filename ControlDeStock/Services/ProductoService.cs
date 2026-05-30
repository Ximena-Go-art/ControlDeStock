using ControlDeStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControlDeStock.Services
{
    public class ProductoService
    {
        string url = "https://basededatosprueba-43f2.restdb.io/rest/producto?apikey=0eb02941b4157bb3f6f863477b58795b87db6";


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
        public async Task<bool> DeleteAsync(string _id)
        {
            // 1. Usamos la URL correcta apuntando al producto específico con su ID
            string url = $"https://basededatosprueba-43f2.restdb.io/rest/producto/{_id}?apikey=0eb02941b4157bb3f6f863477b58795b87db6";
            using (HttpClient client = new HttpClient())
            {
                // 2. Realizamos la petición
                var respuesta = await client.DeleteAsync(url);
                // 3. Verificamos si realmente fue exitoso
                if (respuesta.IsSuccessStatusCode)
                {
                    return true; // SÍ se eliminó
                }
                else
                {
                    // Opcional: mostrar qué error dio la API para ayudarte a depurar
                    string errorDetalle = await respuesta.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar. Respuesta API: {errorDetalle}");
                }
            }
        }
        public async Task<bool> UpdateAsync(Producto nuevoProducto)
        {   // Método para crear un nuevo producto

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, nuevoProducto);
                if (response.IsSuccessStatusCode)
                {
                    return true; // Producto creado exitosamente
                }
                else
                {
                    string errorDetalle = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear el producto. Respuesta API: {errorDetalle}");
                }
            }
        }
        public async Task<bool> AddAsync(Producto producto)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, producto);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la pelicula");
                }
            }
        }
    }
}
