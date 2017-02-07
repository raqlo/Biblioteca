using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.Prestamo = new HashSet<Prestamo>();
        }
        [Key]
        public int IdUsuarios { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar una matricula")]
        public int Matricula { get; set; }
        [Required(ErrorMessage = "Debe especificar que tipo de persona es")]
        public string tipoPersona { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}