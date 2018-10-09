using System;
using System.Collections.Generic;
using System.Text;

namespace Personas_Ejercicio
{
    class Persona
    {
        protected String nombre;
        protected String numEmpleado;
        protected String celular;
        public String correo;
        protected String curp;
        protected String rfc;

        public bool Nuevo()
        {
            bool res = false;
            return res;
        }

        public bool Modificar(String nom, String numEm, String cel, String mail, String cur, String rf)
        {
            bool res = false;
            return res;
        }

        public bool Borrar (String numEmpl)
        {
            bool res = false;
            return res;
        }
    }
}
