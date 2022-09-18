Console.Write("Ingrese un nro por teclado. Será multiplicado por 365: "); int num = int.Parse(Console.ReadLine());
String st = (num * 365).ToString();
Console.WriteLine(st);
for (int i = 0; i < st.Length; i++){
    Console.Write(st[i] + " | " );
}

Console.ReadLine();
