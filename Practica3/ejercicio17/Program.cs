/*
Implementar un programa calculadora que calcule una expresión ingresada por el
usuario correspondiente a una operación binaria de las cuatro elementales
(ejemplo “44.5/456”,“456*45”, “549-12”, “54+6” ). 
Utilizar try/catch para validar los números y controlar cualquier tipo de excepción
que pudiese ocurrir en la evaluación de la expresión.
*/

Console.Write("Ingrese una operacion aritmetica: ");
string operacion = Console.ReadLine();
while (operacion != ""){
    try{
        char[] operadores = new char[]{'+','-','*','/'}; // Defino los operadores
        char operador = operacion[operacion.IndexOfAny(operadores)]; // Busco el operador calculando su índice
        string[] operandos = operacion.Split(operadores); // Como parámetro del split se utiliza el array definido con todos los posibles operadores
        int resultado = 0;
        int operando1 = int.Parse(operandos[0]);
        int operando2 = int.Parse(operandos[1]);
        switch(operador){
            case '+':
                resultado = operando1 + operando2;
                break;
            case '-':
                resultado = operando1 - operando2;
                break;
            case '*':
                resultado = operando1 * operando2;
                break;
            case '/':
                resultado = operando1 / operando2;
                break;
        }
        Console.WriteLine($"El resultado es {resultado}");
    }
    catch (System.Exception e){
        Console.WriteLine(e.Message);
    }
    finally{
        Console.Write("Ingrese una operacion aritmetica: ");
        operacion = Console.ReadLine();
    }
}
Console.WriteLine("Ejecución finalizada");
Console.ReadLine();
