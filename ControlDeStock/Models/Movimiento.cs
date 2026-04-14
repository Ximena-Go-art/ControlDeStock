using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeStock.Models
{
    public class Movimiento
    {
        public string _id { get; set; }
        public int id_producto { get; set; }
        public string tipo_movimiento { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
