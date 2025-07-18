// Sistema de Asignacion de 30 asientos, que simula una fila de personas que van a subir a un atractivo en el parque
// Clase persona
public class Persona
{
    // Atributo que guarda el nombre de la persona
    public string Nombre;

    // Atributo que guarda el número de asiento asignado
    public int Asiento;

    // Constructor que inicializa el nombre al crear un objeto
    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    // Método que muestra el nombre y  número de asiento
    public void MostrarDatos()
    {
        System.Console.WriteLine("Nombre: " + Nombre + ", Asiento: " + Asiento);
    }
}

// Clase que maneja el sistema de asignación de asientos
public class SistemaAsientos
{
    // Cola que representa la fila de personas
    private System.Collections.Generic.Queue<Persona> fila = new System.Collections.Generic.Queue<Persona>();

    // Número máximo de asientos 
    private const int LIMITE = 30;

    // Método para registrar a una persona en la fila
    public void RegistrarPersona(string nombre)
    {
        // Verifica espacio disponible
        if (fila.Count < LIMITE)
        {
            // Agrega a la persona al final de la cola
            fila.Enqueue(new Persona(nombre));
            System.Console.WriteLine("✔ Registrado: " + nombre + " (" + fila.Count + "/" + LIMITE + ")");
        }
        else
        {
            
            System.Console.WriteLine(" No hay más asientos para: " + nombre);
        }
    }

    // Método para mostrar la fila actual 
    public void VerFila()
    {
        System.Console.WriteLine("\n Fila actual (en orden de llegada):");

        int posicion = 1;

        // Recorre la fila y muestra cada persona con su número de posición
        foreach (Persona persona in fila)
        {
            System.Console.WriteLine("Fila #" + posicion + ": " + persona.Nombre);
            posicion++;
        }
    }

    // Método que asigna los asientos 
    public void Asignar()
    {
        // Verifica si la fila no está completa
        if (fila.Count < LIMITE)
        {
            System.Console.WriteLine("\n Faltan personas para comenzar. Actualmente hay: " + fila.Count);
            return;
        }

        System.Console.WriteLine("\nIniciando asignación de asientos...");

        int numeroAsiento = 1;

        // Asigna asientos a cada persona 
        while (fila.Count > 0)
        {
            // Se saca la persona del frente de la cola
            Persona persona = fila.Dequeue();

            // Se asigna el número de asiento 
            persona.Asiento = numeroAsiento;

            // Se muestra en consola la asignación
            persona.MostrarDatos();

            numeroAsiento++;
        }
    }
}

// Clase principal que ejecuta el sistema
public class ProgramaPrincipal
{
    // Método principal (Main) que inicia el programa
    public static void Main(string[] args)
    {
        // Crear una instancia del sistema de asignación
        SistemaAsientos sistema = new SistemaAsientos();

        // Registrar automáticamente 30 personas con nombres "Usuario1", "Usuario2", ..., "Usuario30"
        for (int i = 1; i <= 30; i++)
        {
            sistema.RegistrarPersona("Usuario" + i);
        }

        // Mostrar la fila antes de asignar asientos (reportería)
        sistema.VerFila();

        // Asignar los asientos cuando haya 30 personas registradas
        sistema.Asignar();

        // Mensaje final
        System.Console.WriteLine("\n✅ Proceso finalizado.");
    }
}