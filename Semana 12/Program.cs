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
    // Método para mostrar información
    public string Mostrar()
    {
        return "ISBN: " + ISBN + ", Título: " + Titulo + ", Autor: " + Autor;
    }
}
// Clase 
class SistemaBilbioteca
{
    // Mapa pares clave-valor
    static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();

    // Conjunto almacenamiento únicos
    static HashSet<string> conjuntoISBN = new HashSet<string>();

    // Método agregar libro
    static void AgregarLibro(string isbn, string titulo, string autor)
    {
        if (!conjuntoISBN.Contains(isbn))
        {
            conjuntoISBN.Add(isbn); // Añadir al conjunto
            biblioteca.Add(isbn, new Libro(isbn, titulo, autor)); // Añadir al mapa
            Console.WriteLine("Libro agregado.");
        }
        else
        {
            Console.WriteLine("ISBN ya registrado. No se agregó el libro.");
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

    // Método que permite vizualizar todos los libros
    static void MostrarTodos()
    {
    // Imprime en la consola de depuración
        Console.WriteLine("Lista de todos los libros:");

        foreach (var libro in biblioteca.Values)
        {
        Console.WriteLine(libro.Mostrar());
        }
    }

    static void Main()
    {
        // Agregar libros
        AgregarLibro("01", "Física", "Javier Muñoz");
        AgregarLibro("02", "Programación", "Roque López");

        // Consulta de un libro
        ConsultarLibro("01");

        // Visualización de todos los libros
        MostrarTodos();
    }
}
