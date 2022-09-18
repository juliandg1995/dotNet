void Swap(int a, int b){
    Console.WriteLine("Valores originales\nA): " + a + "\nB): " + b + "\n");
    int aux = a;
    a = b; b = aux;
    Console.WriteLine("Valores actuales\nA): " + a + "\nB): " + b + "\n");
}

Swap(3, 6);

Console.ReadKey();
