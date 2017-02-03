using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca_eCommerce.Models
{
    public class BibliotecaContext: DbContext
    {
            public BibliotecaContext()
                : base("BibliotecaDbContext")
        {

        }
           public DbSet<autores> autor { get; set; } 
    }
}