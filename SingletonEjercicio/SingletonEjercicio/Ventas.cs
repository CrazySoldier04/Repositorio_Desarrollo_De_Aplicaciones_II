using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEjercicio
{
    public class Ventas
    {
        private String _nombre_producto;
        private String _desc;
        private Double _precio;

        private static Ventas _venta = null;

        private Ventas()
        {

        }

        public static Ventas Instancia()
        {
            if (_venta == null)
            {
                _venta = new Ventas();
            }
            return _venta;
        }
    }
}