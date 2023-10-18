using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Ventas
    {
        private readonly IPago _pago;
        public Ventas(IPago pago)
        {
            _pago = pago;
        }

        public void ProcesarPago()
        {
            _pago.Cobrar();
        }
    }
}
