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