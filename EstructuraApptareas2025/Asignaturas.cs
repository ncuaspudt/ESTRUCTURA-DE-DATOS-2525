// Realizare un programa que asigne asignaturas de un curso con POO.


public class Asignaturas
{
    public string Nombre { get; set; }
    public Asignaturas(string nombre)
    { 
        Nombre = nombre;
      }
      public string ObtenerNombre()
{
  return Nombre;
}
}
public class Curso
{
    private System.Collections.Generic.List<Asignatura> asignaturas;

    public Curso()
    {
        asignaturas = new System.Collections.Generic.List<Asignatura>();
        asignaturas.Add(new Asignatura("Matemáticas"));
        asignaturas.Add(new Asignatura("Educación Física"));
        asignaturas.Add(new Asignatura("Lengua y Literatura"));
        asignaturas.Add(new Asignatura("ECA"));
        asignaturas.Add(new Asignatura("Cívica"));
        asignaturas.Add(new Asignatura("Ciencias Naturales"));
        asignaturas.Add(new Asignatura("Estudios Sociales"));
        asignaturas.Add(new Asignatura("Inglés"));
    }

  public void MostrarAsignaturas()
  {
    Console.WriteLine("Asignaturas de curso:");
    foreach (var asignatura in asignaturas)
    {
      Console.WriteLine("_" + asignatura.ObtenerNombre());
    }
  }
}