using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Decorator
{
    
    public abstract class VentaDecorador : IVenta
    {
        protected IVenta _venta;
        protected VentaDecorador(IVenta venta) 
        {
            _venta = venta;
        }
        public virtual decimal CalcularTotal()
        {
            return _venta.CalcularTotal();
        }

        public virtual List<Producto> ObtenerProductos()
        {
            return _venta.ObtenerProductos();
        }
    }
}
