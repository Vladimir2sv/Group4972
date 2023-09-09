// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


Console.WriteLine("1");
// Console.WriteLine("Введите 1-е число: ");
// int firstNum = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("Введите 2-е число: ");
// int secondNum = int.Parse(Console.ReadLine() ?? "0");

// bool test1 = (firstNum == secondNum * secondNum);
// bool test2 = (secondNum == firstNum * firstNum);

// if (test1)
// {
//     Console.WriteLine("Первое число квадрат второго");
// }
// if (test2)
// {
//     Console.WriteLine("Второе число квадрат первого");
// }
// if (!(test1 || test2))
// {
//     Console.WriteLine("Число 1 не квадрат 2-го и чило 2 не квадрат 1-го");
// }

Console.WriteLine("2");
// int first_number = int.Parse(Console.ReadLine()??"0");
// int second_number = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine(first_number > second_number? (first_number ^ (second_number*second_number))==0:(second_number ^ (first_number*first_number))==0);


Console.WriteLine("3");
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (num1 == num2*num2);
bool test2 = (num2 == num1*num1);

Console.WriteLine((test1 || test2) ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");