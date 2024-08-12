// StreamReader sr = File.OpenText("deneme.txt");

// var s = "";

// while((s = sr.ReadLine()) != null) {
//     Console.WriteLine(s);
// }

using (StreamWriter sw = File.CreateText("deneme.txt")) {
    sw.WriteLine("Hello");
    sw.WriteLine("Alptekin");
    sw.WriteLine("Küçükali");
}

using (StreamWriter sw = File.AppendText("deneme.txt")) {
    sw.WriteLine("Hi");
    sw.WriteLine("Alptekin");
    sw.WriteLine("Küçükali");
}

File.WriteAllText("deneme.txt","Hello");
File.AppendAllText("deneme.txt","Hello");

//string result = File.ReadAllText("deneme.txt");
// string [] result = File.ReadAllLines("deneme.txt");

// Console.WriteLine(result[0]);
// Console.WriteLine(result[2]);
