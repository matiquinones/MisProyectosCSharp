namespace SingletonClase
{

    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;

        private static readonly object padlock = new object();

        public bool IsConnected { get; private set; }

        private DatabaseConnection()
        {
            IsConnected = false;
        }


        public static DatabaseConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                        Console.WriteLine("Nueva instancia creada de la conexion de db");

                    }
                    return instance;
                }
            }

        }


        public void OpenConnection()
        {
            if (!IsConnected)
            {
                IsConnected = true;
                Console.WriteLine("Conexion a la base de datos abierta");
            }
            else
            {
                Console.WriteLine("La conexion ya esta abierta.");
            }
        }


        public void CloseConnection()
        {
            if (IsConnected)
            {
                IsConnected= false;
                Console.WriteLine("Conexion a la base de datos cerrada");

            }
            else
            {
                Console.WriteLine("Conexion ya está cerrada");
            }
        }



        internal class Program
        {
            static void Main(string[] args)
            {

                DatabaseConnection con1 = DatabaseConnection.Instance;
                con1.OpenConnection();


                DatabaseConnection con2 = DatabaseConnection.Instance;
                con2.OpenConnection();


                con1.CloseConnection();
                con2.CloseConnection();


                Console.WriteLine(object.ReferenceEquals(con1, con2) ? "Ambas referencias apuntan a la misma instancia" : "Las referencias son diferentes"); 





            }
        }


    }
}