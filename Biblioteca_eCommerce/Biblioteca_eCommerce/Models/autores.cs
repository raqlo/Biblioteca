using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class autores
    {
        [Key]
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Estado { get; set; }
    }
}