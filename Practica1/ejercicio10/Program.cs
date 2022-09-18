using System;
Console.WriteLine("Múltiplos de 19 y 27 entre el numero 1 y el 1000: \n");
for (int i = 1; i <= 1000; i++){
    if (i % 19 == 0 || i % 27 == 0){
        Console.Write(i + " - ");
    }
}

Console.ReadLine();
