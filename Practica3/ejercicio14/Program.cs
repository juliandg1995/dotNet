/*
Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base
10 a otra base realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario
dividimos sucesivamente por dos hasta encontrar un cociente menor que el divisor, luego el
resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por
todos los restos.
*/

Stack<int> convertir(int nro, int b, Stack<int> myStack){
    if (nro < b){
        myStack.Push(nro);
        return myStack;
    }
        myStack.Push(nro % b);
        return myStack = convertir((nro / b), b, myStack);
}

String convertirABase(int b, int nro){
    Dictionary<int,string> letras = new Dictionary<int, string>()
    {
        {10,"A"}, {11,"B"}, {12,"C"}, {13,"D"}, {14,"E"}, {15,"F"}
    };
     String? resultado = null;
     // Creates and initializes a new Stack.
      Stack<int> myStack = new Stack<int>();
      myStack = convertir(nro,b,myStack);
      while (myStack.Count != 0){
        dynamic valor = myStack.Pop();
        if (valor >= 10){
            valor = letras[valor];
        }
        resultado = $"{resultado}{valor}";
      }
      return $"\nEl numero {nro}(10 en sistema base {b} es: {resultado}";
}

Console.WriteLine("Ingrese un nro: "); int nro = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un nro para la nueva base: "); int basee = int.Parse(Console.ReadLine());

if (nro != null && basee != null){
    Console.WriteLine(convertirABase(basee, nro));
}

Console.WriteLine("\nPresione 'Enter' para finalizar ");
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.Enter) {
    k = Console.ReadKey(true);
}



