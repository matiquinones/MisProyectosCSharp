namespace POS
{


    abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Valor { get; set; }

        public string Categoria { get; set; }

        public string Codigo { get; set; }

        public decimal Impuesto { get; set; }




        public Producto(string nombre, decimal precio, string categoria, string codigo, decimal impuesto)
        {
            this.Nombre = nombre;
            this.Valor = precio;
            this.Categoria = categoria;
            this.Codigo = codigo;
            this.Impuesto = impuesto;
        }

        public abstract decimal CalcularPrecioFinal();

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Producto: {Nombre}, Valor: {Valor:C}, Categoria: {Categoria}, Codigo: {Codigo}, Impuesto: {Impuesto}");
        }
    }


    class Libro : Producto
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Libro(string nombre, decimal precio, string categoria, string codigo, decimal impuesto, string autor, int numeropaginas) : base(nombre, precio, categoria, codigo, impuesto)
        {
            this.Autor = autor;
            this.NumeroPaginas = numeropaginas;
        }

        public override decimal CalcularPrecioFinal()
        {
            decimal descuento = 0.1m;
            decimal precioConDescuento = this.Valor - (this.Valor * descuento);

            return precioConDescuento + (precioConDescuento*this.Impuesto); 
        }


        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Autor: {Autor}, Paginas: {NumeroPaginas}, Precio Final: {CalcularPrecioFinal():C}");
        }
    }


    class Computadora : Producto 
    { 
    
        public string Marca { get; set; }
        public string Procesador { get; set; }

        public int RAM { get; set; }




        public Computadora(string nombre, decimal precio, string categoria, string codigo, decimal impuesto, string marca, string procesador, int ram) : base(nombre, precio, categoria, codigo, impuesto)
        {
            this.Marca= marca;
            this.RAM = ram;
            this.Procesador= procesador;
        }

        public override decimal CalcularPrecioFinal() 
        {
            return this.Valor + (this.Valor * this.Impuesto);
            
        }


        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Marca: {Marca}, procesador: {Procesador}, RAM: {RAM}");
        
        }


    }
        
    
    
    class Factura
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto (Producto producto)
        {
            productos.Add( producto );
        }
            



        public void MostrarProductos()
        {
            decimal total = 0;
            Console.WriteLine("Lista de productos: ");
            foreach (Producto producto in productos)
            {
                producto.MostrarDetalles();
                total += producto.CalcularPrecioFinal();

                Console.WriteLine( $"\nTotal a pagar: {total:C}");
            }
        }
    }
    
    
    
    





    internal class Program
        {
            static void Main(string[] args)
            {

                Factura fac = new Factura();

                Producto libro1 = new Libro("C# Avanzado", 50.00m, "Programacion", "LB001", 0.05m, "Sin Autor", 492);

                Producto computadora = new Computadora("Laptop Dell", 1000.0m, "Laptops", "LAP000", 0.18m, "Dell", "intel i7", 16);
            
                fac.AgregarProducto(libro1);
                fac.AgregarProducto(computadora);



                fac.MostrarProductos();

             }
        }
}

