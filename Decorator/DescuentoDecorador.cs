using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DescuentoDecorador : VentaDecorador
    {
        private decimal _porcentajeDescuento;
        public DescuentoDecorador(IVenta venta, decimal porcentajeDescuento) : base(venta)
        {
            _porcentajeDescuento = porcentajeDescuento;
        }

        public override decimal CalcularTotal()
        { 
            decimal totalBase = base.CalcularTotal();
            decimal descuento = totalBase * (_porcentajeDescuento / 100);
            return totalBase - descuento;
        }

        public override string ToString()
        {
            return $"El total de la venta con descuento es {CalcularTotal():N2}";
        }
    }

}
