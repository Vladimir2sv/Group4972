// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа



//1 Анастасия
// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine(num % 10);


// 2 Иван
//  int N = int.Parse(Console.ReadLine()??"0");
// if (N < 1000 && N > 99){
//     Console.WriteLine("Последняя цифра " + N%10);
// } else {
//     Console.WriteLine("ошибка ввода");
// }

// 3 Артем
// Console.WriteLine("Enter three digit number");
//     int num = int.Parse(Console.ReadLine());
    
//     Console.WriteLine(num % 10);

// 4 Анастасия
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");

// 5 Кирил
// System.Console.WriteLine("Введите трехзначное число:");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int lastDigit = 0;
// if (num >= 100 && num < 1000)
// {
// lastDigit = num % 10;
// }
// else
// {
// System.Console.WriteLine("Число не трехзначное");
// }
// System.Console.WriteLine("Последняя цифра числа: " + lastDigit);