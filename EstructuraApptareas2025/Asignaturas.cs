// Programa que almacenara las asignaturas de un curso como Matemáticas, Física, Química, Historia y Lengua
// Clase asignatura
public class Asignaturas
{
    // Propiedad para el nombre de la asignatura
    public string Nombre { get; set; }

    // Constructor que recibe el nombre como parámetro
    public Asignaturas(string nombre)
    {
        Nombre = nombre;
    }

    // Método que devuelve el nombre de la asignatura
    public string ObtenerNombre()
    {
        return Nombre;
    }
}

// Clase que representa un curso con varias asignaturas
public class Curso
{
    // Lista privada de asignaturas
    private System.Collections.Generic.List<Asignaturas> asignaturas;

    // Constructor que inicializa la lista con algunas asignaturas
    public Curso()
    {
        asignaturas = new System.Collections.Generic.List<Asignaturas>();
        asignaturas.Add(new Asignaturas("Matemáticas"));
        asignaturas.Add(new Asignaturas("Física"));
        asignaturas.Add(new Asignaturas("Lengua y Literatura"));
        asignaturas.Add(new Asignaturas("Historia"));
        asignaturas.Add(new Asignaturas("Química"));
    }

    // Método público para mostrar las asignaturas
    public void MostrarAsignaturas()
    {
        System.Console.WriteLine("Asignaturas del curso:");
        foreach (Asignaturas asignatura in asignaturas)
        {
            System.Console.WriteLine("_ " + asignatura.ObtenerNombre());
        }
    }
}