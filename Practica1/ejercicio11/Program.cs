using System;

Console.WriteLine("10/3 = " + 10 / 3);  // Si se usa "/" entre enteros, la operación sólo devuelve el valor entero de la división
Console.WriteLine("10.0/3 = " + 10.0 / 3);  // En cambio, si se utilizan doubles en la operación, el resultado será un double
Console.WriteLine("10/3.0 = " + 10 / 3.0);  // A los strings se les pueden concatenar números con el operador + 
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
Console.ReadLine();