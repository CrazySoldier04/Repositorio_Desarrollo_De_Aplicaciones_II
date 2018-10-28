using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Sistema_UTH.Models
{
    public class Estudiante
    {
        public int EstudianteId
        {
            get;
            set;
        }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del estudiante debe contener mínimo 3 caracteres")]

        public string Nombre
        {
            get;
            set;
        }
        [StringLength(250)]

        public string ApellidoPaterno
        {
            get;
            set;
        }
        [StringLength(250)]

        public Boolean ApellidoMaterno
        {
            get;
            set;
        }
    }
}
