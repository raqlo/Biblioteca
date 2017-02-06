using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class Editora
    {
        [Key]
        public int IdEditoras { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
    }
}