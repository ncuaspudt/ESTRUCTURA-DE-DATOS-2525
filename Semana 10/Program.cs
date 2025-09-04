// Universidad estal amazónica
// El Gobierno Nacional, a través del Ministerio de Salud, requiere información sobre la campaña de vacunación contra el COVID-19.
// Ciudadanos que no se han vacunado.
// Ciudadanos que han recibido ambas dosis.
// Ciudadanos que solo han recibido la vacuna de Pfizer.
// Ciudadanos que solo han recibido la vacuna de AstraZeneca
// Clase Programa
class Program
{
    static void Main()
    {
        Vacunas.Run();
    }
}
//Clase Vacunas
public class Vacunas
{
    public static void Run()
    {
        Random random = new Random();

        // Crear 500 ciudadanos "Ciudadano 1" a "Ciudadano 500"
        HashSet<string> todos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todos.Add("Ciudadano " + i);
        }

        // Convertir a lista para selección aleatoria
        List<string> listaCiudadanos = new List<string>(todos);

        // Seleccionar 75 vacunados Pfizer únicos
        HashSet<string> pfizer = new HashSet<string>();
        while (pfizer.Count < 75)
        {
            int index = random.Next(listaCiudadanos.Count);
            pfizer.Add(listaCiudadanos[index]);
        }

        // Seleccionar 75 vacunados AstraZeneca únicos
        HashSet<string> astraZeneca = new HashSet<string>();
        while (astraZeneca.Count < 75)
        {
            int index = random.Next(listaCiudadanos.Count);
            astraZeneca.Add(listaCiudadanos[index]);
        }
        // Ciudadanos con ambas dosis (intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Ciudadanos solo Pfizer (diferencia)
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Ciudadanos solo AstraZeneca (diferencia)
        HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // Ciudadanos vacunados (unión)
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        // Ciudadanos no vacunados (todos menos vacunados)
        HashSet<string> noVacunados = new HashSet<string>(todos);
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
