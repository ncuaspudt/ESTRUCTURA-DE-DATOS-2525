// Implementare una clase Estudiante con varios atributos.
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
        
        System.Console.WriteLine("ID": + id);                   //Imprime el ID del estudiante
        System.Console.WriteLine("Nombres":+ nombres);          // Imprime los nombres del estudinate
        System.Console.WriteLine("Apellidos": + apellidos);      // Imprime los apellidos
        System.Console.WriteLine("Direccion": +direccion);      // Imprime la dirección
        // Reconoce array e imprime cada número
        System.Console.WriteLine("Telefonos:"); for (int i = 0; i < Telefonos.Length; i++) // Se implementa un bucle para imprimir cada teléfono
        {
            Console.WriteLine("Telefono" + (i + 1)+":"+ telefonos[i]);
        }
    }


    static void Main()
    {
        //Asignamos valores a cada atributo del estudiante.
        Estudiante estudiante = new Estudiante();
        estudiante.Id = 1;
        estudiante.nombres = "Danny";
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