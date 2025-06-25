// Se creara un sistema de Agenda telefónica.
//Mediante la utilización de clases, métodos, atributos.
//agregamos un métodos para escribir texto.
//Se define una estructura pública
public struct Contacto
{
    public string Nombre;
    public string Telefono;
    public string Direccion;

    // Constructor
    public Contacto(string nombre, string telefono, string direccion)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
    }

    // Método para mostrar el contacto
    public void Mostrar()
    {
        // Este método depende de Console, así que se asume que se permite para entrada/salida
        System.Console.WriteLine("Nombre: " + Nombre + ", Teléfono: " + Telefono + ", Dirección: " + Direccion);
    }
}

public class Agenda
{
    private Contacto[] contactos; // Arrays
    private int cantidad;         // Cantidad actual de contactos

    // Constructor
    public Agenda(int capacidad)
    {
        contactos = new Contacto[capacidad];
        cantidad = 0;
    }

    // Método para agregar un contacto
    public void AgregarContacto(Contacto nuevo)
    {
        if (cantidad < contactos.Length)
        {
            contactos[cantidad] = nuevo;
            cantidad++;
            System.Console.WriteLine("Contacto agregado.\n");
        }
        else
        {
           System.Console.WriteLine("La agenda está llena.\n");
        }
    }

    // Método para mostrar todos los contactos
    public void MostrarContactos()
    {
        if (cantidad == 0)
        {
            System.Console.WriteLine("La agenda está vacía.");
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                contactos[i].Mostrar();
            }
        }
    }

    // Método para buscar por nombre
    public void BuscarPorNombre(string nombre)
    {
        bool encontrado = false;
        for (int i = 0; i < cantidad; i++)
        {
            if (contactos[i].Nombre == nombre)
            {
                contactos[i].Mostrar();
                encontrado = true;
            }
        }

        if (!encontrado)
        {
           System.Console.WriteLine("Contacto no encontrado.");
        }
    }
}

// Programa principal
public class Program
{
    public static void Main()
    {
        Agenda agenda = new Agenda(4); // Capacidad máxima de 4 contactos

        // Agregar contactos manualmente
        agenda.AgregarContacto(new Contacto("Maria", "062943011", "Calle Sucre"));
        agenda.AgregarContacto(new Contacto("Maira", "0969696969", "Calle Mosquera"));

        // Mostrar todos los contactos
        System.Console.WriteLine("\nLista de contactos:");
        agenda.MostrarContactos();

        // Buscar un contacto
        System.Console.Write("\nIngrese el nombre a buscar: ");
        string nombreBuscado = System.Console.ReadLine() ?? "";
        agenda.BuscarPorNombre(nombreBuscado);

        System.Console.WriteLine("\nFin del programa.");
    }
  }
}






