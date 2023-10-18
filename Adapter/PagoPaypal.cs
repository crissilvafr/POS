using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PagoPaypal: IPago
    {
        private readonly string _usuariopp;
        private readonly decimal _total;

        public PagoPaypal(string usuariopp, decimal total)
        {
            _usuariopp = usuariopp;
            _total = total;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pago de {_total} realizado con la cuenta: {_usuariopp}");
        }
    }
}
