// Aplicación para el registro de libros en una biblioteca
// Clase libro para iniciar con la organización del código.
class Libro
{
    // Atributos que almacenan información de cada objeto en base a la clase principal.
    public string ISBN;
    public string Titulo;
    public string Autor;

    // Constructor para inicializar los datos del libro
    public Libro(string isbn, string titulo, string autor)
    {
        ISBN = isbn;
        Titulo = titulo;
        Autor = autor;
    }
    // Método para mostrar la información del libro
    public string Mostrar()
    {
        return "ISBN: " + ISBN + ", Título: " + Titulo + ", Autor: " + Autor;
    }
}

class SistemaBilbioteca
{
    // Mapa: Diccionario que asocia ISBN (clave) con un objeto Libro (valor)
    static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();

    // Conjunto: para almacenar solo los ISBN únicos
    static HashSet<string> conjuntoISBN = new HashSet<string>();

    // Agrega un libro si el ISBN no está ya registrado
    static void AgregarLibro(string isbn, string titulo, string autor)
    {
        if (!conjuntoISBN.Contains(isbn))
        {
            conjuntoISBN.Add(isbn); // Añadir al conjunto
            biblioteca.Add(isbn, new Libro(isbn, titulo, autor)); // Añadir al mapa
            System.Console.WriteLine("Libro agregado.");
        }
        else
        {
            System.Console.WriteLine("ISBN ya registrado. No se agregó el libro.");
        }
    }

    // Consulta: buscar un libro por su ISBN (acceso directo al mapa)
    static void ConsultarLibro(string isbn)
    {
        if (biblioteca.ContainsKey(isbn))
        {
            System.Console.WriteLine("Libro encontrado: " + biblioteca[isbn].Mostrar());
        }
        else
        {
            System.Console.WriteLine("Libro no encontrado.");
        }
    }

    // Visualizar: mostrar todos los libros registrados
    static void MostrarTodos()
    {
        System.Console.WriteLine("Listado de todos los libros:");

        foreach (var libro in biblioteca.Values)
        {
            System.Console.WriteLine(libro.Mostrar());
        }
    }

    static void Main()
    {
        // Prueba: agregamos libros
        AgregarLibro("978-3-16-148410-0", "C# Básico", "Juan Pérez");
        AgregarLibro("978-0-13-110362-7", "Estructuras de Datos", "Ana López");

        // Consulta de un libro
        ConsultarLibro("978-3-16-148410-0");

        // Visualización de todos los libros
        MostrarTodos();
    }
}
