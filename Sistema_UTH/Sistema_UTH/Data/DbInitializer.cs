using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_UTH.Models;

namespace Sistema_UTH.Data
{
    public class DbInitializer
    {
        public static void Initialize(Sistema_UTHContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre = "Programación", Descripcion = "Clases con Alonso", Estado = true},
            new Categoria { Nombre = "Ingenieria de software", Descripcion = "Clases con Cheno", Estado = true },
            };
            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}