// Compare Operators

int a = 61, b = 5, c = 10, d = 3;
string username = "Alptekin Küçükali";
string password = "1234";

var result = (a == b); //True
result = (c == d);
result = (username == "Alptekin Küçükali"); //True
result = (password == "12345"); //False

result = (a != b);
result = (a > c);
result = (a < c);
result = (a >= b);

    //Ternary
var result2 = (a > b) ? "a büyük": (a == b) ? "a ve b eşit.": "b büyük";

Console.WriteLine(result2);