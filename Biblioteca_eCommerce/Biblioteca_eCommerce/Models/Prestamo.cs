using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class Prestamo
    {
        [Key]
        public int IdPrestamo { get; set; }
        public string Empleado { get; set; }
        public string Libro { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaPrest { get; set; }
        public DateTime FechaDevol { get; set; }
        public float MontoxDia { get; set; }
        public int cantDias { get; set; }
        public string Comentario { get; set; }
        public int estado { get; set; }
    }
}