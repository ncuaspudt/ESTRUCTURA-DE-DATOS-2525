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
