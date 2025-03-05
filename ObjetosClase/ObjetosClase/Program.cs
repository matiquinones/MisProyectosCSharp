using System.Globalization;
using System;

namespace ObjetosClase
{

    class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string numeroTelefono;
        private string email;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Persona()
        {
            nombre = "Sin nombre";
            edad = 0;
            direccion = "Sin direccion";
            numeroTelefono = "Sin N° Telefono";
            email = "Sin email";
        }


        public Persona(string nombre, int edad, string direccion, string telefono, string email)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.numeroTelefono = telefono;
            this.email = email;
        }

        public void MostrarInformacionCompleta()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}, Telefono: {NumeroTelefono}, email: {Email}");
        }


        class Animal
        {

            public string Nombre { get; set; }
            public int Edad { get; set; }


            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;

            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}; Edad: {Edad}");
            }


            public virtual void PedirComida()
            {
                Console.WriteLine($"{Nombre} pide comida");
            }

        }


        class Perro : Animal
        {
            public Perro(string nombre, int edad, string raza) : base(nombre, edad)
            {
                Raza = raza;
            }

            public void Ladrar()
            {
                Console.WriteLine($"Nombre: {Nombre} está ladrando");
            }

            public override void PedirComida()
            {

                Console.WriteLine($"{Nombre} (perro) mueve la cola y salta para pedir comida");


            }



            public string Raza { get; set; }

        }


        class Gato : Animal
        {


            public bool EsDomestico { get; set; }

            public Gato(string nombre, int edad, bool domestico) : base(nombre, edad)
            {
                EsDomestico = domestico;
            }


            public void Maullar()
            {
                Console.WriteLine($"{Nombre} está maullando");
            }

            public override void PedirComida()
            {

                Console.WriteLine($"{Nombre} (gato) exige comida con sus maullidos");


            }
        }

        class Pajaro : Animal
        {


            public bool pajaroCanta { get; set; }

            public Pajaro(string nombre, int edad, bool canta) : base(nombre, edad)
            {
                pajaroCanta = canta;
            }



        }







        class CuentaBancaria
        {
            private string numeroCuenta;
            private double saldo;

            public string NumeroCuenta
            {
                get
                {
                    return numeroCuenta;
                }
            }


            public double Saldo
            {
                get
                {
                    return saldo;
                }

                private set
                {
                    if (value >= 0)
                    {
                        saldo = value;
                    }

                    else
                    {
                        Console.WriteLine("El saldo no puede ser negativo");
                    }
                }

            }

            public CuentaBancaria(string numero, double saldo)
            {
                this.numeroCuenta = numero;
                this.saldo = saldo;
            }

            public void Depositar(double monto)
            {
                if (monto > 0)
                {
                    //this.saldo = this.saldo + monto;
                    this.saldo += monto;
                    Console.WriteLine($"Se han depositado {monto:C}. saldo actual: {Saldo:C}");
                }
                else
                {
                    Console.WriteLine("El monto a depositar debe ser mayor a 0");
                }
            }


            public void Retirar(double monto)
            {
                if (monto > 0 && monto <= saldo)
                {
                    this.saldo -= monto;
                    Console.WriteLine($"Se han retirado {monto:C}, saldo actual: {saldo}");
                }

                else
                {
                    Console.WriteLine("No se ha podido realizar la transaccion");
                }
            }



            public abstract class Empleado
            {
                protected string Nombre;
                protected int Edad;

                public Empleado(string nombre, int edad)
                {
                    this.Nombre = nombre;
                    this.Edad = edad;
                }

                public abstract double CalcularSalario();

                public void MostrarDetalle()
                {
                    Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
                }

            }


            public interface IEmpleadoConBeneficios
            {
                double CalcularBeneficios();

            }

            public class EmpleadoTiempoCompleto : Empleado, IEmpleadoConBeneficios
            {
                private double SalarioMensual;
                private double Beneficio;

                public EmpleadoTiempoCompleto(string nombre, int edad, double salario, double beneficio) : base(nombre, edad)
                {
                    SalarioMensual = salario;
                    this.Beneficio = beneficio;


                }

                public override double CalcularSalario()
                {
                    return SalarioMensual;
                }

                public double CalcularBeneficios()
                {
                    return Beneficio;
                }

            }


            public class EmpleadoMedioTiempo : Empleado
            {
                private double TarifaPorHora;
                private int HorasTrabajadas;



                public EmpleadoMedioTiempo(string nombre, int edad, double tarifa, int horas) : base(nombre, edad)
                {
                    TarifaPorHora = tarifa;
                    HorasTrabajadas = horas;
                }

                public override double CalcularSalario()
                {

                    return HorasTrabajadas * TarifaPorHora;
                }

            }

            internal class Program
            {
                static void Main(string[] args)
                {

                    EmpleadoTiempoCompleto empl1 = new EmpleadoTiempoCompleto("Pedro Sanhueza", 32, 2000, 500);
                    empl1.MostrarDetalle();

                    Console.WriteLine($"Salario: {empl1.CalcularSalario():C}");
                    Console.WriteLine($"Beneficios: {empl1.CalcularBeneficios():C}");




                    Empleado emp2 = new EmpleadoMedioTiempo("Juan Castro", 29, 20, 40);
                    emp2.MostrarDetalle();
                    Console.WriteLine($"Salario: {emp2.CalcularSalario()}");

                }


            }
        }
    }

}



   /* internal class Program
    {
        static void Main(string[] args)
        {

            Persona per = new Persona();
            Persona per1 = new Persona("pedro", 23, "calle falsa 123", "9728728272", "pedro@gmail.com");

            per.Nombre = "Cristobal";

            per.MostrarInformacionCompleta();
            per1.MostrarInformacionCompleta();


            // Siguiente clase

            Perro miPerro = new Perro("firulais", 5, "Pastor aleman");
            Gato miGato = new Gato("mitzu", 3, true);
            Pajaro miPajaro = new Pajaro ("Elvis", 2, true);

            miPerro.MostrarInformacion();
            miGato.MostrarInformacion();


          //  miPerro.PedirComida();
            //miGato.PedirComida();


        Animal[] animales = { miPerro, miGato, miPajaro };
        foreach (Animal animal in animales)
        {
            animal.PedirComida();
        }





        }
    }
   
    
    
    
                    static void Main(string[] args)
                {

                    CuentaBancaria cuenta = new CuentaBancaria("00042424", 1000000);

                    Console.WriteLine($"Numero de cuenta: {cuenta.numeroCuenta}");
                    Console.WriteLine($"Saldo inicial: {cuenta.saldo:C}");

                    cuenta.Depositar(500000);
                    cuenta.Retirar(3000000);
                }*/