// Logical Operators

var a = true;
var b = true;
var c = false;
var d = false;

// 1- And - &&

var result = (a && b);
result = (a && c);
result = (c && d);

// 2- Or - ||

result = (a || b);
result = (c || b);
result = (c || d);

// 3- Not - !

result = !c;
Console.WriteLine(result);
