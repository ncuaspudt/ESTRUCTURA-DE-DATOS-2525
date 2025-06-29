// Programa con asignaturas de un curso con un mensaje al inicio
// Clase que representa asignaturas de un curso.

// Clase que representa asignaturas de un curso.
class Asignatura
{
    // Propiedad que almacena el nombre de la asignatura
    public string Nombre { get; set; }

    // Constructor que recibe el nombre
    public Asignatura(string nombre)
    {
        Nombre = nombre;
    }
}

// Clase principal que contiene el método de entrada
class Programa
{
    static void Main()
    {
        // Crear lista de asignaturas sin usar 'using'
        System.Collections.Generic.List<Asignatura> asignaturas = new System.Collections.Generic.List<Asignatura>()
        {
            new Asignatura("Matemáticas"),    //Agrega la asignatura de Matemática
            new Asignatura("Física"),         //Agrega la asignatura de Física
            new Asignatura("Química"),        //Agrega la asignatura de Química
            new Asignatura("Historia"),       //Agrega la asignatura de Historia
            new Asignatura("Lengua")          //Agrega la asignatura de Lengua
        };

        // Mostrar cada asignatura con un mensaje
        foreach (Asignatura asignatura in asignaturas)
        {
            System.Console.WriteLine("Yo estudio " + asignatura.Nombre);
        }
    }
}