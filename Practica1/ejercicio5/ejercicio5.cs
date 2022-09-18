using System;

String st;

Console.WriteLine("Ingrese su nombre: "); st = Console.ReadLine();
if (st.Length == 0){
    Console.WriteLine("Buen día, Mundo!");
} else {
    st = st.toUpper();
    switch (st){
        case "JUAN": 
            Console.WriteLine("Hola amigo!" );
        case "MARÍA": 
            Console.WriteLine("Buen día, señora");
        case "ALBERTO": 
            Console.WriteLine("Hola Alberto");
        default:
            Console.WriteLine('Buen día, ' + st );
    }
}

Console.ReadLine();