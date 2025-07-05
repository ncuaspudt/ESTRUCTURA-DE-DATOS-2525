// Función que calcule el número de elementos de una lista.
// Clase que representa un nodo
public class Nodo

{
    public int Data;  //Valor entero
    public Nodo Next; //Siguiente Nodo de la lista
    // Constructor
    public Nodo(int data)
    {
        Data = data;     //Representa el valor almacenado
        Next = null;     // Apunta a null, por lo tanto hace referencia al último nodo de la listas.
    }
  }
// clase de lista enlazada simple
public class ListaSimple
{
    Nodo head;           //Primer nodo de la lista.
    // Constructor para iniciar una lista vacia.
    public ListaSimple()
    {
        head = null;      //La lista inicializa sin nodos.
    }

    // Inserta un nuevo nodo en la lista del inicio.
    public void InsertarInicio(int dato)
    {
        var nuevoNodo = new Nodo(dato);              //Crea un nuevo nodo
        nuevoNodo.Next = head;
        head = nuevoNodo;
    }
    // Inserta un nuevo nodo al final de la lista.
    public void InsertarFinal(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);             // Crea nuevo nodo
        if (head == null)                            // Si la lista esta vac{ia}
        {
            head = nuevoNodo;                        //Nuevo nodo es la cabeza
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)               // Recorre de nodo en nodo hasta el último.
            {
                actual = actual.Next;
            }
            actual.Next = nuevoNodo;                  // Apunta el nodo actual al nuevo
        }
    }
    // Elimina el nodo que esta al inicio de la lista
    public void EliminarInicio()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }
    // Elimina el nodo que esta al final de la lista  
    public void EliminarFinal()
    {
        if (head != null)                      // Si la lista está vacía
        {
            if (head.Next == null)             // Si solo hay un nodo
            {
                head = null;                   // Lista vacía
            }
            else
            {
                Nodo actual = head;
                // Recorre los nodos
                while (actual.Next.Next != null)
                {
                    actual = actual.Next;
                }
                actual.Next = null;
            }
        }
    }
    // Busca el nodo
    public Nodo Buscar(int dato)
    {
        Nodo actual = head;
        if (head != null)
            while (actual != null && actual.Data != dato)
            {
                actual = actual.Next;   // Avanza al siguiente nodo
            }
        return actual;                  // Devuelve el nodo encontrado en null
    }
    //Imprime la lista en consola
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
            actual = actual.Next;                   //Avanza al siguiente nodo
        }
        System.Console.Write(" --> null");
        System.Console.WriteLine();
    }
    // Cuenta y devuelve el número de nodos.
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = head;
        while (actual != null)
        {
            contador++;
            actual = actual.Next;                   //Avanza al siguiente nodo.
        }
        return contador;
    }
}
//Clase para ejecutar el programa 
    class Program
    {
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        //Insertar nodos al inicio
        lista.InsertarInicio(3);
        lista.InsertarInicio(4);
        lista.InsertarInicio(200);
        // Insetar nodos al final
        lista.InsertarFinal(30);
        lista.InsertarFinal(240);
        //Muestra lista en consola
        lista.DibujarLista();
        // Contar nodos y mostrar resultado en consola.
        int total = lista.ContarElementos();
        System.Console.WriteLine("Cantidad de nodos en la lista: " + total);
        }
    }

