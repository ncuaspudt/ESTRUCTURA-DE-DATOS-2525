// Se creara un sistema de Agenda telefónica.
//Mediante la utilización de clases, métodos, atributos.
//agregamos un métodos para escribir texto.

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("===================");

//Se define una estructura pública
public struct Contacto

{
    public string Nombre;                        //Atributo nombres del contacto
    public string Telefono;                      //Atributo teléfono de contacto
    public string Direccion;                     //Atributo dirección de contacto


    //Constructor para iniciar los datos del contacto
    public Contacto(string nombre, string telefono, string direccion)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;

    }
    //Método para mostrar información del contacto
    public void Mostrar()
    {
        Console.WriteLine("Nombre:+" Nombre);
        Console.WriteLine("Telefono:+"Telefono);
        Console.WriteLine("Direccion:+"Direccion);
    }
}
//Clase para manejar Agenda Telefónica
public class Agenda
{
    private Contacto[] contactos; // Arreglo para almacenar contactos
    private int contador;         // Número de contactos

    //Constructor
    public Agenda(int capacidad)
    {
        contactos = new Contacto[capacidad];
        contador = 0; // Inicialmente no hay contactos
    }
    //Método para agregar un contacto en la agenda
    public void AgregarContacto(Contacto nuevo)
    {
        if (contador < contactos.Length) // Verificar que haya espacio
        {
            contactos[contador] = nuevo; // Agrega el contacto 
            contador++;                  // Incrementa el contador de contactos
            Console.WriteLine("Contacto agregado correctamente");
        }
        else
        {
            Console.WriteLine("La agenda está llena.\n");
        }
    }
    // Método para mostrar todos los contactos
public void MostrarContactos()
        {
            if (contador == 0) // Si no hay contactos
            {
                Console.WriteLine("📭 No hay contactos en la agenda.\n");
                return;
            }

            Console.WriteLine(" Listado de contactos:\n");
            for (int i = 0; i < contador; i++) contactos[i].Mostrar();
            Console.WriteLine();
        }

        // Método para buscar contactos por nombre (puede ser parcial, no sensible a mayúsculas)
        public void BuscarPorNombre(string nombre)
        {
            bool encontrado = false;

            Console.WriteLine($"\n🔍 Resultados para la búsqueda: '{nombre}'\n");

            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.ToLower().Contains(nombre.ToLower()))
                {
                    contactos[i].Mostrar();
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("❌ No se encontraron contactos con ese nombre.\n");
        }
    }

    // Clase principal que contiene el método Main para ejecutar el programa
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda(100); // Crear una agenda con capacidad para 100 contactos
            bool salir = false;                // Variable para controlar el bucle del menú

            while (!salir)
            {
                Console.WriteLine("========= AGENDA TELEFÓNICA =========");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar todos los contactos");
                Console.WriteLine("3. Buscar contacto por nombre");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        // Solicitar datos del nuevo contacto
                        Console.Write("Ingrese el nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el teléfono: ");
                        string telefono = Console.ReadLine();
                        Console.Write("Ingrese la dirección: ");
                        string direccion = Console.ReadLine();

                        // Crear contacto y agregarlo
                        Contacto nuevo = new Contacto(nombre, telefono, direccion);
                        miAgenda.AgregarContacto(nuevo);
                        break;

                    case "2":
                        miAgenda.MostrarContactos();
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBusqueda = Console.ReadLine();
                        miAgenda.BuscarPorNombre(nombreBusqueda);
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("👋 ¡Gracias por usar la agenda!");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción no válida. Intente de nuevo.\n");
                        break;
                }
            }
        }
    }

}