// Programa que pide al usuario una palabra y muestra cuántas veces aparece cada vocal
System.Console.WriteLine("Escribe una palabra:");
string palabra = (System.Console.ReadLine() ?? "").ToLower();

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
System.Console.WriteLine("Número de vocales en la palabra:");
System.Console.WriteLine("a: " + a);
System.Console.WriteLine("e: " + e);
System.Console.WriteLine("i: " + i);
System.Console.WriteLine("o: " + o);
System.Console.WriteLine("u: " + u);