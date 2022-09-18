object o1 = "A"; // Se le asigna "A" a o1
object o2 = o1; // o2 toma el valor de la misma referencia que o1 (apuntando ambos a "A")
o2 = "Z"; // Cambia el valor de o2 -> Ahora contiene una nueva referencia a un valor "Z"
Console.WriteLine(o1 + " " + o2); // Imprime A Z
Console.ReadLine();
