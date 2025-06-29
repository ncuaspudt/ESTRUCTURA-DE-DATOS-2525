
// Iniciar programa de una clase llamada ListaDeNumeros
class ListaDeNumeros
{
    // Punto de entrada del programa
    static void Main()
    {
        // Crear una lista para almacenar los números del 1 al 10
        System.Collections.Generic.List<int> numeros = new System.Collections.Generic.List<int>();

        // Llenar la lista con los números del 1 al 10 usando un bucle for
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i); // Agrega cada número a la lista
        }

        // Recorrer la lista en orden inverso para mostrar los números
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            System.Console.Write(numeros[i]); // Imprime el número actual

            // Agrega una coma y un espacio si no es el último número
            if (i > 0)
                System.Console.Write(", ");
        }

        // Imprime una línea en blanco al final para que la salida sea más limpia
        System.Console.WriteLine();
    }
}