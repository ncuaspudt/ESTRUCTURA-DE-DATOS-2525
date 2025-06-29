//Programa que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.
// Declaración de la clase principal del programa
class ContadorDeVocales
{
    // Método principal: punto de entrada del programa
    static void Main()
    {
        // Solicita al usuario que escriba una palabra
        System.Console.WriteLine("Escribe una palabra:");

        // Lee la palabra ingresada por el usuario y la convierte a minúsculas para facilitar la comparación
        string palabra = System.Console.ReadLine().ToLower();

        // Variables para contar cada vocal
        int a = 0, e = 0, i = 0, o = 0, u = 0;

        // Recorre cada carácter en la palabra ingresada
        foreach (char c in palabra)
        {
            // Comprueba si el carácter es una vocal y aumenta su contador correspondiente
            if (c == 'a') a++;
            else if (c == 'e') e++;
            else if (c == 'i') i++;
            else if (c == 'o') o++;
            else if (c == 'u') u++;
        }

        // Muestra el número de veces que aparece cada vocal
        System.Console.WriteLine("Número de vocales en la palabra:");
        System.Console.WriteLine("a: " + a);
        System.Console.WriteLine("e: " + e);
        System.Console.WriteLine("i: " + i);
        System.Console.WriteLine("o: " + o);
        System.Console.WriteLine("u: " + u);
    }
}