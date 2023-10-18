using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Decorator
{
    public interface IVenta
    {
        decimal CalcularTotal();
        List<Producto>ObtenerProductos();
    }
}
