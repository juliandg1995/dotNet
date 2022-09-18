int a, b, c; a = 4; b = 7;

Console.WriteLine("Dadas tres números enteros, A, B y C, siendo C igual al menor de los tres\n Si A = " + a + " y B = " + b + " , entonces C = " + (c = (a < b)? a : b) + "\n\n");

for (int i = 0; i <= 4; i++) {
    string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
    // Al usar condicionales ternarios concatenados: 
        // : == "else"
        // (? condición ? condición) == condición AND condición  
    Console.Write(st + "|");
}


Console.ReadLine();