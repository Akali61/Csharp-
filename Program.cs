// string path = @"C: \ temp";
// string path = "\Users\alptekinkucukali\Desktop\temp\deneme";

string rootPath = Directory.GetCurrentDirectory();

string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);

foreach (var dir in dirs){
    Console.WriteLine(dir);
}

string [] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

foreach (var file in files){
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));
}