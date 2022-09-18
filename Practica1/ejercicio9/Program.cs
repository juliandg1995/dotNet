using System;

Console.WriteLine("Ingrese dos palabras por teclado separadas por un espacio:");
String str = Console.ReadLine();
// Console.WriteLine(str + '\n');

// Opción sencilla:
Boolean ok = true;
string[] words = str.Split(' ');
if (words[0].Length == words[1].Length){
    String word1 = words[0];
    String word2 = words[1];
    // Console.WriteLine(word1); Console.WriteLine(word2);
    int i = 0;
    while ( i < word1.Length && ok ){
        if ( word1[i] != word2[(word2.Length - (i + 1))] ){
            ok = false;
        }
        i++;
    }
} else {
    ok = false;
}

if (ok){
    Console.WriteLine("Las palabras son simétricas");
} else {
    Console.WriteLine("Las palabras NO son simétricas");
}

Console.ReadLine();

