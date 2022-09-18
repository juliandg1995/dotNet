// Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la
// matriz pasada como parámetro:

double[][] fillJaggedArray(double[,] mat){
    //Declaración del "Array de Arrays":
    double[][] jaggedArray = new double[mat.GetLength(0)][];

    for (int i = 0; i < mat.GetLength(0); i++){         // Para obtener el Length de un array/matriz se usa el método GetLenth()
        jaggedArray[i] = new double[mat.GetLength(1)];  // Antes de usar el array de arrays hay que inicializar cada fila
        for (int j = 0; j < mat.GetLength(1); j++){
            jaggedArray[i][j] = mat[i,j];
        }
    }
    return jaggedArray;
}

void printJaggedArray (double[][] jagged_arr){
     for (int n = 0; n < jagged_arr.Length; n++) {
        // Print the row number
        System.Console.Write("Row({0}): ", n);

        for (int k = 0; k < jagged_arr[n].Length; k++) {
            // Print the elements in the row
            System.Console.Write("{0} ", jagged_arr[n][k]);
        }
        System.Console.WriteLine();
    }
}
// int getColumnLength(double[][] jaggedArray, int columnIndex) {
//     int count = 0;
//     foreach (double[] row in jaggedArray) {
//         if (columnIndex < row.Length) count++;
//     }
//     return count;
// }

// Matriz
double[,] matriz = new double[4,4]{
   {0, 1, 2, 3} ,
   {4, 5, 6, 7} ,
   {8, 9, 10, 11} ,
   {12, 13, 14, 15}
};

// Imprimo el Array de Arrays:
printJaggedArray(fillJaggedArray(matriz));

Console.WriteLine("\nPresione 'Enter' para finalizar ");
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.Enter) {
    k = Console.ReadKey(true);
}
