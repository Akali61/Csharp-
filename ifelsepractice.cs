// If Else Practice
Console.WriteLine("Toplama için: +");
Console.WriteLine("Çıkartmak için: -");
Console.WriteLine("Çarpmak için: *");
Console.WriteLine("Bölmek için: /");

Console.WriteLine("Seçiniz: ");
var secim = Console.ReadLine();

Console.Write("1. Sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

double sonuc = 0;
if (secim == "+") {
    //Toplama
    sonuc = sayi1 + sayi2;
    Console.WriteLine(sonuc);
} else if (secim == "-") {
    //Çıkartma
    sonuc = sayi1 - sayi2;
    Console.WriteLine(sonuc);
} else if (secim == "*") {
    //Çarpma
    sonuc = sayi1 * sayi2;
    Console.WriteLine(sonuc);
} else if (secim == "/"){
    //Bölme
    sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);  
} else {
    Console.WriteLine("Hatalı seçim.");
}
