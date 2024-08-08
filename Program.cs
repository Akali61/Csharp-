// Random

string[] teams = {"Gs", "Fb","Jk","Ts"};

var rnd = new Random();

int number = rnd.Next(0,4);

Console.WriteLine(number);

Console.WriteLine(teams[number]);