// Compare Operator Practice

//1- Klavyeden girilen yaş bilgisine göre oy kullanma durumunu incelemek.

//Console.Write("Yaşınız: ");
//var age = Convert.ToInt32(Console.ReadLine());

//var result = (age >= 18) ? "Ehliyet alabilirsiniz":"Ehliyet için yaşınız tutmuyor.";
//Console.WriteLine("Ehliyet alabilme durumu: " + result);


//2- Girilen bir sayının işaretini kontrol etmek.

//Console.Write("Number: ");
//var number = Convert.ToInt32(Console.ReadLine());

//var result = (number > 0) ? "Sayı pozitif":"Sayı negatif";
//Console.WriteLine(result);

//3- Girilen sayının tek veya çift olduğunu belirlemek.

Console.Write("Number: ");
var number = Convert.ToInt32(Console.ReadLine());

var result = (number % 2 == 0) ? "This number is couple":"This number is odd";

Console.WriteLine(result);