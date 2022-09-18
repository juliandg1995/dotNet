using System;
using System.Globalization;

Double doubleVal = 0;
Console.Write("Ingrese dos números reales para ser sumados:"); 
String st1 =  Console.ReadLine(); 
String st2 =  Console.ReadLine();
double sum = double.Parse(st1, CultureInfo.InvariantCulture) + double.Parse(st2, CultureInfo.InvariantCulture); // Sin CultureInfo.InvariantCulture el Parse no funcionaba
Console.WriteLine("La suma entre " + st1 + " y " + st2 + " es: " + sum);
Console.ReadLine();
