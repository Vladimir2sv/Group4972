// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1:");
int numOne = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2:");
int numTwo = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 3:");
int numThree = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Максимальное число = " + Math.Max(numOne, Math.Max(numTwo, numThree)));



