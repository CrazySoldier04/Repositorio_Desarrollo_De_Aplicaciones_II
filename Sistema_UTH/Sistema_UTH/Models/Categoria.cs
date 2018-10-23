using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Sistema_UTH.Models
{
    public class Categoria
    {
        public int CategoriaId
        {
            get;
            set;
        }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la categoría debe contener mínimo 3 caracteres")]

        public string Nombre
        {
            get;
            set;
        }
        [StringLength(250)]

        public string Descripcion
        {
            get;
            set;
        }

        public Boolean Estado
        {
            get;
            set;
        }
    }
}