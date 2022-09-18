double[,]? Suma(double[,] A, double[,] B){
    if(A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1)){
        double[,] resultado = new double[A.GetLength(0),A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++){         
            for (int j = 0; j < A.GetLength(1); j++){
                resultado[i,j] = B[i,j] + A[i,j];
            }
        }
        return resultado;
    }
    return null;
}
double[,]? Resta(double[,] A, double[,] B){
        if(A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1)){
        double[,] resultado = new double[A.GetLength(0),A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++){         
            for (int j = 0; j < A.GetLength(1); j++){
                resultado[i,j] = B[i,j] - A[i,j];
            }
        }
        return resultado;
    }
    return null;
}
double[,] Multiplicacion(double[,] A, double[,] B){
    if(A.GetLength(0) == B.GetLength(1) && A.GetLength(1) == B.GetLength(0)){
        double[,] resultado = new double[A.GetLength(0),B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++){         
            for (int j = 0; j < A.GetLength(1); j++){
                resultado[i,j] = B[i,j] * A[i,j];
            }
        }
        return resultado;
    }
    throw new ArgumentException(String.Format("El numero de filas de una matriz no coincide con el de columnas de la otra"));
}

void printMatriz (double[,]? matriz){
     for (int n = 0; n < matriz.GetLength(0); n++) {
        // Print the row number
        System.Console.Write("Row({0}): ", n);
        for (int k = 0; k < matriz.GetLength(1); k++) {
            // Print the elements in the row
            System.Console.Write("{0} ", matriz[n,k]);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// Matriz1
double[,] matriz1 = new double[4,4]{
   {0, 1, 2, 3} ,
   {4, 5, 6, 7} ,
   {8, 9, 10, 11} ,
   {12, 13, 14, 15}
};

// Matriz2
double[,] matriz2 = new double[4,4]{
   {2, 1, 0, 3} ,
   {7, 5, 6, 4} ,
   {10, 9, 8, 11} ,
   {16, 15, 14, 17}
};

printMatriz(Suma(matriz1,matriz2));
printMatriz(Resta(matriz1,matriz2));
printMatriz(Multiplicacion(matriz1,matriz2));

Console.WriteLine("\nPresione 'Enter' para finalizar ");
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.Enter) {
    k = Console.ReadKey(true);
}