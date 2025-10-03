class Vuelo
{
    public string Destino;
    public double Precio;

    public Vuelo(string destino, double precio)
    {
        Destino = destino;
        Precio = precio;
    }





    public override string ToString()
    {
        return Destino + " ($" + Precio + ")";
    }
}

class Program
{
    static void Main()
    {
        // Grafo como diccionario: ciudad -> lista de vuelos
        System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Vuelo>> grafo =
            new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Vuelo>>();

        // Agregar vuelos (aristas del grafo)
        grafo["CDMX"] = new System.Collections.Generic.List<Vuelo> {
            new Vuelo("Cancún", 1500),
            new Vuelo("Guadalajara", 1200),
            new Vuelo("Monterrey", 1250)
        };

        grafo["Cancún"] = new System.Collections.Generic.List<Vuelo> {
            new Vuelo("CDMX", 1400),
            new Vuelo("Guadalajara", 1800)
        };

        grafo["Guadalajara"] = new System.Collections.Generic.List<Vuelo> {
            new Vuelo("Monterrey", 1000)
        };

        grafo["Monterrey"] = new System.Collections.Generic.List<Vuelo> {
            new Vuelo("CDMX", 1300),
            new Vuelo("Cancún", 1600)
        };

        System.Console.WriteLine("Aplicación: Vuelo más barato (con grafos)");

        // Mostrar grafo
        System.Console.WriteLine("\nVuelos disponibles:");
        foreach (string origen in grafo.Keys)
        {
            System.Console.Write(origen + " -> ");
            foreach (Vuelo v in grafo[origen])
            {
                System.Console.Write(v.ToString() + ", ");
            }
            System.Console.WriteLine();
        }

        // Consulta
        System.Console.Write("\nIngresa ciudad origen: ");
        string origenInput = System.Console.ReadLine().Trim();

        System.Console.Write("Ingresa ciudad destino: ");
        string destinoInput = System.Console.ReadLine().Trim();

        if (grafo.ContainsKey(origenInput))
        {
            System.Collections.Generic.List<Vuelo> vuelos = grafo[origenInput];
            Vuelo masBarato = null;

            foreach (Vuelo v in vuelos)
            {
                if (v.Destino.ToLower() == destinoInput.ToLower())
                {
                    if (masBarato == null || v.Precio < masBarato.Precio)
                    {
                        masBarato = v;
                    }
                }
            }

            if (masBarato != null)
            {
                System.Console.WriteLine("\nVuelo más barato: " + origenInput + " -> " + masBarato.ToString());
            }
            else
            {
                System.Console.WriteLine("\nNo hay vuelos directos de " + origenInput + " a " + destinoInput + ".");
            }
        }
        else
        {
            System.Console.WriteLine("\nNo hay vuelos desde " + origenInput + ".");
        }
    }
}
