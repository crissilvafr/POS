using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Producto
    {
        private readonly IProductoDescuentoStrategy _strategy;


        public Producto(IProductoDescuentoStrategy strategy)
        { 
            _strategy = strategy;
        }

        public string? Descripcion { get; set; }
        public decimal Precio { get; set;}
        public decimal Descuento { get => CalcularDescuento(); }
        public decimal PrecioDeVenta { get => Precio - CalcularDescuento(); }
        public decimal CalcularDescuento()
        {
            return _strategy.CalcularDescuento(Precio);
        }
    }
}
