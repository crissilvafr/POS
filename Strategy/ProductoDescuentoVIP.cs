namespace Strategy
{
    public class ProductoDescuentoVIP : IProductoDescuentoStrategy
    {
        public decimal CalcularDescuento(decimal precio)
        {
            return precio * 0.2m;
        }
    }
}
