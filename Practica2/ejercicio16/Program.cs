Console.WriteLine("Ingrese un nro para calcular su factorial: "); 
int nro = int.Parse(args[0]);

// No recursiva
int Factorial(int numero) {
    if (numero == 0){
        return 1;
    }
    int resultado = numero;
    for (int i = (numero - 1); i >= 1 ; i--){
        resultado = resultado * i;
    }
    return resultado;
}

// recursiva
int FactorialRecursivo(int nro){
    if (nro == 0){
        return 1;
    }
    return nro * FactorialRecursivo(nro - 1);
}

int resultado = Factorial(nro);
Console.WriteLine("El factorial de " + nro + " usando función no recursiva es: " + resultado );

resultado = FactorialRecursivo(nro);
Console.WriteLine("El factorial de " + nro + " usando función recursiva es: " + resultado );

resultado = (nro == 1) ? 1 : FactorialRecursivo(nro);
Console.WriteLine("El factorial de " + nro + " usando función recursiva con ternario es: " + resultado );

Console.ReadLine();