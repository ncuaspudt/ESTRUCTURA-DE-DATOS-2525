/// Tarea semana 16 
/// Encuentro de vuelos baratos a partir de una base de datos
/// Clase vuelo
class Vuelo

{

// Atributos públicos: destino y precio del vuelo
    public string Destino;
    public double Precio;
// Constructor
    public Vuelo(string destino, double precio)
    {
        Destino = destino;
        Precio = precio;
    }


// Método para mostrar el vuelo como texto
    public override string ToString()
    {
        return Destino + " ($" + Precio + ")";
    }
}

class Program
{
    // Método 
    static void Main()
    {
        // Grafo como diccionario: ciudad -> lista de vuelos
        Dictionary<string, List<Vuelo>> grafo =
            new Dictionary<string, List<Vuelo>>();

        // Agregar vuelos (aristas del grafo)
        grafo["CDMX"] = new List<Vuelo> {
            new Vuelo("Quito", 1500),
            new Vuelo("Santo Domingo", 1200),
            new Vuelo("Manta", 1250)
        };

        grafo["Quito"] = new List<Vuelo> {
            new Vuelo("CDMX", 1400),
            new Vuelo("Santo Domingo", 1800)
        };

        grafo["Santo Domingo"] = new List<Vuelo> {
            new Vuelo("Manta", 1000)
        };

        grafo["Santo Domingo"] = new List<Vuelo> {
            new Vuelo("CDMX", 1300),
            new Vuelo("Quito", 1600)
        };

        Console.WriteLine("Aplicación: Vuelo más barato");

        // Mostrar grafo
        Console.WriteLine("\nVuelos disponibles:");
        foreach (string origen in grafo.Keys)
        {
            Console.Write(origen + " -> ");
            foreach (Vuelo v in grafo[origen])
            {
                Console.Write(v.ToString() + ", ");
            }
            Console.WriteLine();
        }

        // Consulta
        Console.Write("Ingresa ciudad origen: ");
        string origenInput = Console.ReadLine().Trim();

        Console.Write("Ingresa ciudad destino: ");
        string destinoInput = Console.ReadLine().Trim();

        if (grafo.ContainsKey(origenInput))
        {
            List<Vuelo> vuelos = grafo[origenInput];
            Vuelo masBarato = null;
// Recorre la lista de vuelos
            foreach (Vuelo v in vuelos)
            {
                if (v.Destino.ToLower() == destinoInput.ToLower())
                {
                    if (masBarato == null || v.Precio < masBarato.Precio)
                    {
                    // Se actualiza el vuelo más barato
                        masBarato = v;
                    }
                }
            }

            if (masBarato != null)
            {
            // Si encuentra el vuelo, aparece en la consola de depuración el vuelo más barato
                Console.WriteLine("Vuelo más barato: " + origenInput + " -> " + masBarato.ToString());
            }
            else
            {
                Console.WriteLine("No hay vuelos directos de " + origenInput + " a " + destinoInput + ".");
            }
        }
        else
        {
            Console.WriteLine("No hay vuelos desde " + origenInput + ".");
        }
    }
}
