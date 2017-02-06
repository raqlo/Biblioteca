using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string laborTanda { get; set; }
        public int porcientoComision { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }
        public  int Estado { get; set; }
    }
}   