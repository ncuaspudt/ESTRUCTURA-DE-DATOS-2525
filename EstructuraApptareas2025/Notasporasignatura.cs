// Programa con asignaturas de un curso
//Creare un programa para visualizar las notas.
// Clase que representa una asignatura individual como Matemáticas, Física, Lengua, Química e Historia.

// Clase que representa asignaturas de un curso.
class Asignatura
{
    public string Nombre { get; set; }
    public double Nota { get; set; }  // Nueva propiedad para guardar la nota

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
        // Crear lista de asignaturas
        System.Collections.Generic.List<Asignatura> asignaturas = new System.Collections.Generic.List<Asignatura>()
        {
            new Asignatura("Matemáticas"),                //Agrega la asignatura llamada Matemática
            new Asignatura("Física"),                     //Agrega la asignatura llamada Física
            new Asignatura("Química"),                    //Agrega la asignatura llamada Química
            new Asignatura("Historia"),                   //Agrega la asignatura llamada Historia
            new Asignatura("Lengua")                      //Agrega la asignatura llamada Lengua
        };

        // Pedir notas al usuario
        foreach (Asignatura asignatura in asignaturas)
        {
            System.Console.Write($"Introduce la nota de {asignatura.Nombre}: ");
            string entrada = System.Console.ReadLine();
            double nota;

            // Validación de entrada
            while (!double.TryParse(entrada, out nota) || nota < 0 || nota > 10)
            {
                System.Console.Write("Nota inválida. Introduce un valor entre 0 y 10: ");
                entrada = System.Console.ReadLine();
            }

            asignatura.Nota = nota;
        }

        // Aumentar las notas (sin superar 10)
        System.Console.WriteLine("\nNotas aumentadas:");
        foreach (Asignatura asignatura in asignaturas)
        {
            double notaOriginal = asignatura.Nota;
            double notaAumentada = notaOriginal + 1;

            if (notaAumentada > 10)
                notaAumentada = 10;

            System.Console.WriteLine($"En {asignatura.Nombre} tenías un {notaOriginal} y ahora tienes un {notaAumentada}");
        }
    }
}