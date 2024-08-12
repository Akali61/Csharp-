// Do-While Loop

// int i = 1;
// do {
//     Console.WriteLine(i);
//     i++;
// } while (false);

Console.Write("Piece: ");

int piece = Convert.ToInt32(Console.ReadLine());

string [] products = new string[piece];
int i = 0;

do {
    Console.Write("Product Name: ");
    products[i] = Console.ReadLine() ?? "";

    i++;
} while (piece != i);

Console.WriteLine("Products are listed...");

for (var a = 0; a < products.Length; a++) {
    Console.WriteLine(products[a]);
}
