using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_UTH.Models;

namespace Sistema_UTH.Models
{
    public class Sistema_UTHContext : DbContext
    {
        public Sistema_UTHContext (DbContextOptions<Sistema_UTHContext> options)
            : base(options)
        {

        }

        public DbSet<Sistema_UTH.Models.Categoria> Categoria { get; set; }

        public DbSet<Sistema_UTH.Models.Estudiante> Alumno { get; set; }
    }
}