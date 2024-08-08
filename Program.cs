// Logical Operators Practice

// 1- Yaşı 18 den büyük ya da veli izni varsa bir işte çalışma durumunu kontrol ediniz.

//int age = 12;
//bool parental_permission = false;

//bool age_control = (age >= 18);
//bool parental_control = (parental_permission);

//var result = (age_control || parental_control) ? "He can working":"He can't working";

//Console.WriteLine(result);

// 2- Ders notu 50-100 arasında ise geçti, değilse kaldı bilgisini ekrana yazdırınız.

//int exam_note = 45;

//bool condition1 = (exam_note >= 50);
//bool condition2 = (exam_note <= 100);

//var result = (condition1 && condition2) ? "He passed":"He failed";
//Console.WriteLine(result);

// 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşşekkür belgesi alabilme durumuna bakınız.

//int average = 70;
//int low = 1;

//var result = (average >= 70 && low == 1) ? "Teşekkür belgesi alabilir.":"Teşekkür belgesi alamaz";

//Console.WriteLine(result);

// 4- İşe girebilmek için en az önlisans veya lisans mezunu olma durumunu ve sigara durumunu kontrol.

//string education = "high school";
//bool cigarette = false;

//var result = ((education == "licence" || education == "Associate degree") && (!cigarette)) ? "He can working.":"He can't working.";
//Console.WriteLine(result);

// 5- Uygulamaya giriş kontrolünü username ya da parola için yapınız.

string e_mail = "alptekin196761@gmail.com";
string username = "a.kali";
string password = "12345";

var result = (e_mail == "alptekin196761@gmail.com" || username == "a.kali" || password == "12345");
Console.WriteLine(result);