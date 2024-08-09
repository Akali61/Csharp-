// While

// for (var i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// var i = 0;

// while i < 10 {
//     Console.WriteLine(i);
//     i++;
// }

// string[] names = {"Ali", "Ahmet", "Canan"};

// var i = 0;
// while (i < names.Length)
// {
//     Console.WriteLine(names[i]);
//     i++;
// }

var choose = "y";
var counter = 1;
var total = 0;

while (choose == "y") {
    Console.Write($"{counter}. number: ");
    total += Convert.ToInt32(Console.ReadLine());

    Console.Write("You want to continue? yes or no : y/n: ");
    choose = Console.ReadLine();

    counter++;
}

Console.WriteLine($"{counter-1} equal is plus the numbers: {total}");
