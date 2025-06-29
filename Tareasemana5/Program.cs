
/// Programa que almacene en una lista los números del 1 al 10, separados por una coma. 
// Función que convierte un número entero a su forma ordinal corta
// Función que convierte un número entero a su forma ordinal corta
string ConvertirOrdinal(int numero)
{
    return numero + ".º";
}

// Crear una lista para almacenar los números del 1 al 10
var numeros = new System.Collections.Generic.List<int>();

// Llenar la lista con los números del 1 al 10
for (int i = 0; i <= 10; i++)
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

System.Console.WriteLine(); // Para finalizar con salto de línea