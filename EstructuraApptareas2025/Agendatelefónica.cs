// Se creara un sistema de Agenda telefónica.
//Mediante la utilización de clases, métodos, atributos.
//agregamos un métodos para escribir texto.

Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine("Agenda telefónica");
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
            Console.WriteLine("❌ La agenda está llena.\n");
        }
    }
    // Método para mostrar todos los contactos
        public void MostrarContactos()
        {
            if (contador == 0) 
            {
                Console.WriteLine("No hay contactos en la agenda");
                return;
            }
}