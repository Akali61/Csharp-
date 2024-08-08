// Switch Case

// int day = (int)DateTime.Now.DayOfWeek; // 0 => Pazar, 1 => Pazartesi... 6 => Cumartesi

// switch (day) {
//     case 0:
//         Console.WriteLine("Pazar");
//         break;

//     case 1:
//         Console.WriteLine("Pazartesi");
//         break;
    
//     case 2:
//         Console.WriteLine("Salı");
//         break;

//     case 3:
//         Console.WriteLine("Çarşamba");
//         break;

//     case 4:
//         Console.WriteLine("Perşmebe");
//         break;

//     case 5:
//         Console.WriteLine("Cuma");
//         break;

//     case 6:
//         Console.WriteLine("Cumartesi");
//         break;

//     default:
//         Console.WriteLine("Wrong Day");
//         break;
// }


int month = 12;

switch(month) 
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("Winter");
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("Winter");
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("Winter");
        break;

    default:
        Console.WriteLine("Wrong month information.");
        break;

}
