using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Decorator
{
    public class Venta : IVenta
    {
        private List<Producto> _productos = new List<Producto>();
        public Venta(List<Producto> productos)
        {
            _productos = productos;
        }

        public Venta():this(new List<Producto>())
        {
            
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach(Producto producto in _productos)
            {
                total += producto.Precio;
            }
            
            return total;
        }

        public List<Producto> ObtenerProductos()
        {
            return _productos;
        }

        public override string ToString() =>
            $"El total de la venta es {CalcularTotal():N2}";
    }
}
