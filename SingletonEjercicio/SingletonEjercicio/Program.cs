﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventas.Instancia();
            Ventas.Instancia();
        }
    }
}