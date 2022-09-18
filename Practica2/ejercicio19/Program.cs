void Imprimir(params Object[] datos){
    foreach(Object dato in datos){
        Console.Write(dato.ToString() + " ");
    }
    Console.Write("\n");
}

Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
Imprimir(1, 2, "tres");
Imprimir();
Imprimir("-------------");

Console.ReadKey();
