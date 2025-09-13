// Universidad Estatal Amazónica
// Tarea semana 13
// Clase para iniciar el programa
public class Catalogo
{
    public nodo hi;
    public nodo hd;
    public nodo valor;
}
void insert (int value)
{
if(root==NULL)
root = new Node (value);
else
insertHelper(root, value);
{
void insertHelper(Node*node, int value)
{
    if (value < node->Key)
    {
        if (node->LeftChild==NULL)
        node->LeftChild== new Node (value);
        else
        insertHelper(node->LeftChild, value);
    }
    else
    {
     if (node->righChild==NULL)
     node->righChild==new Node (value);
     else
     insertHelper(node->righChild, value); 
    }
}
// Creamos un BST
ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
// ... (Insertar nodos en el árbol)
// Buscar un valor
bool encontrado = arbol.Buscar(10);
if (encontrado)
{
 Console.WriteLine("El valor se encontró en el árbol");
}
else
{
 Console.WriteLine("El valor no se encontró en el árbol");
}
public class ArbolBinarioBusqueda
{
 private Nodo raiz;
 public bool Buscar(int valor)
 {
 Nodo actual = raiz;
 while (actual != null)
 {
 if (valor == actual.Valor)
 {
 return true; // Valor encontrado
 }
 else if (valor < actual.Valor)
 {
 actual = actual.Izquierdo;
 }
 else
 {
 actual = actual.Derecho;
 }
 }
 return false; // Valor no encontrado
 }
}
// Creamos un BST
ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
// ... (Insertar nodos en el árbol)
// Buscar un valor
bool encontrado = arbol.Buscar(10);
if (encontrado)
{
 Console.WriteLine("El valor se encontró en el árbol");
}
else
{
 Console.WriteLine("El valor no se encontró en el árbol");
}
public class ArbolBinarioBusqueda
{
 private Nodo raiz;
 public int EncontrarMinimo()
 {
 Nodo actual = raiz;
 while (actual.Izquierdo != null)
 {
 actual = actual.Izquierdo;
 }
 return actual.Valor;
 }
}
// Creamos un BST
ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
// ... (Insertar nodos en el árbol)
// Encontrar el mínimo
int minimo = arbol.EncontrarMinimo();
Console.WriteLine("El valor mínimo es: " + minimo);
public class ArbolBinarioBusqueda
{
 private Nodo raiz;
 public int EncontrarMaximo()
 {
 Nodo actual = raiz;
 while (actual.Derecho != null)
 {
 actual = actual.Derecho;
 }
 return actual.Valor;
 }
}
// Creamos un BST
ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
// ... (Insertar nodos en el árbol)
// Encontrar el máximo
int maximo = arbol.EncontrarMaximo();
Console.WriteLine("El valor máximo es: " + maximo);