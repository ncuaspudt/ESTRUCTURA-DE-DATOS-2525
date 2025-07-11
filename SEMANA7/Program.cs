

class Program
{
    // Función que verifica si los paréntesis, corchetes y llaves están balanceados
    static bool EstaBalanceado(string expresion)
    {
        // Creamos una pila para almacenar los símbolos de apertura
        System.Collections.Generic.Stack<char> pila = new System.Collections.Generic.Stack<char>();

        // Recorremos cada carácter de la expresión
        for (int i = 0; i < expresion.Length; i++)
        {
            char c = expresion[i];

            // Si es símbolo de apertura, lo agregamos a la pila
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

                // Sacamos el último símbolo de apertura
                char tope = pila.Pop();

                // Verificamos si el símbolo abierto coincide con el cerrado
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
        System.Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = System.Console.ReadLine();

        // Evaluamos si la expresión está balanceada
        if (EstaBalanceado(expresion))
        {
            System.Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            System.Console.WriteLine("Fórmula no balanceada.");
        }
    }
}