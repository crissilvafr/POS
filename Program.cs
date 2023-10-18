// See https://aka.ms/new-console-template for more information
using Adapter;
using Strategy;

Console.WriteLine("Welcome!");
Producto arduino = new Producto(new ProductoDescuentoVIP());
arduino.Descripcion = "Arduino UNO";
arduino.Precio = 250m;

Producto arduino2 = new Producto(new ProductoDescuentoVIP());
arduino2.Descripcion = "Arduino MEGA";
arduino2.Precio = 450m;

List<Producto> productos = new List<Producto>();
productos.Add(arduino);
productos.Add(arduino2);
Decorator.IVenta venta = new Decorator.Venta(productos);
decimal total = venta.CalcularTotal();
Console.WriteLine(venta);

Adapter.IPago pago = new Adapter.PagoPaypal("user0", total);
pago.Cobrar();