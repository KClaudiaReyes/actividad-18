class Program
{
    static void Main(string[] args)
    {
        Producto producto = new Producto();
        Console.WriteLine(producto.Precio);
    }

    public class Producto
    {
        private double precio;

        public double Precio
        {
            get {  return precio; }
            set { if (value > 0)
                    precio  = value;}
        } 
    }
}