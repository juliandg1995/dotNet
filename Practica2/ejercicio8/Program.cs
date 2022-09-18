
Console.WriteLine("Ingresar parámetros utilizando un FOR y un FOREACH:");
for (int i = 0; i < args.Length; i++) {
    Console.WriteLine("Parámetro con for: ",args[i]);
}

foreach (var arg in args){
    Console.WriteLine($"Con Foreach: {arg}");
}
Console.ReadLine();