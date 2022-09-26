DateTime fecha = new DateTime(1492,10,12,15,5,6,325);
Console.WriteLine("a) {0}", fecha);
Console.WriteLine("b) {0:d}", fecha);
Console.WriteLine("c) {0:D}", fecha);
Console.WriteLine($"d) {fecha:dddd d 'del mes de' MMMM 'del año' yyyy}");
Console.WriteLine($"e) {fecha:t}");
Console.WriteLine("f) {0:hh:mm:s fff}",fecha);

// El siguiente codigo sirve para calcular Años/Meses/Semanas/Días/Horas/Minutos/Segundos/Milisegundos
// En caso de querer agregar Años/Meses/Semanas/Días, se agregarn los parámetros al Format
double hours = 13.547;
TimeSpan t = TimeSpan.FromHours( hours ); // FromYears, FromMonths, FromDays, FromHours, FromMinutes, FromSeconds...

string answer = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s:{4:D3}ms", 
                t.Days,
                t.Hours, 
                t.Minutes, 
                t.Seconds, 
                t.Milliseconds);

Console.WriteLine("\n" + answer); 

Console.ReadLine();
