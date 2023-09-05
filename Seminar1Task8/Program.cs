// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int lastDigit = 0;
if (num >= 100 && num < 1000)
{
lastDigit = num % 10;
}
else
{
System.Console.WriteLine("Число не трехзначное");
}
System.Console.WriteLine("Последняя цифра числа: " + lastDigit);