// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число 1:");
int numOne = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2:");
int numTwo = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Максимальное число = " + Math.Max(numOne, numTwo));