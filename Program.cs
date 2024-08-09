// For Loop Practice

// 1- Print the sum of the numbers between 1 and 100.

// var total = 0;

// for (var i = 1; i <= 100; i++)
// {
//     if (i % 2 == 1) {
//         total += i;
//     }
// }
// Console.WriteLine(total);

// 2- Calculate the sum of all numbers between the start and end values ​​entered on the keyboard.

// Console.Write("Beginning: ");
// var beginning = Convert.ToInt32(Console.ReadLine());

// Console.Write("End: ");
// var end = Convert.ToInt32(Console.ReadLine());

// Console.Write("Increase: ");
// var increase = Convert.ToInt32(Console.ReadLine());

// var total = 0;
// for (var i = beginning; i < end; i = i + increase)
// {
//     total += i;
// }
// Console.WriteLine(total);

// 3- {"Ali","Ahmet","Can","Yelda","Seda"} Print all elements in the array to the screen.

// string[] names = {"Ali","Ahmet","Can","Yelda","Seda"};

// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine(names[i]);
// }

// 4- {1,3,4,34,41,56,89,100} How many of the numbers in the series are even?

int [] numbers = {1,3,4,34,41,56,89,100};

for (var i = 0; i < numbers.Length; i++) {
    if (numbers[i] % 3 == 0) {
        Console.WriteLine(numbers[1]);
    }
}