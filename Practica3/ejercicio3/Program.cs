/*
Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo
de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en
la misma línea en la consola.
*/
using System.Text;
using System.Linq;

void ImprimirMatriz(double[,] matriz, String formato){
    int rows = matriz.GetLength(0);
    int col = matriz.GetLength(1);
    int decLen, intVal, decVal; 
    String aux;
    if (formato.Contains(".")){
        string[]? subs = formato.Split('.');
        decLen = subs[1].Length;

        // Console.WriteLine("Rows: " + rows + " - Cols: " + col);
        for (int i = 0; i < rows; i++){
            Console.Write("Fila " + (i + 1) + ": ");
            for (int j = 0; j < col; j++){
                aux = Convert.ToDouble(matriz[i,j]).ToString();
                if(!aux.Contains(",")){
                    aux = aux + ",0";
                }
                subs = aux.Split(',');
                if (subs[1] != null){
                    while(subs[1].Length < decLen){
                        subs[1] = subs[1] + "0";
                    }
                }
                Console.Write($"{subs[0]}.{new String(subs[1].Take(decLen).ToArray())} - ");
            }
            Console.Write("\n");
        }
    }
    return;
}

double[,] matriz = new double[,] { {1.321,2.789,3,4.32547},{5.456,6.368,7.367,8.3247},{9.368,10.3657,11.3687,12.3578} };
ImprimirMatriz(matriz, "0.00");

ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End){
    k = Console.ReadKey();
}
