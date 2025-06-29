using System;
Console.WriteLine("Escribe una palabra:");
string palabra = (Console.ReadLine() ?? "").ToLower();

// Contadores de vocales
int a = 0, e = 0, i = 0, o = 0, u = 0;

// Recorre cada letra de la palabra
foreach (char c in palabra)
{
    if (c == 'a') a++;
    else if (c == 'e') e++;
    else if (c == 'i') i++;
    else if (c == 'o') o++;
    else if (c == 'u') u++;
}

// Muestra resultados
Console.WriteLine("Número de vocales en la palabra:");
Console.WriteLine("a: " + a);
Console.WriteLine("e: " + e);
Console.WriteLine("i: " + i);
Console.WriteLine("o: " + o);
Console.WriteLine("u: " + u);