//Crear un programa con diferentes asignaturas 
using System;
using System.Collections.Generic;

// Clase que representa una asignatura
public class Asignatura
{
    public string Nombre { get; set; }

    public Asignatura(string nombre)
    {
        Nombre = nombre;
    }
}
//clase curso
public class Curso
{
    public static void Main()
    {
        // Crear lista de asignaturas
        List<Asignatura> asignaturas = new List<Asignatura>()
        {
            new Asignatura("Matemáticas"),
            new Asignatura("Física"),
            new Asignatura("Química"),
            new Asignatura("Historia"),
            new Asignatura("Lengua")
        };

        // Mostrar cada asignatura con el mensaje
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura.Nombre);
        }
    }
}