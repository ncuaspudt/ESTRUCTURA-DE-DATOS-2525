// Función que calcule el número de elementos de una lista.
// Clase que representa un nodo
public class Nodo
{
    public int Data;  //Valor entero
    public Nodo Next; //Siguiente Nodo de la lista
    // Constructor
    public Nodo(int Data)
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
        head= null      //La lista inicializa sin nodos.
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
        Nodo nuevoNodo = new Nodo(dato);
        if (head == null)
        {
            head = nuevoNodo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevoNodo;
        }
    }
    public void EliminarInicio()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }
    public void EliminarFinal()
    {
        if (head != null)
        {
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Nodo actual = head;
                while (actual.Next != null)
                {
                    actual = actual.Next;
                }
                actual.Next = null;
            }
        }
    }
    public Nodo? Buscar(int dato)
    {
        Nodo? actual = head;
        if (head != null)
            while (actual != null && actual.Data != dato)
            {
                actual = actual.Next;
            }
        return actual;
    }
    public void DibujarLista()
    {
        Nodo? actual = head;
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
        System.Console.Write(" --> null");
        System.Console.WriteLine();
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            lista.InsertarInicio(2);
            lista.InsertarInicio(3);
            lista.InsertarInicio(100);
            lista.InsertarFinal(20);
            lista.InsertarFinal(230);
            lista.DibujarLista();
        }
    }
}