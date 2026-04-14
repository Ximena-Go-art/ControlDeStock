using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeStock.Models
{
    public class Producto
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public int presio { get; set; }
        public int stock_actual { get; set; }
    }
}
