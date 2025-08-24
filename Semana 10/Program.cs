class Program
{
    static void Main()
    {
        Vacunas.Run();
    }
}

public class Vacunas
{
    public static void Run()
    {
        System.Random random = new System.Random();

        // Crear 500 ciudadanos "Ciudadano 1" a "Ciudadano 500"
        System.Collections.Generic.HashSet<string> todos = new System.Collections.Generic.HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todos.Add("Ciudadano " + i);
        }

        // Convertir a lista para selección aleatoria
        System.Collections.Generic.List<string> listaCiudadanos = new System.Collections.Generic.List<string>(todos);

        // Seleccionar 75 vacunados Pfizer únicos
        System.Collections.Generic.HashSet<string> pfizer = new System.Collections.Generic.HashSet<string>();
        while (pfizer.Count < 75)
        {
            int index = random.Next(listaCiudadanos.Count);
            pfizer.Add(listaCiudadanos[index]);
        }

        // Seleccionar 75 vacunados AstraZeneca únicos
        System.Collections.Generic.HashSet<string> astraZeneca = new System.Collections.Generic.HashSet<string>();
        while (astraZeneca.Count < 75)
        {
            int index = random.Next(listaCiudadanos.Count);
            astraZeneca.Add(listaCiudadanos[index]);
        }

        // Ciudadanos con ambas dosis (intersección)
        System.Collections.Generic.HashSet<string> ambasDosis = new System.Collections.Generic.HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Ciudadanos solo Pfizer (diferencia)
        System.Collections.Generic.HashSet<string> soloPfizer = new System.Collections.Generic.HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Ciudadanos solo AstraZeneca (diferencia)
        System.Collections.Generic.HashSet<string> soloAstraZeneca = new System.Collections.Generic.HashSet<string>(astraZeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // Ciudadanos vacunados (unión)
        System.Collections.Generic.HashSet<string> vacunados = new System.Collections.Generic.HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        // Ciudadanos no vacunados (todos menos vacunados)
        System.Collections.Generic.HashSet<string> noVacunados = new System.Collections.Generic.HashSet<string>(todos);
        noVacunados.ExceptWith(vacunados);

        // Mostrar resultados
        System.Console.WriteLine("Total ciudadanos: " + todos.Count);
        System.Console.WriteLine("Vacunados con Pfizer: " + pfizer.Count);
        System.Console.WriteLine("Vacunados con AstraZeneca: " + astraZeneca.Count);
        System.Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count);
        System.Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        System.Console.WriteLine("Solo AstraZeneca: " + soloAstraZeneca.Count);
        System.Console.WriteLine("No vacunados: " + noVacunados.Count);

        // Mostrar listado completo de ciudadanos no vacunados
        System.Console.WriteLine("\nListado completo de ciudadanos no vacunados:");
        foreach (var ciudadano in noVacunados)
        {
            System.Console.WriteLine(ciudadano);
        }
    }
}




