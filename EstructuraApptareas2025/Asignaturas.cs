// Realizare un programa que asigne asignaturas de un curso con POO.


public class Asignaturas
{
    public string Nombre { get; set; };
    public Asignaturas(string nombre);
     {
        Nombre = nombre;
      }
      public string ObtenerNombre()
{
  return Nombre;
}
}
public class curso
{
  private System.Collections.Generic.List<Asignatura> asignaturas;
  public Curso()
  {
    asignaturas = new System.Collections.Generic.List<Asignatura>();
    Asignaturas.Add(new Asignaturas("Matemáticas"));
    Asignaturas.Add(new Asignaturas("Educación Física"));
    Asignaturas.Add(new Asignaturas("Lengua y Literatura"));
    Asignaturas.Add(new Asignaturas("ECA"));
    Asignaturas.Add(new Asignaturas("Cívica"));
    Asignaturas.Add(new Asignaturas("Ciencias Naturales"));
    Asignaturas.Add(new Asignaturas("Estudios Sociales"));
    Asignaturas.Add(new Asignaturas("Inglés"));
      }
      }