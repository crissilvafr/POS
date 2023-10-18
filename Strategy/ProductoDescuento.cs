namespace Strategy
{
    public class ProductoDescuento : IProductoDescuentoStrategy
    {
        public decimal CalcularDescuento(decimal precio)
        {
            return precio * 0.05m;
        }
    }
}
