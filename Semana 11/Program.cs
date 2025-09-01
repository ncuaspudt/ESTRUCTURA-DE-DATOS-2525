// Aplicación en C# que funcione como traductor básico entre los idiomas de ingles y español mediante el uso de diccionarios.
// Clase  traductor básico
public class TraductorBasico
{
// Método principal 
    public static void run()
    {
// Se implementa un diccionario con palabras en español con su respectiva traducción.
        System.Collections.Generic.Dictionary<string, string> diccionario = new System.Collections.Generic.Dictionary<string, string>()
        {
            { "tiempo", "time" },
            { "persona", "person" },
            { "año", "year" },
            { "camino", "way" },
            { "día", "day" },
            { "cosa", "thing" },
            { "hombre", "man" },
            { "mundo", "world" },
            { "vida", "life" },
            { "mano", "hand" },
            { "parte", "part" },
            { "niño", "child" },
            { "ojo", "eye" },
            { "mujer", "woman" },
            { "lugar", "place" },
            { "trabajo", "work" },
            { "semana", "week" },
            { "caso", "case" },
            { "punto", "point" },
            { "gobierno", "government" },
            { "empresa", "company" }
        };

        int opcion = -1;

        while (opcion != 0)

    // Se imprime para vizualizar en la Consola de depuración el menu
        {
            System.Console.WriteLine("==================== MENÚ ====================");
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");

            string entrada = System.Console.ReadLine();
            int.TryParse(entrada, out opcion);

            if (opcion == 1)
            {
                System.Console.Write("Ingrese la frase en español: ");
                string frase = System.Console.ReadLine();

                string[] palabras = frase.Split(' ');

                for (int i = 0; i < palabras.Length; i++)
                {
                    string original = palabras[i];
                    string palabraLimpia = original.ToLower().Trim(',', '.', ';', ':', '!', '?');

                    if (diccionario.ContainsKey(palabraLimpia))
                    {
                        string traduccion = diccionario[palabraLimpia];

                        if (original.EndsWith(".") || original.EndsWith(",") || original.EndsWith("!") || original.EndsWith("?"))
                        {
                            traduccion += original.Substring(original.Length - 1);
                        }

                        palabras[i] = traduccion;
                    }
                }

                string resultado = string.Join(" ", palabras);
                System.Console.WriteLine("Traducción: " + resultado);
            }
            else if (opcion == 2)
            {
                System.Console.Write("Palabra en español: ");
                string esp = System.Console.ReadLine().ToLower();

                System.Console.Write("Traducción en inglés: ");
                string eng = System.Console.ReadLine().ToLower();

                if (!diccionario.ContainsKey(esp))
                {
                    diccionario.Add(esp, eng);
                    System.Console.WriteLine("Palabra agregada correctamente.");
                }
                else
                {
                    System.Console.WriteLine("Esa palabra ya está en el diccionario.");
                }
            }
            else if (opcion == 0)
            {
                System.Console.WriteLine("Saliendo...");
            }
            else
            {
                System.Console.WriteLine("Opción no válida.");
            }

            System.Console.WriteLine();
        }
    }
}

public class Ejecutar
{
    public static void Main()
    {
        TraductorBasico.run();
    }
}