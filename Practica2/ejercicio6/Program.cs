char c;
char? c2;
string? st; // -> El ? indica que se le puede pasar el valor null (Porque para todos los literales por defecto no es posible)
// c = ""; -> No se puede convertir implícitamente el tipo string en char
// c = ''; -> No compila ("Literal de caracter vacío")
// c = null; -> Tampoco compila (Le falta el ? en la declaración)
c2 = null;
c2 = (65 as char?);
st = "";
// st = ''; -> No compila ("Literal de caracter vacío)
st = null;
// st = (char)65; -> No se puede convertir imlicitamente de char a string
// st = (string)65; -> Idem linea 12, pero de int a string
st = 47.89.ToString();
