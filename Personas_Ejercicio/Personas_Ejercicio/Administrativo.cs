using System;
using System.Collections.Generic;
using System.Text;

namespace Personas_Ejercicio
{
    class Administrativo : Persona
    {
        public string Entrada;
        public string Salida;
        public enum Puesto {Recepcionista, Ventas, Compras }

        public bool Nuevo()
        {
            bool res = false;
            return res;
        }

        public bool Modificar()
        {
            bool res = false;
            return res;
        }

        public Administrativo Consulta()
        {
            return ;
        }
    }
}
