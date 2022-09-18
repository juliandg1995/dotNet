/*
Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo
de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en
la misma línea en la consola.
*/

void ImprimirMatriz(double[,] matriz){
    int rows = matriz.GetLength(0);
    int col = matriz.GetLength(1);
    // Console.WriteLine("Rows: " + rows + " - Cols: " + col);
    for (int i = 0; i < rows; i++){
        Console.Write("Fila " + (i + 1) + ": ");
        for (int j = 0; j < col; j++){
            Console.Write(matriz[i,j] + " - ");
        }
        Console.Write("\n");
    }
}

double[,] matriz = new double[,] { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
ImprimirMatriz(matriz);

ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End){
    k = Console.ReadKey();
}

