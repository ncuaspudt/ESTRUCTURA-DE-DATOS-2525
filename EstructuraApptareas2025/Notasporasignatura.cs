//Creare un programa para visualizar las notas.
// Clase que representa una asignatura individual (como Matemáticas, Física, etc.)
public class Asignatura
{
    // Propiedad para guardar el nombre de la asignatura
    public string Nombre { get; set; }

    // Propiedad para guardar la nota del estudiante
    public double Nota { get; set; }

    // Constructor que recibe el nombre de la asignatura al crearla
    public Asignatura(string nombre)
    {
        Nombre = nombre;   // Se asigna el nombre recibido
        Nota = 0;          // Se inicializa la nota en 0
    }
}

// Clase que representa el curso, que contiene una lista de asignaturas
public class Curso
{
    // Lista privada que almacena las asignaturas del curso
    private System.Collections.Generic.List<Asignatura> asignaturas;

    // Constructor del curso
    public Curso()
    {
        // Se crea la lista de asignaturas e inmediatamente se llenan con valores fijos
        asignaturas = new System.Collections.Generic.List<Asignatura>();
        asignaturas.Add(new Asignatura("Matemáticas"));
        asignaturas.Add(new Asignatura("Física"));
        asignaturas.Add(new Asignatura("Química"));
        asignaturas.Add(new Asignatura("Historia"));
        asignaturas.Add(new Asignatura("Lengua"));
    }

    // Método para pedir las notas al usuario
    public void PedirNotas()
    {
        // Recorre cada asignatura de la lista
        foreach (Asignatura asignatura in asignaturas)
        {
            // Solicita al usuario ingresar la nota para esa asignatura
            System.Console.Write("Introduce la nota de " + asignatura.Nombre + ": ");
            string entrada = System.Console.ReadLine(); // Lee la entrada del usuario
            double nota;

            // Verifica si la nota ingresada es válida (entre 0 y 10)
            while (!double.TryParse(entrada, out nota) || nota < 0 || nota > 10)
            {
                System.Console.Write("Nota inválida. Introduce un número entre 0 y 10: ");
                entrada = System.Console.ReadLine(); // Vuelve a leer la entrada si no es válida
            }

            // Asigna la nota válida a la asignatura
            asignatura.Nota = nota;
        }
    }

    // Método para mostrar todas las notas ingresadas
    public void MostrarNotas()
    {
        // Imprime un título antes de mostrar las notas
        System.Console.WriteLine("\nResultados:");

        // Recorre todas las asignaturas e imprime el mensaje con la nota correspondiente
        foreach (Asignatura asignatura in asignaturas)
        {
            System.Console.WriteLine("En " + asignatura.Nombre + " has sacado " + asignatura.Nota);
        }
    }
}