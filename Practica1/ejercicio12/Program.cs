using System;
String st;
Console.WriteLine("Ingrese un número: "); int num = int.Parse(st = Console.ReadLine());
Console.WriteLine("Los divisores de " + num + " son:\n");
for (int i = 1; i <= num; i++){
    if (num % i == 0){
        Console.Write(i + " | ");
    }
}

Console.ReadLine();