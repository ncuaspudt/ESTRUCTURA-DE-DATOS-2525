// Implementare un clase Estudiante con varios atributos.
// Mediante un array permitira almacenar tres números de teléfono.

// Registro de una clase llamada Estudiante.
class Estudiante
{
    public int Id;                              //Atributo de identificador único
    public string Nombres;                      //Atributo nombres del estudiante
    public string Apellidos;                     //Atributo apellidos del estudiante
    public string Direccion;                     //Atributo dirección del estudiante
    public string[] Telefonos= new string[3];    //Array para registar tres números de teléfono
    
//Método que permite visualizar toda la información del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("\n---Informacion del Estudiante---");
        Console.WriteLine($"ID:{Id}");
        Console.WriteLine($"Nombre completo:{Nombres}{Apellidos}");
        Console.WriteLine($"Direccion:{Direccion}");
        // Reconoce array e imprime cada número
        Console.WriteLine("Telefonos:"); for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"Telefono{i + 1}:{Telefonos[i]}");
        }
    }
}
//clase programa
class Program
{
    //Método principal del programa
    static void Main()
    {
        //Nueva instancia de clase Estudiante
        Estudiante estudiante = new Estudiante();
        //Solicita ingreso de datos de estudiante.
        Console.Write("Ingrese el ID del estudiante:");
        estudiante.Id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese los nombres del estudiante:");
        estudiante.Nombres = Console.ReadLine();
        Console.Write("Ingrese los apellidos del estudiante:");
        estudiante.Apellidos = Console.ReadLine();
        Console.Write("Ingrese la direccion del estudiante:");
        estudiante.Direccion = Console.ReadLine();
        //Solicitar al estudiante que ingrese tre números de teléfono.

        Console.WriteLine("\n Ingrese tres numeros de telefono:");
        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Telefono{i + 1}:");
            estudiante.Telefonos[i] = Console.ReadLine();
        }
        //Llamar a método para mostrar toda la información.
        estudiante.MostrarDatos();
        

}
}