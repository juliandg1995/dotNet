Console.Write("Ingrese un año: \t"); int year = int.Parse(Console.ReadLine());
if (year % 4 == 0 && year % 100 != 0 ){
    Console.WriteLine("El año " + year + " es biciesto");
} else {
    Console.WriteLine("El año " + year + " no es biciesto");
}

Console.ReadLine();