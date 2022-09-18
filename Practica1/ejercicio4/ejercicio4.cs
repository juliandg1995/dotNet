using System;

String st;

Console.WriteLine("Ingrese su nombre: "); st = Console.ReadLine();
if (st.strlen() == 0){
    Console.WriteLine("Hola Mundo!");
} else {
    Console.WriteLine('Hola ' + st );
}

Console.ReadLine();
