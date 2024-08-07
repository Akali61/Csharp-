//Multidimensional Arrays

// Alptekin -> 50,60,70
// Ahmet -> 60,80,90
// Ali -> 50,70,30

//Calculate each student's grade point average.

string[] students = {"Ali","Ahmet","Canan"};
int[,] examnotes = new int[3,3];

//ALPTEKİN
examnotes[0,0] = 50;
examnotes[0,1] = 60;
examnotes[0,2] = 70;

//AHMET
examnotes[1,0] = 60;
examnotes[1,1] = 80;
examnotes[1,2] = 90;

//ALİ
examnotes[1,0] = 50;
examnotes[1,1] = 70;
examnotes[1,2] = 30;

//Console.WriteLine($"{students[0]} name of this student's average in his exams: {examnotes[0,0]}");

var average_1 = (examnotes[0,0] + examnotes[0,1] + examnotes[0,2]) / 3;
var average_2 = (examnotes[1,0] + examnotes[1,1] + examnotes[1,2]) / 3;
var average_3 = (examnotes[2,0] + examnotes[2,1] + examnotes[2,2]) / 3;

Console.WriteLine($"{students[0]} name of this student's average in his exams: {average_1}");
Console.WriteLine($"{students[1]} name of this student's average in his exams: {average_2}");
Console.WriteLine($"{students[2]} name of this student's average in his exams: {average_3}");
