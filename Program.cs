// While Loop Practice

// Guess Number
// Design of a game to find random numbers between 1-100
// The game must end when the specified right ends.

var rnd = new Random();
int randomNumber = rnd.Next(1, 100);
int vitality = 3;

while (vitality > 0) {
    Console.Write("Number: ");
    int userInput = Convert.ToInt32(Console.ReadLine()); 

    vitality--;
    if (vitality == 0) {
        Console.WriteLine("You used all your 3 chances. Game is over.");
        Console.WriteLine($"The correct answer is: {randomNumber}");
            break;
    }

    if (userInput == randomNumber) {
        Console.WriteLine("Congratulations! Your guess is right.");

    }
    else {
        if(randomNumber > userInput) {
            Console.WriteLine("Up");
        } else {
            Console.WriteLine("Down");

        }
    }
}