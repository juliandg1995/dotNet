/*
Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están
bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena
de entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se
almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la extracción del
último paréntesis de apertura almacenado. Si durante el proceso se lee un paréntesis de cierre y
la pila está vacía, entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar
vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida.
*/

bool esBalanceada(String input){
    Stack<char> myStack = new Stack<char>();
    char aux; bool ok = true;

    foreach (char c in input)
    {
        switch(c) {
            case '(':
                myStack.Push(c);
                break;
            case ')':
                if (myStack.Count == 0){
                    ok = false;
                } else {
                    aux = myStack.Pop();
                }
                break;
            default:
                continue;
        }
        if (!ok)
            break;
    }
    if (myStack.Count != 0)
        ok = false;
    return ok;
}

Console.Write("Ingrese una expresión Matemática: "); String input = Console.ReadLine();

if (esBalanceada(input)){
    Console.WriteLine($"\nLa expresión {input} está balanceada");
} else {
    Console.Write($"\nLa expresión {input} no está balanceada");
}
Console.ReadKey();



