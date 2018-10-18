using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ORM
{
    public class RegularExpressions
    {
        static Regex reg;

        public static bool NumerosEnteros(String campo)
        {
            reg = new Regex("[0-9]$");
            return reg.IsMatch(campo);
        }
    }
}
