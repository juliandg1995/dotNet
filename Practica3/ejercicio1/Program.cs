Console.CursorVisible = false; // Hace que no se muestre el cursor en consola
ConsoleKeyInfo k = Console.ReadKey(true); // True = Hace que no se muestre la tecla presionada en consola -- False = la muestra
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true); 
}

// Este programa muestra los códigos de cada tecla presionada, hasta que se oprima la tecla "Fin"