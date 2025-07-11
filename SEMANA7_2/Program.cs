//  Problema de las Torres de Hanoi
//Clase programa
class Program
{
    // Método para mover los discos entre torres
    static void MoverDiscos(int n, System.Collections.Stack origen, System.Collections.Stack destino, System.Collections.Stack auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = (int)origen.Pop(); // Cast necesario porque Stack es no genérica
            destino.Push(disco);
            System.Console.WriteLine("Mover disco " + disco + " de " + nombreOrigen + " a " + nombreDestino);
            ImprimirTorres();
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            MoverDiscos(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    // Torres como pilas clásicas
    static System.Collections.Stack torreA = new System.Collections.Stack();
    static System.Collections.Stack torreB = new System.Collections.Stack();
    static System.Collections.Stack torreC = new System.Collections.Stack();

    // Muestra el estado actual de las torres
    static void ImprimirTorres()
    {
        System.Console.WriteLine("Estado actual de las torres:");
        MostrarTorre("A", torreA);
        MostrarTorre("B", torreB);
        MostrarTorre("C", torreC);
        System.Console.WriteLine("-----------------------------");
    }

    // Imprime los discos en una torre
    static void MostrarTorre(string nombre, System.Collections.Stack torre)
    {
        System.Console.Write(nombre + ": ");
        foreach (int disco in torre)
        {
            System.Console.Write(disco + " ");
        }
        System.Console.WriteLine();
    }

    // Función principal
    static void Main()
    {
        System.Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(System.Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        ImprimirTorres();
        MoverDiscos(n, torreA, torreC, torreB, "A", "C", "B");
    }
}