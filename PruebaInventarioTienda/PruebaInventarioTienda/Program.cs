namespace PruebaInventarioTienda
{
    using System;
    using System.Collections.Generic;

    class Producto
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, int stock, decimal precio)
        {
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }
    }

    class Program
    {
        static List<Producto> inventario = new List<Producto>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menú de Inventario ---");
                Console.WriteLine("1. Agregar un nuevo producto");
                Console.WriteLine("2. Actualizar cantidad de stock");
                Console.WriteLine("3. Consultar inventario");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarProducto();
                        break;
                    case "2":
                        ActualizarStock();
                        break;
                    case "3":
                        ConsultarInventario();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo de la aplicación...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            try
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad inicial en stock: ");
                int stock = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                if (stock < 0 || precio < 0)
                {
                    Console.WriteLine("Error: La cantidad y el precio deben ser valores positivos.");
                    return;
                }

                inventario.Add(new Producto(nombre, stock, precio));
                Console.WriteLine("Producto agregado exitosamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese valores numéricos válidos para stock y precio.");
            }
        }

        static void ActualizarStock()
        {
            try
            {
                Console.Write("Ingrese el nombre del producto a actualizar: ");
                string nombre = Console.ReadLine();

                Producto producto = inventario.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

                if (producto == null)
                {
                    Console.WriteLine("Error: Producto no encontrado.");
                    return;
                }

                Console.Write("Ingrese la nueva cantidad en stock: ");
                int nuevoStock = int.Parse(Console.ReadLine());

                if (nuevoStock < 0)
                {
                    Console.WriteLine("Error: La cantidad de stock debe ser positiva.");
                    return;
                }

                producto.Stock = nuevoStock;
                Console.WriteLine("Stock actualizado correctamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido para la cantidad de stock.");
            }
        }

        static void ConsultarInventario()
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            Console.WriteLine("\n--- Inventario ---");
            foreach (var producto in inventario)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Stock: {producto.Stock}, Precio: ${producto.Precio:F2}");
            }
        }
    }
}
