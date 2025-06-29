//Creare un programa para visualizar las notas.
using System;
using System.Collections.Generic;

// Clase que representa una asignatura con nombre y nota
public class Asignatura
{
    public string Nombre { get; set; } /Propiedad para el nombre 
    public double Nota { get; set; }  // Propiedad para la nota

    public Asignatura(string nombre)
    {
        Nombre = nombre;
        Nota = 0; // Nota inicial 0
    }
}

// Clase que representa el curso y contiene el Main
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

        // Pedir al usuario la nota para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota de {asignatura.Nombre}: ");
            
            // Leer la nota y validarla
            bool valido = double.TryParse(Console.ReadLine(), out double nota);
            while (!valido || nota < 0 || nota > 10)
            {
                Console.Write("Entrada inválida. Introduce una nota entre 0 y 10: ");
                valido = double.TryParse(Console.ReadLine(), out nota);
            }

            asignatura.Nota = nota;
        }

        Console.WriteLine("\nResultados:");

        // Mostrar la nota con el mensaje solicitado
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"En {asignatura.Nombre} has sacado {asignatura.Nota}");
        }
    }
}