// Break & Continue

// string name = "Alptekin Küçükali";

// for (var i = 0; i < name.Length; i++)
// {
//     if (name[i] == 'i')
//         continue;
    
//     Console.WriteLine(name[i]);
// }
// Console.WriteLine("The loops end.");


int x = 0;
while(x < 5) {
    x++;
    if (x == 3)
        continue;
    Console.WriteLine(x);
}