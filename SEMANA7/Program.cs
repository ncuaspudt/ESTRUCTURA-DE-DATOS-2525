//Verificación de paréntesis balanceados en una expresión matemática 
//Clase programa
class Program
{
    // Método que verifica si la expresión está balanceada
    static bool EstaBalanceado(string expresion)
    {
        // Creamos una pila clásica que almacena objetos
        System.Collections.Stack pila = new System.Collections.Stack();

        // Avanza desde el primer hasta el último carácter.
        for (int i = 0; i < expresion.Length; i++)
        {
            char c = expresion[i];

            // Si es símbolo de apertura
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no hay símbolo de apertura correspondiente
                if (pila.Count == 0)
                {
                    return false;
                }

                // Saque el último símbolo de apertura 
                char tope = (char)pila.Pop();

                // Se verifica la coincidencia del simbolo abierto y cerrado.
                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    return false;
                }
            }
        }

        // Si la pila queda vacía, entonces todos los símbolos fueron cerrados correctamente
        return pila.Count == 0;
    }

    // Función principal
    static void Main(string[] args)
    {
        // Solicitamos la expresión al usuario
        System.Console.WriteLine("Ingrese la expresión matemática asignada por el docente:");
        string expresion = System.Console.ReadLine();

        // Evaluamos si la expresión está balanceada
        if (EstaBalanceado(expresion))
        {
            // Imprime fórmula balanceada al ingresar la expresión matemática
            System.Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            // Imprime fórmula no balanceada en caso de error en en expresión matemática.
            System.Console.WriteLine("Fórmula no balanceada.");
        }
    }
}