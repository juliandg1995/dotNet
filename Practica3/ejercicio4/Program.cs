int[,] matriz = new int[7,7];

double?[] GetDiagonalPrincipal(double[,] matriz){
    int rows = matriz.GetLength(0);
    int col = matriz.GetLength(1);
    double?[] diagonal;

    if (rows == col){
        diagonal = new double?[rows];
        for (int i=0; i < diagonal.Length; i++){
            diagonal[i] = matriz[i,i];
        }
    } else {
         throw new ArgumentException(String.Format($"El numero de filas ({rows}) no  es igual al de columnas ({col})"));
    }
    return diagonal;
}

double?[] GetDiagonalSecundaria(double[,] matriz){
    int rows = matriz.GetLength(0);
    int col = matriz.GetLength(1);
    double?[] diagonal;

    if (rows == col){
        diagonal = new double?[rows];
        for (int i= diagonal.Length - 1; i >= 0; i--){
            diagonal[i] = matriz[i,i];
        }
    } else {
         throw new ArgumentException(String.Format($"El numero de filas ({rows}) no  es igual al de columnas ({col})"));
    }
    return diagonal;
}


