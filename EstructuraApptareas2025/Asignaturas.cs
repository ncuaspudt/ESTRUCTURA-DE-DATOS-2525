// Realizare un programa que asigne asignaturas de un curso con POO.

using System;
using System.Collections.Generic;

// Clase  asignatura
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
    private List<Asignaturas> asignaturas;

    // Constructor que inicializa la lista con algunas asignaturas
    public Curso()
    {
        asignaturas = new List<Asignaturas>();
        asignaturas.Add(new Asignaturas("Matemáticas"));
        asignaturas.Add(new Asignaturas("Física"));
        asignaturas.Add(new Asignaturas("Lengua y Literatura"));
        asignaturas.Add(new Asignaturas("Historia"));
        asignaturas.Add(new Asignaturas("Química"));
     
    }

    // Método público para mostrar las asignaturas
    public void MostrarAsignaturas()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine("_ " + asignatura.ObtenerNombre());
        }
    }
}
