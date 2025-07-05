// Crear una lista enlazada con 50 números enteros, del 1 al 999 generados aleatoriamente. 
// Se deben eliminar los nodos que estén fuera rango de valores leídos desde el teclado.
// Clase que representa un nodo
public class Nodo
{
    public int Data;                  //Valor entero
    public Nodo Next;                 //Siguiente Nodo de la lista
 // Constructor
    public Nodo(int data)
    {
        Data = data;                  //Representa el valor almacenado          
        Next = null;                  // Apunta a null, por lo tanto hace referencia al último nodo de la listas.
    }
}

//  Clase enlazada ListaSimple
public class ListaSimple
{
    Nodo head;                       //Primer nodo de la lista.
//Constructor que inicializa un alista vacía.
    public ListaSimple()
    {
        head = null;                  //La lista inicializa sin nodos.
    }
// Método para insertar un nuevo nodo al final de la lista.
    public void InsertarFinal(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);            // Crea nuevo nodo
        if (head == null)                           // Si la lista esta vacía
        {
            head = nuevoNodo;                       //Nuevo nodo es la cabeza
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)              // Recorre de nodo en nodo hasta el último.
            {
                actual = actual.Next;
            }
            actual.Next = nuevoNodo;                   // Apunta el nodo actual al nuevo
        }
    }

    public void DibujarLista()
    {
        Nodo actual = head;
        System.Console.Write("head -->");
        while (actual != null)
        {
            System.Console.Write(" [ " + actual.Data + " | * ]");
            if (actual.Next != null)
            {
                System.Console.Write(" -->");
            }
            actual = actual.Next;
        }
        System.Console.Write(" --> null\n");
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = head;
        while (actual != null)
        {
            contador++;
            actual = actual.Next;
        }
        return contador;
    }

    // Método para eliminar nodos fuera del rango [min, max]
    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar nodos del principio que estén fuera del rango
        while (head != null && (head.Data < min || head.Data > max))
        {
            head = head.Next;
        }

        Nodo actual = head;
        while (actual != null && actual.Next != null)
        {
            if (actual.Next.Data < min || actual.Next.Data > max)
            {
                actual.Next = actual.Next.Next;
            }
            else
            {
                actual = actual.Next;
            }
        }
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        System.Random rnd = new System.Random();

        // Agregar 50 números aleatorios del 1 al 999
        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000);
            lista.InsertarFinal(numero);
        }

        // Mostrar lista inicial
        System.Console.WriteLine("Lista original:");
        lista.DibujarLista();

        // Leer rango desde teclado
        System.Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(System.Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(min, max);

        // Mostrar lista final
        System.Console.WriteLine("\nLista después de eliminar nodos fuera del rango:");
        lista.DibujarLista();

        int total = lista.ContarElementos();
        System.Console.WriteLine("\nCantidad de nodos en la lista: " + total);
    }
}
