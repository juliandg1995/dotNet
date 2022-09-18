
// Medir el tiempo que toma ingresar parámetros a un string, utilizando la clase DateTime:

startTime = DateTime.Now;
StringBuilder parametros = new StringBuilder();
String espacio = " ";

Console.WriteLine("Medición usando StringBuilder");
foreach (var arg in args) {
    parametros.Append(arg);
    parametros.Append(espacio);
}

Console.WriteLine(parametros.ToString());
endTime = DateTime.Now; // Se utiliza el DateTime como instrucción para cronometrar el tiempo, tomando dos puntos de referencia

// Calculando el tiempo total con las referencias obtenidas:
Console.WriteLine(endTime.Subtract(startTime).Milliseconds);


//***************************************************************************************************************************************//

Console.WriteLine("Medición usando String");
startTime = DateTime.Now;
string p = " ";             // String Vacío
string space = " ";
// Crear una string que muestre todos los parametros ingresados
foreach (var arg in args) {
    p += arg + space;
}
Console.WriteLine(parametros);
endTime = DateTime.Now;
Console.WriteLine(endTime.Subtract(startTime).Milliseconds);

