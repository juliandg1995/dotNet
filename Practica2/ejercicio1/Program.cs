// Cuando se asigna el valor de un literal a un tipo object --> Boxing
// Cuando se asigna el valor de un tipo por referencia (ej: object) a una variable por valor --> Unboxing

char c1 = 'A';
string st1 = "A";
object o1 = c1; // Boxing
object o2 = st1; // Boxing 
char c2 = (char)o1; // Unboxing
string st2 = (string)o2; // Unboxing
