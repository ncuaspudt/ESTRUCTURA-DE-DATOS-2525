// Clase que representa asignaturas de un curso.

class Asignatura
{
    public string Nombre { get; set; }

    public Asignatura(string nombre)
    {
        Nombre = nombre;
    }
}

// Crear lista de asignaturas
var asignaturas = new System.Collections.Generic.List<Asignaturas>()
{
    new Asignatura("Matemáticas"),
    new Asignatura("Física"),
    new Asignatura("Química"),
    new Asignatura("Historia"),
    new Asignatura("Lengua")
}

// Mostrar cada asignatura con el mensaje
foreach (var asignatura in asignaturas)
{
    System.Console.WriteLine("Yo estudio " + asignatura.Nombre);
}