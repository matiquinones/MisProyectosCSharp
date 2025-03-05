using System.Net;

namespace CalculadoraDescuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            while (continuar)
            {

                decimal precioOriginal = 0;
                decimal porcentajeDescuento = 0;

                while (true)
                {
                    try
                    {
                    Console.WriteLine("Ingrese el precio original del producto");
                    precioOriginal = Convert.ToDecimal(Console.ReadLine()); 
                        if (precioOriginal <= 0)
                        {
                            throw new Exception("El precio debe ser mayor a 0");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                                
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el porcentaje de descuento");
                        porcentajeDescuento = Convert.ToDecimal(Console.ReadLine());
                        if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                        {
                            throw new Exception("El porcentaje debe estar entre 0 y 100");
                        }
                        break;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                

                //Calcular el monto del descuento y el precio final

                decimal montoDescuento = (precioOriginal * porcentajeDescuento) / 100;

                decimal precioFinal = precioOriginal - montoDescuento;

                //mostrar el precio final y el monto de descuento

                Console.WriteLine($"Monto del descuento: {montoDescuento} ");
                Console.WriteLine($"Precio Final: {precioFinal}");

                Console.WriteLine("Desea calcular el descuento en otro producto? (s/n)");
                string respuesta = Console.ReadLine().ToLower();
                continuar = respuesta == "s";
            } 

              continuar = false;
            {
                Console.WriteLine("Gracias");
            }


        }
    }
}
