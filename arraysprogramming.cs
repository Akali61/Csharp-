// Dizi Uygulama

//Öğrenciler ve notlar olmak üzere 2 tane dizi oluşturulacak.
//3 öğrenciye göre alınan bilgilerle doldurulacak.

//Öğrenci dizisi kaç elemanlı?
//3 öğrenciye de ad-sınav bilgisi sorulur.
//Tüm öğrencilerin not ortalaması nedir?

var students = new string[3];
var exams = new int[3];

Console.Write("1. Student's name: ");
students[0] = Console.ReadLine() ?? "";
Console.Write("1. Student's exam point: ");
exams[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Student's name: ");
students[1] = Console.ReadLine() ?? "";
Console.Write("2. Student's exam point: ");
exams[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Student's name: ");
students[2] = Console.ReadLine() ?? "";
Console.Write("3. Student's exam point: ");
exams[2] = Convert.ToInt32(Console.ReadLine());

foreach(var student in students[..3]){
    Console.WriteLine(student);
}

foreach(var exam in exams[..3]){
    Console.WriteLine(exam);
}

Console.WriteLine("Number of students: " + students.Length);

var exam1 = exams[0];
var exam2 = exams[1];
var exam3 = exams[2];

var average = (exam1+exam2+exam3) / 3;

Console.WriteLine("Student's exam average is: " + average);
