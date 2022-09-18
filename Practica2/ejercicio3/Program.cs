int sum = 0;
int i = 1;
while (i <= 10)
{
    Console.WriteLine( sum += i++ );     
}

// ----------------------------------------------------------------------------------------------- //
//                                      Ejercicio 4                                               //
// ----------------------------------------------------------------------------------------------//

Console.WriteLine(args == null); // No se le pasan argumentos
Console.WriteLine(args.Length + "\n\n"); // Devuelve 0

// ----------------------------------------------------------------------------------------------- //
//                                  Ejercicio 5                                                   //
// ----------------------------------------------------------------------------------------------//

int[]? vector = new int[0]; 
// Esto da error --> Console.WriteLine (vector[0]);
if (vector != null) {
    Console.WriteLine("No le asigna el valor null: " + vector); // El vector queda inicializado, pero sin valor en vector[0];
} else { 
    Console.WriteLine("Le asigna el valor null");
}
Console.ReadKey();

