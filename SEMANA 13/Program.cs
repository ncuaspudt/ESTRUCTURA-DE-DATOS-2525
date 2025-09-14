// Universidad Estatal Amazónica
// Tarea semana 13
// Aplicación de 10 títulos de revista de catálogo
// Clase para iniciar el programa
public class Catalogo
{
    // Método principal
   public static void Main()

  {
    // Se crea un diccionario con 10 títulos de revistas de catálogo y una descripción
    Dictionary<string, string> catalogo = new Dictionary<string, string>()
    {

    {"SciELO", "Revista científicas de diferentes materias y áreas"},
    {"Biblat", "Revista de Ciencias Sociales de América Latina"},
    {"Discover", "Revista popular de divulgación"},
    {"Iconos", "Revista de Ciencias Sociales"},
    {"Alteridad", "Revista de Educación"},
    {"Letras Verdes", "Revista Latinoaméricana de Estudios Socioambientales"},
    {"URVIO", "Revista de Estudios de Seguridad"},
    {"Latindex", "Revistas científicas de Amércia Latina"},
    {"Nature", "Revista de Ciencia y Tecnología"},
    {"The Lancet", "Revistas médicas antiguas"},
};
// Este menú interactivo permitira vizualizar en la Consola de depuración
while (true)
{
    Console.WriteLine( "CATÁLOGO DE REVISTAS");
    Console.WriteLine("1. Buscar revista por título");
    Console.WriteLine("2. Salir");
// En la Consola de depuración sale la opción de colocar el numero para buscar o mostrar los títulos de revistas.
    Console.Write("Eliga un a opción");
// El dato primitivo permite leer la opcón ingresada.
    string opcion = Console.ReadLine();
// Al momento de seleccionar la opción la aplicación inicializará la búsqueda.
    if (opcion == "1")
{
// Una vez ingresado el numero procederemos a ingresar el título de la revista
    Console.Write ("Ingrese el título de la Revista de Catalogo");
// Permite leer el título ingresado.
    string titulo = Console.ReadLine();
    bool encontrado = false;
// Permite realizar una búsqueda iterativa recorriendo el diccionario manualmente.
    foreach (KeyValuePair<string, string>revista in catalogo)
{
// Permite la comparación del título con las palabras ingresadas
if(revista.Key.Equals(titulo, StringComparison.OrdinalIgnoreCase))
  {
// Si el título existe mostrara encontrado
    Console.WriteLine("Encontrado");
// Permitira marcar como encontrado
    encontrado = true;
// Esta instrucción de flujo permitirá salir del bucle inmediatamente para evitar seguir buscando.
    break;
    }

}
// Permite realizar una acción si una condición se cumple
    if(!encontrado)
{
    Console.WriteLine("No encontrado");
    }
}
// Si selecciono la opción 3 salimos del programa
    else if(opcion == "2")
    {
        Console.WriteLine("Salir del programa");
        break;
     }
  }
 }
}




