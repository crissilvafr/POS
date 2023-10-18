namespace Decorator
{
    public class CargoDecorador : VentaDecorador
    {
        private decimal _importeCargo;
        public CargoDecorador(IVenta venta, decimal importeCargo) : base(venta)
        {
            _importeCargo = importeCargo;
        }

        public override decimal CalcularTotal()
        {
            decimal total = base.CalcularTotal();
            return total + _importeCargo;
        }

        public override string ToString()
        {
            return $"El total de la venta con cargo es: {CalcularTotal():N2}";
        }
    }
}