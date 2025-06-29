
// Programa que almacena en una lista los números del 1 al 10 y los imprime en forma ordinal descendente.

class Programa
{
    // Método principal del programa
    static void Main()
    {
        // Mostrar encabezado
        System.Console.WriteLine("Universidad Estatal Amazónica");
        System.Console.WriteLine("Carrera de Tecnologías de la Información");
        System.Console.WriteLine("Nubia Cuaspud");
        System.Console.WriteLine("======================");

        // Crear lista para almacenar los números del 1 al 10
        System.Collections.Generic.List<int> numeros = new System.Collections.Generic.List<int>();

        // Llenar la lista con los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar los números en orden descendente con ordinales
        System.Console.WriteLine("Números ordinales descendentes:");

        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            System.Console.Write(ConvertirOrdinal(numeros[i]));

            if (i > 0)
                System.Console.Write(", ");
        }

        System.Console.WriteLine(); // Salto de línea final
    }

    // Método auxiliar que convierte un número en su forma ordinal (ej. 1.º, 2.º, etc.)
    static string ConvertirOrdinal(int numero)
    {
        return numero + ".º";
    }
}
