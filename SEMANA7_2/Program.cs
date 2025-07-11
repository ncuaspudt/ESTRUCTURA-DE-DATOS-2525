// Problema de las Torres de Hanoi
// El programa muestra paso a paso como se mueven los discos entre las torres
//Clase programa
class Program
{
    // Pilas que representan las tres torres
    static System.Collections.Stack torreA = new System.Collections.Stack();
    static System.Collections.Stack torreB = new System.Collections.Stack();
    static System.Collections.Stack torreC = new System.Collections.Stack();

    // Método principal
    static void Main()
    {
        System.Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(System.Console.ReadLine());

        // Llenar la torre A con los discos (de mayor a menor)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        ImprimirTorres();
        MoverDiscos(n, torreA, torreC, torreB, "A", "C", "B");
    }

    // Método recursivo que simula el movimiento de los discos
    static void MoverDiscos(int n, System.Collections.Stack origen, System.Collections.Stack destino, System.Collections.Stack auxiliar,
                            string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = (int)origen.Pop();
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

    // Muestra el estado actual de las torres
    static void ImprimirTorres()
    {
        System.Console.WriteLine("\nEstado de las torres:");
        MostrarTorre("A", torreA);
        MostrarTorre("B", torreB);
        MostrarTorre("C", torreC);
        System.Console.WriteLine("------------------------------\n");
    }

    // Imprime una torre específica
    static void MostrarTorre(string nombre, System.Collections.Stack torre)
    {
        System.Console.Write(nombre + ": ");
        foreach (int disco in torre)
        {
            System.Console.Write(disco + " ");
        }
        System.Console.WriteLine();
    }
}
