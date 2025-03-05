namespace EstructurasClaseCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 100;
            int b = 200;

            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            }
            else if (b > a)
            {
                Console.WriteLine("B es mayor que A");
            }
            else
            {
                Console.WriteLine("B es igual que A");
            }

            int  edad = 25;
            bool tieneLicencia = true;

            if (edad >= 18 && tieneLicencia) //&& significa Y, para agregar las dos
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }



            bool esEstudiante = true;
            bool esEmpleado = true;

            if (esEmpleado || esEstudiante) // el || significa O, para que funcione si se cumple una de las condiciones
            {
                Console.WriteLine("Puedes acceder al descuento");
            }

            else
            {
                Console.WriteLine("No califica para el descuento");
            }


            int temperatura = 30;
            bool esSoleado = false;

            if ((temperatura > 25 && esSoleado) || temperatura > 35) //combinando las dos
            {
                Console.WriteLine("Es un dia indicado para ir a la playa");
            }

            else
            {
                Console.WriteLine("NO es un buen dia para ir a la playa");
            }

            //IF anidado, un if dentro de un if
            int edad1 = 20;
            bool estaInscrito = true;

            if (edad1 >= 18)
            {
                if (estaInscrito)
                {
                    Console.WriteLine("Puedes acceder al beneficio");
                }
                else
                {
                    Console.WriteLine("No puedes acceder al beneficio porque no estas inscrito");
                }
            }
            else
            {
                Console.WriteLine("No puedes acceder al beneficio porque eres menor de edad");
            }



            Console.WriteLine("Escribe un numero del dia");
            int dia = int.Parse(Console.ReadLine());    //El usuario ingresa el valor
            switch (dia)    //dependiendo de lo ingresado, se ve que mensaje mostrará
            {
                case 1:
                    Console.WriteLine("Es lunes");
                    break;

                case 2:
                    Console.WriteLine("Es martes");
                    break;
                case 3:
                    Console.WriteLine("Es miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es jueves");
                    break;
                case 5:
                    Console.WriteLine("Es viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Es fin de semana");  //se pueden juntar 2 casos
                    break;
                default:
                    Console.WriteLine("Dia ingresado no valido"); //default en caso de ingresar otro valor
                    break;
            } 





            for (int i = 0; i < 5; i++) //i parte en 0, la iteracion final será hasta 5 y incremento que deseamos darle
            {

                Console.WriteLine("iteracion numero: " + i);
            } 

            int[] numeros =
            { 10,20,30,40,50 };
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("elemento en la posicion: " + i + ": " + numeros[i]);
            }


           int contador = 1;
           while (contador <= 5)
           {
               if (contador == 3) { 
                  // break; 
                  continue;
               }
               Console.WriteLine("Iteracion numero: " + contador);
               contador++;
           }


           int contador = 10;

           do
           {   contador++;
               Console.WriteLine("Iteracion numero: " + contador);

           } while (contador <= 5);




           int[] numeros ={ 1,2,3,4,5 };
           foreach (int numero in numeros)
           {
               Console.WriteLine("Numero: " + numero);
           } 




               List<string> list = new List<string> { "Ana", "Juan", "Pedro", "Javiera"};
               foreach (string persona in list)
           {
               Console.WriteLine("Hola: " + persona);
           }



               Dictionary <string, int> edades = new Dictionary<string, int>
           {
               { "Ana", 30},
               { "Juan", 25},
               { "Pedro", 40}
           };


           foreach (KeyValuePair<string, int> persona in edades)
           {
               Console.WriteLine(persona.Key + " tiene " + persona.Value + " años.");
           }


            try
            {
                int divisor = 0;
                int resultado = 10 / divisor;

            }
            catch (Exception ex)
            {
                //   Console.WriteLine("Error: Intento de división por 0");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Este codigo se ejecuta siempre");
            }*/


            string opcion;
            List<string> Nombre = new List<string>();
            List<int> Edad = new List<int>();
            List<string> Clase = new List<string>();
            Console.WriteLine("CLASIFICACION SEGUN EDADES");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Nombre: ");
                string Rnombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int Redad = int.Parse(Console.ReadLine());
                Nombre.Add(Rnombre);
                Edad.Add(Redad);
                if (Redad >= 12 && Redad <= 18)
                {
                    string clases = "JUNIOR";
                    Console.WriteLine(Rnombre + " Clasifica a JUNIOR...");
                    Clase.Add(clases);
                }
                else if (Redad >= 18 && Redad <= 22)
                {
                    string clases = "INTERMEDIO";
                    Console.WriteLine(Rnombre + " Clasifica INTERMEDIO...");
                    Clase.Add(clases);
                }
                else if (Redad >= 22 && Redad <= 40)
                {
                    string clases = "PROFESIONAL";
                    Console.WriteLine(Rnombre + " Clasifica a PROFESIONAL...");
                    Clase.Add(clases);
                }
                else if (Redad < 12)
                {
                    Console.WriteLine("Solo mayores de doce pueden participar :(");
                }
                Console.WriteLine("(s) para siguiente participante o (n) para terminar");
                opcion = Console.ReadLine();
            } while (opcion == "s");
            for (int i = 0; i < Nombre.Count; i++)
            {
                Console.WriteLine("Nombre: " + Nombre[i] + ", Edad: " + Edad[i] + ", Clase: " + Clase[i]);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);



        }
    }
}
