class HolaMundo
{
    struct Punto
    {
        int X;
        int Y;

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int WriteX()
        {
            return X;
        }
    }

    enum DiaSemana
    {
        Lunes, //0
        Martes, //1
        Miercoles, //2
        Jueves, //3
        Viernes, //4
        Sabado, //5
        Domingo //6
    }

    enum ErrorCode : short
    {
        None=0,
        Unknow=1,
        ConnectionLost = 9009
    }

    static void Main(string[] args)
    {
        Punto p= new Punto(10,20);

        //Console.WriteLine(p.WriteX());


        //tupla
        (string nombre, int edad) persona= ("Juan", 30);

        Console.WriteLine(persona); // todos los datos
        Console.WriteLine(persona.nombre); //solo el nombre








        DiaSemana ds = DiaSemana.Miercoles;

        ErrorCode errorCode = ErrorCode.ConnectionLost;




        (string nombre, int edad) ObtenerPersona()
        {
            return ("Pedro", 35);
        }

        Console.WriteLine(ObtenerPersona());


        var t = (1, 2, 3, 4, 5, 6, 7, 8, 9, "nombre"); //sirve para hacer una tupla sin decir el tipo de dato
        Console.WriteLine(t.Item7);  //estoy llamando a un item en especifico, parte desde 1, no 0
        Console.WriteLine(t.Item10);


        var s = "Matty";
        Console.WriteLine(s);

        var i = 30;
        Console.WriteLine(i);


        //    Console.WriteLine(ds);
        //     Console.WriteLine((int) ds);
        //      Console.WriteLine(errorCode);
        //     Console.WriteLine((int)(errorCode));





        // este comentario es de solo una linea
        //  Console.WriteLine("Hola mundo"); // este es una linea de consola


        byte miByte = 120; // 0 a 255, usa 1 byte, uso comun binario o n° enteros pequeños sin signo

        sbyte misByte = -1; // -128 a 127, 1 byte, enteros pequeños y negativos o positivos

        //  Console.WriteLine(miByte);
        //  Console.WriteLine(misByte);

        short miShort = 150; // -32768 a 32767, 2 bytes, mas grande que sbyte, mas chico que int
        ushort miuShort = 10000; //0 a 65535, 2byte

        short valor = miByte; //ahora si deja, pq no se puede de un dato de mayor alcanze no se puede a uno de menor, pero alreves si
        
        //  Console.WriteLine(valor);


        int miEntero = 1000; //el mas usado y permite mayor rango de numeros ENTEROS

        long miLong = 3000; //permite trillones, 8 bytes}

        // Console.WriteLine(miLong);

        float miFloat = 0.1214f; //permite DECIMALES, declarar con f al final, punto no coma.

        double miDouble = 0.12465; //no necesita f, hasta 15 decimales

        decimal miDecimal = 0.273524352353m; //16bytes, hasta 29 digitos, debe terminar con m o M




        bool miBool = false; //true or false

        char miChar = 'r'; // solo 1 caracter todo tipo, declarar con comilla simple 'x'

        // Console.WriteLine(miChar);

        // Console.WriteLine(miEntero.ToString());


        string miString = "esto es una cadena de texto";

        // Console.WriteLine(miString);


        object miObject = 20;
        object miObject1 = "cadena"; //soporta cualquier tipo


        //AHORA VAMOS A TIPOS DE DATOS ESTRUCTURADOS: Arrays, Structs, Enums, Tuplas

        //Arrays

        int[] miArray = new int[5]; //5 es la longitud
        miArray[0] = 2; //A mi Array en su posicion 0 le estoy asignando el valor 2
        miArray[1] = 4;
        miArray[2] = 6;
        miArray[3] = 8;
        miArray[4] = 10; // Le asignamos 5 numeros pares de forma manual


        //  Console.WriteLine(miArray[2]);


        int[,] matriz = new int[3, 2]; //estamos creando una matriz, de 3 filas y 2 columnas
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3; //le estou asignando el valor de 3 a la matriz en su posicion 1,0
        matriz[1, 1] = 4;
        matriz[2, 1] = 5;
        matriz[2, 1] = 6;

        //  Console.WriteLine(matriz[1,0]);


        //Struct  //Se usa para representar pequeños conjuntos de datos, asi como coordenadas o colores
        //Se declara por fuera del metodo, osea, al principio arriba


        //Enum    //Se utiliza para representar valores fijos, asi como dias de la semana o estados de un proceso
        // tipos por valor similares a  numericos como INT o BYTE
        // tambien esta arriba


        //Tuplas   //Tipo de valor que encapsula en 1 sola unidad multiples datos de distintos tipos









    }
}