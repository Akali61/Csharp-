// Directory.CreateDirectory("temp");
// Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");

if(Directory.Exists("temp/deneme2")) {
    Directory.Delete("temp/deneme");
} else {
    Console.WriteLine ("There is no folder you want to delete.");
}