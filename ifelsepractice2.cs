// If Else Practice 2
// 1- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralğına karşılık gelen not bilgisini yazıdırın.

    // 0 - 24 -> 0
    // 25 - 44 -> 1
    // 45 - 54 -> 2
    // 55 - 69 -> 3
    // 70 - 84 -> 4
    // 85 - 100 -> 5

// Console.Write("1. Exam: ");
// int note1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2. Exam: ");
// int note2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Sözlü: ");
// int sozlu = Convert.ToInt32(Console.ReadLine());

// var average = (note1 + note2 + sozlu) / 3;
// Console.WriteLine("Your average is: " + average);

// if (average >= 0 && average < 25) {
//     Console.WriteLine("You got zero point.");
// } else if (average >= 25 && average < 45){
//     Console.WriteLine("You got 1 point.");
// } else if (average >= 45 && average < 55){
//     Console.WriteLine("You got 2 points");
// } else if (average >= 55 && average < 70){
//     Console.WriteLine("You got 3 points");
// } else if (average >= 70 && average < 85){
//     Console.WriteLine("You got 4 points");
// } else if (average >= 85 && average < 101){
//     Console.WriteLine("Great! You have the best point 5");
// } else {
//     Console.WriteLine("Yanlış girdiniz");
// }

// 2-

Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

int biggest = 0;

if (a > b && a > c) {
    biggest = a;
} else if (b > a && b > c) {
    biggest = b;
} else {
    biggest = c;
}

Console.WriteLine("The biggest: " + biggest);
